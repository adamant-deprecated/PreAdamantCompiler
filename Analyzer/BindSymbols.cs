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
	//public class BindSymbols : ContextListener
	//{
	//	private readonly Stack<SymbolBinder> binders = new Stack<SymbolBinder>();
	//	private SymbolBinder globalNamespaceBinder;
	//	private SymbolBinder CurrentBinder => binders.Count > 0 ? binders.Peek() : null;

	//	#region Name Scopes
	//	public override void EnterPackage(PackageContext context)
	//	{
	//		globalNamespaceBinder = new SymbolBinder(null, context.Symbol.AllChildren, $"package: {context.Name}");
	//		binders.Push(globalNamespaceBinder);
	//	}

	//	public override void ExitPackage(PackageContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterCompilationUnit(CompilationUnitContext context)
	//	{
	//		var container = CurrentBinder;
	//		var binder = new SymbolBinder(container, context.usingDirective().SelectMany(@using => ResolveDirective(@using).AllChildren), $"file: {context.SourceText.Name}");
	//		binders.Push(binder);
	//	}

	//	public override void ExitCompilationUnit(CompilationUnitContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterNamespaceDeclaration(NamespaceDeclarationContext context)
	//	{
	//		// First search the current namespace, then the imported namespaces, then the containing namespaces, then the context
	//		var parentBinders = NamespaceBinder(context.Names.Count() - 1, context.Symbol.Parent, CurrentBinder);
	//		var usingsBinder = new SymbolBinder(parentBinders, context.usingDirective().SelectMany(@using => ResolveDirective(@using).AllChildren), $"using statements for namespace: {context.Symbol.FullyQualifiedName}");
	//		var namespaceBinder = new SymbolBinder(usingsBinder, context.Symbol.AllChildren, $"namespace: {context.Symbol.FullyQualifiedName}");
	//		binders.Push(namespaceBinder);
	//	}

	//	private static SymbolBinder NamespaceBinder(int depth, Symbol ns, SymbolBinder container)
	//	{
	//		if(depth == 0) return container;
	//		if(depth > 1) container = NamespaceBinder(depth - 1, ns.Parent, container);

	//		return new SymbolBinder(container, ns.AllChildren, $"namespace: {ns.FullyQualifiedName}");
	//	}

	//	public override void ExitNamespaceDeclaration(NamespaceDeclarationContext context)
	//	{
	//		binders.Pop();
	//	}

	//	private void EnterFunction<T>(T context, string type)
	//		where T : ParserRuleContext, IFunctionContext<T>
	//	{
	//		var parameters = context.Parameters.Select(p => p.Symbol);
	//		var locals = context.methodBody()
	//						.Statements.OfType<VariableDeclarationStatementContext>()
	//						.Select(s => s.localVariableDeclaration().Symbol);
	//		var binder = new SymbolBinder(CurrentBinder, parameters.Concat(locals), $"{type}: {context.Symbol.FullyQualifiedName}");
	//		binders.Push(binder);
	//	}

	//	public override void EnterFunctionDeclaration(FunctionDeclarationContext context)
	//	{
	//		EnterFunction(context, "function");
	//	}

	//	public override void ExitFunctionDeclaration(FunctionDeclarationContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterClassDeclaration(ClassDeclarationContext context)
	//	{
	//		var binder = new SymbolBinder(CurrentBinder, context.Symbol.Children, $"class: {context.Symbol.FullyQualifiedName}");
	//		binders.Push(binder);
	//	}

	//	public override void ExitClassDeclaration(ClassDeclarationContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterStructDeclaration(StructDeclarationContext context)
	//	{
	//		var binder = new SymbolBinder(CurrentBinder, context.Symbol.Children, $"struct: {context.Symbol.FullyQualifiedName}");
	//		binders.Push(binder);
	//	}

	//	public override void ExitStructDeclaration(StructDeclarationContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterMethod(MethodContext context)
	//	{
	//		EnterFunction(context, "method");
	//	}

	//	public override void ExitMethod(MethodContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterConstructor(ConstructorContext context)
	//	{
	//		EnterFunction(context, "constructor");
	//	}

	//	public override void ExitConstructor(ConstructorContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterCopyConstructor(CopyConstructorContext context)
	//	{
	//		EnterFunction(context, "copy-constructor");
	//	}

	//	public override void ExitCopyConstructor(CopyConstructorContext context)
	//	{
	//		binders.Pop();
	//	}

	//	public override void EnterOperatorOverload(OperatorOverloadContext context)
	//	{
	//		EnterFunction(context, "operator-overload");
	//	}

	//	public override void ExitOperatorOverload(OperatorOverloadContext context)
	//	{
	//		binders.Pop();
	//	}
	//	#endregion

	//	private Symbol ResolveDirective(UsingDirectiveContext @using)
	//	{
	//		Symbol symbol = null;
	//		foreach(var identifier in @using.namespaceName().identifier())
	//		{
	//			var name = identifier.Name;
	//			symbol = symbol == null ? globalNamespaceBinder.LookupName(name) : symbol.Lookup(name);
	//			if(symbol == null)
	//				throw new Exception($"Could not resolve using statement `using {@using.namespaceName().GetText()}`");
	//		}

	//		return symbol;
	//	}

	//	public override void EnterNameExpression(NameExpressionContext context)
	//	{
	//		var variableName = context.simpleName().GetText();
	//		context.ReferencedSymbol = CurrentBinder.LookupName(variableName);
	//	}

	//	public override void EnterIdentifierName(IdentifierNameContext context)
	//	{
	//		var identifier = context.identifierOrPredefinedType().identifier();
	//		if(identifier != null) context.ReferencedSymbol = CurrentBinder.LookupName(identifier.GetText());
	//		else
	//		{
	//			var name = context.identifierOrPredefinedType().token.Text;
	//			Symbol symbol;
	//			if(!PredefinedTypes.Keyword.TryGetValue(name, out symbol))
	//				throw new NotImplementedException($"Predefined type `{name}` not implemented");

	//			context.ReferencedSymbol = symbol;
	//		}
	//	}

	//	public override void ExitUnqualifiedName(UnqualifiedNameContext context)
	//	{
	//		context.ReferencedSymbol = context.simpleName().ReferencedSymbol;
	//	}

	//	public override void ExitQualifiedName(QualifiedNameContext context)
	//	{
	//		// TODO lookup the name
	//		throw new NotImplementedException();
	//	}

	//	public override void ExitNamedType(NamedTypeContext context)
	//	{
	//		context.ReferencedSymbol = context.name().ReferencedSymbol;
	//	}
	//}
}
