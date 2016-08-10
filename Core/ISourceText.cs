using System;

namespace PreAdamant.Compiler.Core
{
	public interface ISourceText : IComparable<ISourceText>
	{
		string Package { get; }
		string Name { get; }
		string Text { get; }
		int Length { get; }
		ITextLines Lines { get; }
		TextPosition PositionOfStart(TextSpan textSpan);
	}
}
