using System.IO;
using Antlr4.Runtime;
using PreAdamant.Compiler.Lexer;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler
{
	public class SourceReader : SourceText
	{
		private readonly TextReader reader;

		public SourceReader(string package, string name, TextReader reader)
		{
			this.reader = reader;
			Package = package;
			Name = name;
		}

		public override string Package { get; }
		public override string Name { get; }
		internal override PreAdamantParser NewParser()
		{
			return new PreAdamantParser(new PreAdamantLexer(new AntlrInputStream(reader)));
		}
	}
}
