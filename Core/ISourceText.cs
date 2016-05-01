using System;

namespace PreAdamant.Compiler.Core
{
	public interface ISourceText : IComparable<ISourceText>
	{
		string Package { get; }
		string Name { get; }
	}
}
