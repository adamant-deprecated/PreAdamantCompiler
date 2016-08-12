using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Core.Diagnostics;
using PreAdamant.Compiler.Emit.Cpp;
using PreAdamant.Compiler.Semantics;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Tests
{
	[TestFixture]
	public class Harness
	{
		private const string Extension = ".adam";
		private readonly PreAdamantCompiler compiler = new PreAdamantCompiler();
		private readonly TestCaseError[] noErrors = new TestCaseError[0];
		private string workPath;
		private string dependenciesPath;

		private static readonly Dictionary<string, List<string>> packageDependencies = new Dictionary<string, List<string>>()
		{
			{"System.Console", new List<string>()}
		};

		[TestFixtureSetUp]
		public void SetUp()
		{
			workPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
			Directory.CreateDirectory(workPath);
			dependenciesPath = ConfigurationManager.AppSettings["DependenciesPath"];
		}

		[TestFixtureTearDown]
		public void TearDown()
		{
			Directory.Delete(workPath, true);
		}

		[Test, TestCaseSource(nameof(TestCases))]
		public void Test(TestCaseConfig config, TextReader reader)
		{
			var packageReferences = config.Dependencies.SelectMany(d => packageDependencies[d])
				.Concat(config.Dependencies)
				.Distinct()
				.Select(d => new PackageReferenceSyntax(d, null, true)).ToList();
			var packages = CompileDependencies(packageReferences);

			var syntaxTree = Parse(new SourceText("Test", config.FileName, reader), config.Errors);
			if(syntaxTree.Diagnostics.Any()) return; // expected parse errors happened
			var testPackageSyntax = new PackageSyntax($"Adamant.Exploratory.Compiler.Tests.{config.TestName}", true, packageReferences, new[] { syntaxTree });
			var testPackage = Compile(testPackageSyntax, packages);

			packages.Add(testPackage);
			foreach(var package in packages)
			{
				var cppSource = compiler.EmitCpp(package);
				var cppSourceName = package.Name + ".cpp";
				CreateFile(cppSourceName, cppSource);
			}

			CreateFile(CppRuntime.FileName, CppRuntime.Source);
			var targetPath = Path.Combine(workPath, config.TestName + ".exe");
			var result = CppCompiler.Invoke(Path.Combine(workPath, testPackage.Name + ".cpp"), targetPath);
			if(result.ExitCode != 0)
			{
				result.WriteOutputToConsole();
				Assert.Fail("C++ compiler error");
			}

			// Execute the app
			using(var process = new Process())
			{
				process.StartInfo.FileName = targetPath;
				process.StartInfo.WorkingDirectory = Path.GetDirectoryName(workPath);
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				var outputBuffer = new StringBuilder();
				var errorBuffer = new StringBuilder();
				process.OutputDataReceived += (s, e) => outputBuffer.AppendLine(e.Data);
				process.ErrorDataReceived += (s, e) => errorBuffer.AppendLine(e.Data);
				process.Start();
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
				process.WaitForExit();

				Assert.AreEqual(config.Result, process.ExitCode, "Exit Code");
				if(config.VerifyConsoleOutput)
					Assert.AreEqual(config.ExpectedConsoleOutput, outputBuffer.ToString());
			}
		}

		/// <summary>
		/// Compiles dependencies. This is simplified from what forge would do
		/// </summary>
		private IList<Package> CompileDependencies(List<PackageReferenceSyntax> packageReferences)
		{
			// We compile references in order, assuming that each depends on all packages before it.
			// So they must be listed in order correctly
			var references = new List<PackageReferenceSyntax>();
			var packages = new List<Package>();
			foreach(var reference in packageReferences)
			{
				var packagePath = Path.GetFullPath(Path.Combine(dependenciesPath, reference.Name));
				var sourceFilePaths = Directory.GetFiles(packagePath, "*" + Extension, SearchOption.AllDirectories);

				// Parse all the source files in the package
				var syntaxTrees = sourceFilePaths
					.Select(sourceFilePath => new SourceText(reference.Name, sourceFilePath.Substring(packagePath.Length + 1), new FileInfo(sourceFilePath)))
					.Select(source => Parse(source, noErrors));

				var packageSyntax = new PackageSyntax(reference.Name, false, references, syntaxTrees);
				var package = Compile(packageSyntax, packages);

				packages.Add(package);
				references.Add(reference);
			}

			return packages;
		}

		private SyntaxTree<CompilationUnitSyntax> Parse(SourceText sourceText, TestCaseError[] expectedErrors)
		{
			var syntaxTree = compiler.Parse(sourceText);
			foreach(var diagnostic in syntaxTree.Diagnostics)
				if(!IsExpected(diagnostic, expectedErrors))
					Assert.Fail(ToString(syntaxTree.Diagnostics));

			return syntaxTree;
		}

		private static bool IsExpected(Diagnostic diagnostics, TestCaseError[] expectedErrors)
		{
			foreach(var expectedError in expectedErrors)
				if(diagnostics.Position.Line + 1 == expectedError.Line
				   && diagnostics.Position.Column + 1 == expectedError.Column)
				{
					if(expectedError.Message == null || expectedError.Message == diagnostics.Message)
						return true;
				}
			return false;
		}

		private Package Compile(PackageSyntax packageSyntax, IEnumerable<Package> dependencies)
		{
			var package = compiler.Compile(packageSyntax, dependencies);
			if(package.Diagnostics.Count > 0)
				Assert.Fail(ToString(package.Diagnostics));
			return package;
		}

		private void CreateFile(string fileName, string content)
		{
			using(var file = File.CreateText(Path.Combine(workPath, fileName)))
			{
				file.Write(content);
			}
		}

		private static string ToString(IEnumerable<Diagnostic> diagnostics)
		{
			var builder = new StringBuilder();
			ISourceText file = null;
			foreach(var diagnostic in diagnostics)
			{
				if(file != diagnostic.Source)
				{
					file = diagnostic.Source;
					builder.AppendLine($"In {file.Name}");
				}
				var level = diagnostic.Level.ToString();
				var line = diagnostic.Position.Line + 1;
				var column = diagnostic.Position.Column + 1;
				builder.AppendLine($"{level} on line {line} at character {column}: ");
				builder.AppendLine($"    {diagnostic.Message}");
			}
			return builder.ToString();
		}

		public IEnumerable<TestCaseData> TestCases()
		{
			var namespaceLength = typeof(Harness).Namespace.Length + 1;
			var assembly = Assembly.GetExecutingAssembly();
			var resourceNames = assembly.GetManifestResourceNames().Where(name => name.EndsWith(Extension));
			foreach(var resourceName in resourceNames)
			{
				var stream = assembly.GetManifestResourceStream(resourceName);
				var reader = new StreamReader(stream);
				var config = TestCaseConfig.Read(reader);
				config.FileName = resourceName;
				config.TestName = resourceName.Substring(namespaceLength, resourceName.Length - namespaceLength - Extension.Length);
				var testCaseData = new TestCaseData(config, reader).SetName(config.TestName);
				if(!string.IsNullOrWhiteSpace(config.Description))
					testCaseData.SetDescription(config.Description);
				yield return testCaseData;
			}
		}
	}
}
