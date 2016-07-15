using System;
using Antlr4.Runtime.Tree;

namespace PreAdamant.Compiler.Tools.Lex
{
	public abstract class SpecParserSafeBaseVisitor<T>: SpecParserBaseVisitor<T>
	{
		public override T VisitChildren(IRuleNode node)
		{
			throw new NotImplementedException();
		}

		public override T VisitTerminal(ITerminalNode node)
		{
			throw new NotImplementedException();
		}

		public override T VisitErrorNode(IErrorNode node)
		{
			throw new NotImplementedException();
		}
	}
}
