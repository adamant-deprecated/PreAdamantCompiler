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
			var dir = Path.GetDirectoryName(lexerSpecPath);
			var lexerSpecContents = File.ReadAllText(lexerSpecPath);
			var spec = new SpecReader().Read(lexerSpecContents, lexerName => File.ReadAllText(Path.Combine(dir, lexerName + ".lex")));
			var generator = new AntlrGenerator();
			var antlrSpec = generator.Generate(spec);

			var fileName = Path.GetFileNameWithoutExtension(lexerSpecPath);
			var antlrSpecPath = Path.Combine(dir, fileName + ".ANTLR.g4");
			File.WriteAllText(antlrSpecPath, antlrSpec);
			return 0;
		}
	}
}
