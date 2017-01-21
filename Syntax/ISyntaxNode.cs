using System.Collections.Generic;
using PreAdamant.Compiler.Core;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// Some piece of syntax in a syntax tree, either a node or token.
	/// </summary>
	public interface ISyntaxNode : ISyntax
	{
		bool IsPoisoned { get; }
		void Poison();
		bool IsTrivia { get; }
		TextSpan SourceSpan { get; }
		new IReadOnlyList<ISyntaxNode> Children { get; }
	}
}