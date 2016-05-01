using System;

namespace PreAdamant.Compiler.Core
{
	public interface ISourceText : IComparable<ISourceText>
	{
		string Name { get; }
	}
}
