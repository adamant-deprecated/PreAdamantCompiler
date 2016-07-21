using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	public partial class PreAdamantLexer
	{
		private const int StartMode = PreAdamantLexer_Antlr.Code;
		public enum Channel
		{
			Main = 0,
			Trivia,
		}
	}
}
