using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using PreAdamant.Compiler.Parser;
using static PreAdamant.Compiler.Parser.PreAdamantParser;

namespace PreAdamant.Compiler.Analyzer
{
	/// <summary>
	/// This pass binds names to symbols
	/// </summary>
	public class BindSymbols : ContextListener
	{
		private readonly Stack<SymbolBinder> binders = new Stack<SymbolBinder>();
		private SymbolBinder globalNamespaceBinder;
		private SymbolBinder CurrentBinder => binders.Count > 0 ? binders.Peek() : null;

		#region Name Scopes
		public override void EnterPackage(PackageContext context)
		{
			globalNamespaceBinder = new SymbolBinder(null, context.Symbol.Children, $"package: {context.Name}");
			binders.Push(globalNamespaceBinder);
		}

		public override void ExitPackage(PackageContext context)
		{
			binders.Pop();
		}

		public override void EnterCompilationUnit(CompilationUnitContext context)
		{
			var container = CurrentBinder;
			var binder = new SymbolBinder(container, context.usingDirective().SelectMany(@using => ResolveDirective(@using).Children), $"file: {context.SourceText.Name}");
			binders.Push(binder);
		}

		public override void ExitCompilationUnit(CompilationUnitContext context)
		{
			binders.Pop();
		}

		public override void EnterNamespaceDeclaration(NamespaceDeclarationContext context)
		{
			// First search the current namespace, then the imported namespaces, then the containing namespaces, then the context
			var parentBinders = NamespaceBinder(context.Names.Count() - 1, context.Symbol.Parent, CurrentBinder);
			var usingsBinder = new SymbolBinder(parentBinders, context.usingDirective().SelectMany(@using => ResolveDirective(@using).Children), $"using statements for namespace: {context.Symbol.FullyQualifiedName}");
			var namespaceBinder = new SymbolBinder(usingsBinder, context.Symbol.Children, $"namespace: {context.Symbol.FullyQualifiedName}");
			binders.Push(namespaceBinder);
		}

		private static SymbolBinder NamespaceBinder(int depth, Symbol ns, SymbolBinder container)
		{
			if(depth == 0) return container;
			if(depth > 1) container = NamespaceBinder(depth - 1, ns.Parent, container);

			return new SymbolBinder(container, ns.Children, $"namespace: {ns.FullyQualifiedName}");
		}

		public override void ExitNamespaceDeclaration(NamespaceDeclarationContext context)
		{
			binders.Pop();
		}

		public override void EnterFunctionDeclaration(FunctionDeclarationContext context)
		{
			EnterFunction(context, "function");
		}

		private void EnterFunction<T>(T context, string type)
			where T : ParserRuleContext, IFunctionContext<T>
		{
			var parameters = context.Parameters.Select(p => p.Symbol);
			var locals = context.methodBody()
							.Statements.OfType<VariableDeclarationStatementContext>()
							.Select(s => s.localVariableDeclaration().Symbol);
			var binder = new SymbolBinder(CurrentBinder, parameters.Concat(locals), $"{type}: {context.Symbol.FullyQualifiedName}");
			binders.Push(binder);
		}

		public override void ExitFunctionDeclaration(FunctionDeclarationContext context)
		{
			binders.Pop();
		}

		public override void EnterMethod(MethodContext context)
		{
			EnterFunction(context, "method");
		}

		public override void ExitMethod(MethodContext context)
		{
			binders.Pop();
		}

		#endregion

		private Symbol ResolveDirective(UsingDirectiveContext @using)
		{
			Symbol symbol = null;
			foreach(var identifier in @using.namespaceName().identifier())
			{
				var name = identifier.Name;
				symbol = symbol == null ? globalNamespaceBinder.LookupName(name) : symbol.Lookup(name);
				if(symbol == null)
					throw new Exception($"Could not resolve using statement `using {@using.namespaceName().GetText()}`");
            }

			return symbol;
		}

		public override void EnterNameExpression(NameExpressionContext context)
		{
			var variableName = context.simpleName().GetText();
			context.ReferencedSymbol = CurrentBinder.LookupName(variableName);
		}

		public override void EnterIdentifierName(IdentifierNameContext context)
		{
			var name = context.identifierOrPredefinedType().GetText();
			context.ReferencedSymbol = CurrentBinder.LookupName(name);
		}
	}
}
