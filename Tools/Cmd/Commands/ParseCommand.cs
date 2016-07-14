using System;
using ManyConsole;

namespace PreAdamant.Compiler.Tools.Cmd.Commands
{
	public class ParseCommand : ConsoleCommand
	{
		public ParseCommand()
		{
			IsCommand("parse", "generate parser from *.parse file");
			HasAdditionalArguments(1);
		}

		public override int Run(string[] remainingArguments)
		{
			throw new NotImplementedException();
		}
	}
}
