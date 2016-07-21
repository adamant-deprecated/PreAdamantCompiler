using PreAdamant.Compiler.Core;

namespace PreAdamant.Compiler.Syntax
{
	public class KeywordToken : SyntaxToken
	{
		protected KeywordToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}
}
