using System.Collections.Generic;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler.Analyzer
{
	/// <summary>
	/// This pass builds the tree of symbols
	/// </summary>
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

		public override void EnterClassDeclaration(PreAdamantParser.ClassDeclarationContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, context.Name, context);
			symbols.Push(context.Symbol);
		}

		public override void ExitClassDeclaration(PreAdamantParser.ClassDeclarationContext context)
		{
			symbols.Pop();
		}

		public override void EnterFunctionDeclaration(PreAdamantParser.FunctionDeclarationContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, context.Name, context);
			symbols.Push(context.Symbol);
		}

		public override void ExitFunctionDeclaration(PreAdamantParser.FunctionDeclarationContext context)
		{
			symbols.Pop();
		}
	}
}
