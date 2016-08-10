using PreAdamant.Compiler.Common;

namespace PreAdamant.Compiler.Core
{
	public struct TextLine
	{
		public readonly ISourceText Source;
		public readonly int Start;
		public readonly int Length;
		public int End => Start + Length;

		public TextLine(ISourceText source, int start, int length)
		{
			Requires.That(start >= 0, nameof(start), "Must be >= 0");
			// This handles overflow as well as negative length
			Requires.That(start + length >= start, nameof(length), "Length must be valid");
			Source = source;
			Start = start;
			Length = length;
		}

		public static TextLine FromTo(ISourceText source, int start, int end)
		{
			return new TextLine(source, start, end - start);
		}
	}
}
