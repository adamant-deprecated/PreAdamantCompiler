using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Core.Diagnostics;
using PreAdamant.Compiler.Emit.Cpp;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler.Tests
{
	[TestFixture]
	public class Harness
	{
		private const string Extension = ".adam";
		private readonly PreAdamantCompiler compiler = new PreAdamantCompiler();
		private readonly PackageReferenceContext runtimeDependency = new PackageReferenceContext("System.Runtime", null, true);

		private string workPath;

		[TestFixtureSetUp]
		public void SetUp()
		{
			workPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
			Directory.CreateDirectory(workPath);
		}

		[TestFixtureTearDown]
		public void TearDown()
		{
			Directory.Delete(workPath, true);
		}

		[Test, TestCaseSource(nameof(TestCases))]
		public void Test(TestCaseConfig config, TextReader reader)
		{
			var dependencies = config.Runtime ? new[] { runtimeDependency } : Enumerable.Empty<PackageReferenceContext>();
			var package = new PackageContext($"Adamant.Exploratory.Compiler.Tests.{config.TestName}", true, dependencies);
			compiler.Parse(package, new SourceReader("Test", config.FileName, reader));
			if(package.Diagnostics.Count > 0)
				Assert.Fail(ToString(package.Diagnostics));
			compiler.Compile(package, Enumerable.Empty<PackageContext>());
			if(package.Diagnostics.Count > 0)
				Assert.Fail(ToString(package.Diagnostics));

			var cppSource = compiler.EmitCpp(package);
			var cppSourceName = config.TestName + ".cpp";
			CreateFile(cppSourceName, cppSource);
			CreateFile(CppRuntime.FileName, CppRuntime.Source);
			var targetPath = Path.Combine(workPath, config.TestName + ".exe");
			var result = CppCompiler.Invoke(Path.Combine(workPath, cppSourceName), targetPath);
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

				if(config.Result != null)
					Assert.AreEqual(config.Result, process.ExitCode, "Exit Code");
				if(config.VerifyConsoleOutput)
					Assert.AreEqual(config.ExpectedConsoleOutput, outputBuffer.ToString());
			}
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
				if(file != diagnostic.File)
				{
					file = diagnostic.File;
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
