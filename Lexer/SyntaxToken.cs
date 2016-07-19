using System.Collections.Generic;
using PreAdamant.Compiler.Core;

namespace PreAdamant.Compiler.Lexer
{
	public class SyntaxToken : ISyntax
	{
		private static readonly IReadOnlyList<ISyntax> NoChildren = new List<ISyntax>();

		public int TokenNumber { get; } // Don't really like this on here, but it makes integrating with the parser a lot easier
		public SourceText Source { get; }
		public long Offset { get; }
		public int Length { get; }
		public PreAdamantLexer.Channel Channel { get; }
		public string Text { get; }
		public IReadOnlyList<ISyntax> Children => NoChildren;

		protected SyntaxToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
		{
			TokenNumber = type;
			Source = source;
			Offset = startIndex;
			Channel = channel;
			Text = text;
			Length = stopIndex - startIndex;
		}

		
	}
}
