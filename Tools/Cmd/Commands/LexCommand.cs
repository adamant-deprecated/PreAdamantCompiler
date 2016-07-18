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
			var specFileName = Path.GetFileNameWithoutExtension(lexerSpecPath);

			// Generate ANTLR file
			var antlrGenerator = new AntlrGenerator();
			var antlrSpec = antlrGenerator.Generate(spec);
			var antlrSpecPath = Path.Combine(dir, specFileName + "_Antlr.g4");
			File.WriteAllText(antlrSpecPath, antlrSpec);

			// Generate Parser.cs file
			var parserGenerator = new ParserGenerator();
			var parserCode = parserGenerator.Generate(spec);
			var parserCodePath = Path.Combine(dir, specFileName + ".cs");
			File.WriteAllText(parserCodePath, parserCode);

			return 0;
		}
	}
}
