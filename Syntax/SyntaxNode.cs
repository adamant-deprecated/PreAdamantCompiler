using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// A non-terminal node in the syntax tree
	/// </summary>
	public abstract class SyntaxNode : ISyntax
	{
		public bool IsPoisoned { get; private set; }
		public bool IsTrivia { get; }
		public IReadOnlyList<ISyntax> Children { get; }

		protected SyntaxNode(IEnumerable<ISyntax> children, bool isTrivia)
		{
			IsTrivia = isTrivia;
			Children = children.ToList();
		}

		protected SyntaxNode(bool isTrivia)
		{
			IsTrivia = isTrivia;
			Children = Syntax.NoChildren;
		}

		public void Poison()
		{
			if(IsPoisoned) return;
			foreach(var child in Children)
				child.Poison();

			IsPoisoned = true;
		}
	}
}
