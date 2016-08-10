namespace PreAdamant.Compiler.Core
{
	public interface ITextLines
	{
		int Count { get; }
		TextLine this[int index] { get; }
		int LineNumber(int offset);
	}
}