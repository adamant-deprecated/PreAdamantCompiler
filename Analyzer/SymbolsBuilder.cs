using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
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

		public override void EnterMethod(MethodContext context)
		{
			EnterFunctionContext(context);
		}

		public override void ExitMethod(MethodContext context)
		{
			symbols.Pop();
		}

		public override void EnterFunctionDeclaration(FunctionDeclarationContext context)
		{
			EnterFunctionContext(context);
		}

		private void EnterFunctionContext<T>(T context)
			where T : ParserRuleContext, IFunctionContext<T>
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

		public override void EnterNamedParameter(NamedParameterContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, context.Name, context);
		}

		public override void EnterSelfParameter(SelfParameterContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, "self", context);
		}

		public override void EnterLocalVariableDeclaration(LocalVariableDeclarationContext context)
		{
			context.Symbol = Symbol.For(CurrentSymbol, context.Name, context);
		}
	}
}
