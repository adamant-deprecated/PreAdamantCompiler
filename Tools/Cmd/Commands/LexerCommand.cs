using System.IO;
using ManyConsole;
using PreAdamant.Compiler.Tools.Lex;

namespace PreAdamant.Compiler.Tools.Cmd.Commands
{
	public class LexerCommand : ConsoleCommand
	{
		public LexerCommand()
		{
			IsCommand("lexer", "generate lexer from *.lex file");
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
			var parserGenerator = new LexerGenerator();
			var parserCode = parserGenerator.Generate(spec);
			var parserCodePath = Path.Combine(dir, specFileName + ".cs");
			File.WriteAllText(parserCodePath, parserCode);

			// Generate TokenTransformer.cs file
			var transformerGenerator = new TransformerGenerator();
			var transformerCode = transformerGenerator.Generate(spec);
			var transformerCodePath = Path.Combine(dir, specFileName.Replace("Lexer", "") + "TokenTransformer.cs");
			File.WriteAllText(transformerCodePath, transformerCode);

			// Generate Tokens.cs file
			var tokensGenerator = new TokensGenerator();
			var tokensCode = tokensGenerator.Generate(spec);
			var tokensCodePath = Path.Combine(dir, specFileName + ".Tokens.cs");
			File.WriteAllText(tokensCodePath, tokensCode);

			return 0;
		}
	}
}
