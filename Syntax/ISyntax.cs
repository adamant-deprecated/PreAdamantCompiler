using System.Collections.Generic;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// A piece of syntax, possiblity including package and package references
	/// </summary>
	public interface ISyntax
	{
		IReadOnlyList<ISyntax> Children { get; }
	}
}