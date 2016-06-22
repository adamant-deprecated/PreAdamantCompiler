using System;

namespace PreAdamant.Compiler.Forge.Commands
{
	public class RunCommand : ProjectDirCommand
	{
		public RunCommand()
		{
			IsCommand("run", "Build and run forge project");
		}

		public override int Run(string[] remainingArguments)
		{
			throw new NotImplementedException();
		}
	}
}
