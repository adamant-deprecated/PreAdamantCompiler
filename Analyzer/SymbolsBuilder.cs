using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Parser;
using static PreAdamant.Compiler.Parser.PreAdamantParser;

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

		public override void EnterClassDeclaration(ClassDeclarationContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, context.Name, context);
			symbols.Push(context.Symbol);
		}

		public override void ExitClassDeclaration(ClassDeclarationContext context)
		{
			symbols.Pop();
		}

		public override void EnterFunctionDeclaration(FunctionDeclarationContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, context.Name, context);
			symbols.Push(context.Symbol);
		}

		public override void ExitFunctionDeclaration(FunctionDeclarationContext context)
		{
			symbols.Pop();
		}

		public override void EnterNamespaceDeclaration(NamespaceDeclarationContext context)
		{
			var symbol = context.Names.Aggregate(CurrentSymbol, (current, name) => Symbol.For(current, name, context));
			context.Symbol = (Symbol<NamespaceDeclarationContext>)symbol;
			symbols.Push(context.Symbol);
		}

		public override void ExitNamespaceDeclaration(NamespaceDeclarationContext context)
		{
			symbols.Pop();
		}
	}
}
