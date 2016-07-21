namespace PreAdamant.Compiler.Syntax
{
	public abstract class SyntaxTree
	{
		public SyntaxNode Root { get; }

		protected SyntaxTree(SyntaxNode root)
		{
			Root = root;
		}
	}

	public class SyntaxTree<T> : SyntaxTree
		where T : SyntaxNode
	{
		public new T Root { get; }

		public SyntaxTree(T root)
			: base(root)
		{
			Root = root;
		}
	}
}
