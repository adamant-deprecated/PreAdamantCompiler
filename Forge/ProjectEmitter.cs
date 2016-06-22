﻿using System;
using System.IO;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Emit.Cpp;

namespace PreAdamant.Compiler.Forge
{
	public class ProjectEmitter
	{
		private readonly PreAdamantCompiler compiler = new PreAdamantCompiler();

		public void Emit(Project project, Projects projects)
		{
			Console.WriteLine($"Emitting {project.Name} ...");

			var compileDirPath = Path.Combine(project.ProjectDirectory, ".forge-cache");
			DirectoryUtil.SafeDelete(compileDirPath);

			var targetDirPath = Path.Combine(project.ProjectDirectory, "targets", "debug");
			DirectoryUtil.SafeDelete(targetDirPath);

			Directory.CreateDirectory(compileDirPath);
			var cppSource = compiler.EmitCpp(project.Package);
			var cppSourceName = project.Name + ".cpp";

			CreateFile(compileDirPath, cppSourceName, cppSource);
			if(project.Package.IsApp)
			{
				// write out the runtime
				CreateFile(compileDirPath, CppRuntime.FileName, CppRuntime.Source);
				foreach(var dependency in projects)
				{
					var dependencyCppFileName = dependency.Name + ".cpp";
					var dependencyCppFilePath = Path.Combine(dependency.ProjectDirectory, ".forge-cache", dependencyCppFileName);
					File.Copy(dependencyCppFilePath, Path.Combine(compileDirPath, dependencyCppFileName));
				}
				Directory.CreateDirectory(targetDirPath);
				var result = CppCompiler.Invoke(Path.Combine(compileDirPath, cppSourceName), Path.Combine(targetDirPath, project.Name + ".exe"));
				if(result.ExitCode != 0)
					result.WriteOutputToConsole();
			}
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
