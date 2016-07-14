using System.IO;
using ManyConsole;
using PreAdamant.Compiler.Tools.Lex;

namespace PreAdamant.Compiler.Tools.Cmd.Commands
{
	public class LexCommand : ConsoleCommand
	{
		public LexCommand()
		{
			IsCommand("lex", "generate lexer from *.lex file");
			HasAdditionalArguments(1, " <spec>");
		}

		public override int Run(string[] remainingArguments)
		{
			var lexerSpecPath = remainingArguments[0];
			var lexerSpecContents = File.ReadAllText(lexerSpecPath);
			var spec = new SpecReader().Read(lexerSpecContents);
			return 0;
		}
	}
}
