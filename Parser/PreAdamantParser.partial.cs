using Antlr4.Runtime;
using PreAdamant.Compiler.Lexer;

namespace PreAdamant.Compiler.Parser
{
	public partial class PreAdamantParser
	{
		public PreAdamantParser(PreAdamantLexer lexer)
			: this(new CommonTokenStream(lexer))
		{
		}

		public PreAdamantParser(string fileName)
			: this(new PreAdamantLexer(fileName))
		{
		}
	}
}
