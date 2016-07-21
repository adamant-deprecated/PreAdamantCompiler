using System.Collections.Generic;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// Some piece of syntax in a syntax tree, either a node or token.
	/// </summary>
	public interface ISyntax
	{
		IReadOnlyList<ISyntax> Children { get; }
	}
}