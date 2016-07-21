using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// A non-terminal node in the syntax tree
	/// </summary>
	public abstract class SyntaxNode : ISyntax
	{
		public IReadOnlyList<ISyntax> Children { get; }

		protected SyntaxNode(IEnumerable<ISyntax> children)
		{
			Children = children.ToList();
		}

		protected SyntaxNode()
		{
			Children = PreAdamant.Compiler.Syntax.Syntax.NoChildren;
		}
	}
}
