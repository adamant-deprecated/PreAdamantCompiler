using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Core;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// A non-terminal node in the syntax tree
	/// </summary>
	public abstract class SyntaxNode : ISyntax
	{
		public bool IsPoisoned { get; private set; }
		public bool IsTrivia { get; }
		public TextSpan SourceSpan { get; }
		public IReadOnlyList<ISyntax> AllChildren { get; }
		public IReadOnlyList<ISyntax> Children { get; }

		protected SyntaxNode(IEnumerable<ISyntax> allChildren)
		{
			IsTrivia = false;
			AllChildren = allChildren.ToList();
			Children = AllChildren.Where(c => !c.IsTrivia).ToList();
			SourceSpan = new TextSpan(Children.First().SourceSpan.Start, Children.Last().SourceSpan.End);
		}

		protected SyntaxNode()
		{
			IsTrivia = false;
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
