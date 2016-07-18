using PreAdamant.Compiler.Core;

namespace PreAdamant.Compiler.Lexer
{
	public class Token
	{
		public SourceText Source { get; }
		public long Offset { get; }
		public int Length { get; }
		public PreAdamantLexer.Channel Channel { get; }
		public string Text { get; }

		protected Token(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
		{
			Source = source;
			Offset = startIndex;
			Channel = channel;
			Text = text;
			Length = stopIndex - startIndex;
		}
	}
}
