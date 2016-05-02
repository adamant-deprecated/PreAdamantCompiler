
using System.Collections.Generic;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler.Analyzer
{
	public class SymbolsBuilder : ContextListener
	{
		private readonly Stack<Symbol> symbols = new Stack<Symbol>();
		private Symbol CurrentSymbol => symbols.Count > 0 ? symbols.Peek() : null;

		public override void EnterPackage(PackageContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, context.Name, context);
			symbols.Push(context.Symbol);
		}

		public override void ExitPackage(PackageContext context)
		{
			symbols.Pop();
		}
	}
}
