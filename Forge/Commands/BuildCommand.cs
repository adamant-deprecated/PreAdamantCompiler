﻿using System;

namespace PreAdamant.Compiler.Forge.Commands
{
	public class BuildCommand : ProjectDirCommand
	{
		public BuildCommand()
		{
			IsCommand("build", "Build a forge project");
		}

		public override int Run(string[] remainingArguments)
		{
			try
			{
				var compiler = new ProjectCompiler(ProjectPath);
				var emitter = new ProjectEmitter(ProjectPath);
				compiler.ProjectCompiled += emitter.Emit;
				var projects = compiler.Compile();
				return 0;
			}
			catch(CompileFailedException)
			{
				Console.WriteLine("Build Failed, stopping");
				return 1;
			}
		}
	}
}
