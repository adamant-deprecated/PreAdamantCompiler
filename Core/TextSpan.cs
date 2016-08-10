using System;
using PreAdamant.Compiler.Common;

namespace PreAdamant.Compiler.Core
{
	public struct TextSpan : IComparable<TextSpan>
	{
		public readonly int Start;
		public readonly int Length;
		public int End => Start + Length;

		public TextSpan(int start, int length)
		{
			Requires.That(start >= 0, nameof(start), "Must be >= 0");
			// This handles overflow as well as negative length
			Requires.That(start + length >= start, nameof(length), "Length must be valid");
			Start = start;
			Length = length;
		}

		public static TextSpan FromTo(int start, int end)
		{
			return new TextSpan(start, end - start);
		}

		public int CompareTo(TextSpan other)
		{
			var result = Start.CompareTo(other.Start);
			if(result != 0) return result;
			return Length.CompareTo(other.Length);
		}
	}
}
