using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Core.Diagnostics;

namespace PreAdamant.Compiler.Syntax
{
	public abstract class SyntaxTree
	{
		public SyntaxNode Root { get; }
		public IReadOnlyList<Diagnostic> Diagnostics { get; }

		protected SyntaxTree(SyntaxNode root, IEnumerable<Diagnostic> diagnostics)
		{
			Root = root;
			Diagnostics = diagnostics.OrderBy(x => x).ToList();
		}
	}

	public class SyntaxTree<T> : SyntaxTree
		where T : SyntaxNode
	{
		public new T Root { get; }

		public SyntaxTree(T root, IEnumerable<Diagnostic> diagnostics)
			: base(root, diagnostics)
		{
			Root = root;
		}
	}
}
