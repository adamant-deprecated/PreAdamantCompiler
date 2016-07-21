using System.Collections.Generic;
using PreAdamant.Compiler.Core;

namespace PreAdamant.Compiler.Syntax
{
	public class SyntaxToken : ISyntax
	{
		public ISourceText Source { get; }
		public long Offset { get; }
		public int Length { get; }
		public PreAdamantLexer.Channel Channel { get; }
		public string Text { get; }
		public IReadOnlyList<ISyntax> Children => Syntax.NoChildren;

		protected SyntaxToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
		{
			Source = source;
			Offset = startIndex;
			Channel = channel;
			Text = text;
			Length = stopIndex - startIndex;
		}
	}
}
