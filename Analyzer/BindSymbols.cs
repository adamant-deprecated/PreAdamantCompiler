using System;
using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler.Analyzer
{
	/// <summary>
	/// This pass binds names to symbols
	/// </summary>
	public class BindSymbols : ContextListener
	{
		private readonly Stack<SymbolBinder> binders = new Stack<SymbolBinder>();
		private SymbolBinder CurrentBinder => binders.Count > 0 ? binders.Peek() : null;

		#region Name Scopes
		public override void EnterPackage(PackageContext context)
		{
			var dependencyBinder = new SymbolBinder(null, context.Dependencies.SelectMany(r => r.Package.Symbol.Children), $"package dependencies: {context.Name}");
			var packageBinder = new SymbolBinder(dependencyBinder, context.Symbol.Children, $"package: {context.Name}");
			binders.Push(packageBinder);
		}

		public override void ExitPackage(PackageContext context)
		{
			binders.Pop();
		}

		public override void EnterCompilationUnit(PreAdamantParser.CompilationUnitContext context)
		{
			var container = CurrentBinder;
			var binder = new SymbolBinder(container, context.usingDirective().SelectMany(@using => ResolveDirective(@using, container).Children), $"file: {context.SourceText.Name}");
			binders.Push(binder);
		}

		public override void ExitCompilationUnit(PreAdamantParser.CompilationUnitContext context)
		{
			binders.Pop();
		}

		public override void EnterNamespaceDeclaration(PreAdamantParser.NamespaceDeclarationContext context)
		{
			// First search the current namespace, then the imported namespaces, then the containing namespaces, then the context
			var parentBinders = NamespaceBinder(context.Names.Count() - 1, context.Symbol.Parent, CurrentBinder);
			var usingsBinder = new SymbolBinder(parentBinders, context.usingDirective().SelectMany(@using => ResolveDirective(@using, CurrentBinder).Children), $"using statements for namespace: {context.Symbol.FullyQualifiedName}");
			var namespaceBinder = new SymbolBinder(usingsBinder, context.Symbol.Children, $"namespace: {context.Symbol.FullyQualifiedName}");
			binders.Push(namespaceBinder);
		}

		private static SymbolBinder NamespaceBinder(int depth, Symbol ns, SymbolBinder container)
		{
			if(depth == 0) return container;
			if(depth > 1) container = NamespaceBinder(depth - 1, ns.Parent, container);

			return new SymbolBinder(container, ns.Children, $"namespace: {ns.FullyQualifiedName}");
		}

		public override void ExitNamespaceDeclaration(PreAdamantParser.NamespaceDeclarationContext context)
		{
			binders.Pop();
		}

		public override void EnterFunctionDeclaration(PreAdamantParser.FunctionDeclarationContext context)
		{
			var binder = new SymbolBinder(CurrentBinder, context.Parameters.Select(p => p.Symbol), $"function: {context.Symbol.FullyQualifiedName}");
			binders.Push(binder);
		}

		public override void ExitFunctionDeclaration(PreAdamantParser.FunctionDeclarationContext context)
		{
			binders.Pop();
		}

		#endregion

		private Symbol ResolveDirective(PreAdamantParser.UsingDirectiveContext @using, SymbolBinder container)
		{
			throw new NotImplementedException();
		}
	}
}
