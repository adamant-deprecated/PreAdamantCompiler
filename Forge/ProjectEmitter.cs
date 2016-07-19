using System;
using System.IO;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Emit.Cpp;

namespace PreAdamant.Compiler.Forge
{
	public class ProjectEmitter
	{
		private readonly PreAdamantCompiler compiler = new PreAdamantCompiler();
		private readonly string projectDirectory;
		private readonly string compileDirPath;
		private readonly string targetDirPath;

		public ProjectEmitter(string projectFilePath)
		{
			Console.WriteLine("Cleaning project workspace in prep for emitting ...");

			projectDirectory = Path.GetFullPath(Path.GetDirectoryName(projectFilePath));

			compileDirPath = Path.Combine(projectDirectory, ".forge-cache");
			DirectoryUtil.SafeDelete(compileDirPath);

			targetDirPath = Path.Combine(projectDirectory, "targets", "debug");
			DirectoryUtil.SafeDelete(targetDirPath);

			Directory.CreateDirectory(compileDirPath);

			Console.WriteLine("Emitting Runtime ...");
			CreateFile(compileDirPath, CppRuntime.FileName, CppRuntime.Source);
		}

		public void Emit(Project project, Projects projects)
		{
			//Console.WriteLine($"Emitting {project.Name} ...");

			//var cppSource = compiler.EmitCpp(project.Package);
			//var cppSourceName = project.Name + ".cpp";

			//CreateFile(compileDirPath, cppSourceName, cppSource);
			//// If this package is an app then we will output an exe for it in our target dir
			//if(project.Package.IsApp)
			//{
			//	Directory.CreateDirectory(targetDirPath);
			//	var result = CppCompiler.Invoke(Path.Combine(compileDirPath, cppSourceName), Path.Combine(targetDirPath, project.Name + ".exe"));
			//	if(result.ExitCode != 0)
			//		result.WriteOutputToConsole();
			//}
		}

		private static void CreateFile(string directory, string fileName, string content)
		{
			using(var file = File.CreateText(Path.Combine(directory, fileName)))
			{
				file.Write(content);
			}
		}
	}
}
