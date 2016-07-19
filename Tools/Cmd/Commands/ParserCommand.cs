using System.IO;
using ManyConsole;
using PreAdamant.Compiler.Tools.Parse;

namespace PreAdamant.Compiler.Tools.Cmd.Commands
{
	public class ParserCommand : ConsoleCommand
	{
		public ParserCommand()
		{
			IsCommand("parser", "generate parser from *.parse file");
			HasAdditionalArguments(1);
		}

		public override int Run(string[] remainingArguments)
		{
			var parserSpecPath = remainingArguments[0];
			var dir = Path.GetDirectoryName(parserSpecPath);
			var parserSpecContents = File.ReadAllText(parserSpecPath);
			var spec = new SpecReader().Read(parserSpecContents);
			var specFileName = Path.GetFileNameWithoutExtension(parserSpecPath);


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
