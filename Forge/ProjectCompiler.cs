using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Forge.Config;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler.Forge
{
	public class ProjectCompiler
	{
		private readonly string projectFilePath;
		private readonly PreAdamantCompiler compiler = new PreAdamantCompiler();
		public event Action<Project, Projects> ProjectCompiled;

		public ProjectCompiler(string projectFilePath)
		{
			this.projectFilePath = projectFilePath;
		}

		public Projects Compile()
		{
			var projects = new Projects();
			Compile(projectFilePath, projects);
			return projects;
		}

		private void Compile(string projectFilePath, Projects projects)
		{
			var projectDirPath = Path.GetFullPath(Path.GetDirectoryName(projectFilePath));
			var projectConfig = JsonConvert.DeserializeObject<ProjectConfig>(File.ReadAllText(projectFilePath));
			projectConfig.Name = projectConfig.Name ?? Path.GetFileName(projectDirPath);

			CompileDependencies(projectDirPath, projectConfig, projects);
			CompileProject(projectDirPath, projectConfig, projects);
			CompileSubProjects(projectDirPath, projectConfig, projects);
		}

		private void CompileDependencies(string projectDirPath, ProjectConfig projectConfig, Projects projects)
		{
			var paths = projectConfig.Dependencies
					.Where(d => !projects.Contains(d.Key))
					.Select(d => DependencyPath(d.Key, d.Value, projectDirPath, projectConfig.DependencyPaths));

			foreach(var path in paths)
				Compile(Path.Combine(path, ProjectFile.Name), projects);
		}

		private static string DependencyPath(string dependencyName, DependencyConfig config, string projectDirPath, IList<string> dependencyPaths)
		{
			if(!string.IsNullOrEmpty(config.Path))
				return Path.Combine(projectDirPath, config.Path);

			foreach(var dependencyPath in dependencyPaths)
			{
				var tryPath = Path.Combine(projectDirPath, dependencyPath, dependencyName);
				if(Directory.Exists(tryPath))
					return tryPath;
			}
			throw new Exception("Could not find dependency");
		}

		private void CompileProject(string projectDirPath, ProjectConfig projectConfig, Projects projects)
		{
			Console.WriteLine($"Compiling {projectConfig.Name} ...");

			var sourcePath = Path.Combine(projectDirPath, "src");
			var sourceFiles = new DirectoryInfo(sourcePath).GetFiles("*.adam", SearchOption.AllDirectories);
			var isApp = projectConfig.Template == "app";
			// TODO read trusted from config
			var package = new PackageContext(projectConfig.Name, isApp, projectConfig.Dependencies.Select(d => new PackageReferenceContext(d.Key, null, true)));
			var projectPathLength = Path.GetFullPath(sourcePath).Length;
			foreach(var fileInfo in sourceFiles)
				compiler.Parse(package, new SourceText(package.Name, fileInfo.FullName.Substring(projectPathLength).TrimStart('\\'), fileInfo));

			if(package.Diagnostics.Count > 0)
			{
				PrintDiagnostics(package);
				return;
			}
			compiler.Compile(package, projects.Select(p => p.Package));
			var project = new Project(projectDirPath, package);
			projects.Add(project);
			OnProjectCompiled(project, projects);
		}

		protected void OnProjectCompiled(Project project, Projects projects)
		{
			ProjectCompiled?.Invoke(project, projects);
		}

		private void CompileSubProjects(string projectDirPath, ProjectConfig projectConfig, Projects packages)
		{
			// Build Projects that weren't already built as dependencies
			foreach(var project in projectConfig.Projects)
			{
				var projectName = project.Key;
				if(packages.Contains(projectName)) continue;
				Compile(Path.Combine(projectDirPath, project.Value, ProjectFile.Name), packages);
				// TODO copy into target
			}
		}

		private static void PrintDiagnostics(PackageContext package)
		{
			ISourceText file = null;
			foreach(var diagnostic in package.Diagnostics)
			{
				if(file != diagnostic.File)
				{
					file = diagnostic.File;
					Console.WriteLine($"In {file.Name}");
				}
				var level = diagnostic.Level.ToString();
				var line = diagnostic.Position.Line + 1;
				var column = diagnostic.Position.Column + 1;
				Console.WriteLine($"{level} on line {line} at character {column}: ");
				Console.WriteLine($"    {diagnostic.Message}");
			}
		}
	}
}
