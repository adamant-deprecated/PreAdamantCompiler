using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	internal partial class PreAdamantSyntaxTransformer
	{
		private static readonly IReadOnlyList<ISyntaxNode> NoChildren = new List<ISyntaxNode>();

		private readonly IReadOnlyList<IToken> tokens;
		private readonly PreAdamantTokenTransformer tokenTransformer;

		public PreAdamantSyntaxTransformer(IReadOnlyList<IToken> tokens, PreAdamantTokenTransformer tokenTransformer)
		{
			this.tokens = tokens;
			this.tokenTransformer = tokenTransformer;
		}

		internal CompilationUnitSyntax Transform(PreAdamantParser_Antlr.CompilationUnitContext compilationUnit)
		{
			return (CompilationUnitSyntax)compilationUnit.Accept(this);
		}

		private List<ISyntaxNode> InterleaveTriva(IReadOnlyList<ISyntaxNode> children)
		{
			var allChildren = new List<ISyntaxNode>(children);
			for(var i = allChildren.Count - 1; i > 0; i--)
			{
				var triviaTokens = GetTokensInSpan(allChildren[i - 1].SourceSpan.End, allChildren[i].SourceSpan.Start);
				allChildren.InsertRange(i, triviaTokens.Select(tokenTransformer.Transform));
			}
			return allChildren;
		}

		private IEnumerable<IToken> GetTokensInSpan(int start, int end)
		{
			if(start == end) yield break;
			foreach(var token in tokens)
			{
				if(token.StopIndex + 1 > end) // their stop index is in the value, ours is after the value, hence + 1
					yield break;

				if(token.StartIndex >= start)
					yield return token;
			}
		}

		ISyntaxNode IParseTreeVisitor<ISyntaxNode>.Visit(IParseTree tree)
		{
			throw new NotSupportedException();
		}

		ISyntaxNode IParseTreeVisitor<ISyntaxNode>.VisitChildren(IRuleNode node)
		{
			throw new NotSupportedException();
		}

		ISyntaxNode IParseTreeVisitor<ISyntaxNode>.VisitTerminal(ITerminalNode node)
		{
			return tokenTransformer.Transform(node.Symbol);
		}

		ISyntaxNode IParseTreeVisitor<ISyntaxNode>.VisitErrorNode(IErrorNode node)
		{
			throw new NotSupportedException();
		}
	}
}
