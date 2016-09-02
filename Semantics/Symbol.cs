using System.Collections.Generic;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Semantics
{
	public abstract class Symbol
	{
		public readonly Symbol Parent;
		public readonly string Name;
		public readonly bool IsPredefined;
		//	private readonly List<Symbol> children = new List<Symbol>();
		//	public IReadOnlyList<Symbol> Children => children;
		//	private readonly List<Symbol> importedChildren = new List<Symbol>();
		//	public IReadOnlyList<Symbol> ImportedChildren => importedChildren;
		//	public IEnumerable<Symbol> AllChildren => children.Concat(importedChildren);

		//	protected Symbol(Symbol parent, string name, bool isPredefined)
		//	{
		//		Parent = parent;
		//		Name = name;
		//		IsPredefined = isPredefined;
		//	}

		//	public static Symbol<T> For<T>(Symbol parent, string name, T declaration, bool isPredefined = false)
		//		where T : ParserRuleContext
		//	{
		//		return For<T>(parent, name, new[] { declaration }, isPredefined);
		//	}

		//	public static Symbol<T> For<T>(Symbol parent, string name, IEnumerable<T> declarations, bool isPredefined = false)
		//		where T : ParserRuleContext
		//	{
		//		// In the case that we are adding a namespace, merge with any existing namespace
		//		if(typeof(T) == typeof(NamespaceDeclarationContext))
		//		{
		//			var existingSymbol = parent.Lookup(name) as Symbol<T>;
		//			if(existingSymbol != null)
		//			{
		//				foreach(var declaration in declarations)
		//					existingSymbol.AddDeclaration(declaration);
		//				return existingSymbol;
		//			}
		//		}

		//		var symbol = new Symbol<T>(parent, name, declarations, isPredefined);
		//		parent?.children.Add(symbol);
		//		return symbol;
		//	}

		//	public abstract void Import(Symbol child);

		//	protected void AddImportedChild(Symbol child)
		//	{
		//		importedChildren.Add(child);
		//	}

		public string FullyQualifiedName
		{
			get
			{
				if(Parent == null) return Name;
				if(Parent is Symbol<PackageSyntax>) return Parent.FullyQualifiedName + "::" + Name;

				return Parent.FullyQualifiedName + "." + Name;
			}
		}

		//	public Symbol Lookup(string name)
		//	{
		//		return AllChildren.SingleOrDefault(sym => sym.Name == name);
		//	}
	}

	public class Symbol<T> : Symbol
	{
		private readonly List<T> declarations;
		public IReadOnlyList<T> Declarations => declarations;

		//	public Symbol(Symbol parent, string name, T declaration, bool isPredefined)
		//		: base(parent, name, isPredefined)
		//	{
		//		declarations = new List<T>() { declaration };
		//	}

		//	public Symbol(Symbol parent, string name, IEnumerable<T> declarations, bool isPredefined)
		//		: base(parent, name, isPredefined)
		//	{
		//		this.declarations = declarations.ToList();
		//	}
		//	public void AddDeclaration(T declaration)
		//	{
		//		declarations.Add(declaration);
		//	}

		//	public override void Import(Symbol child)
		//	{
		//		if(typeof(T) != typeof(NamespaceDeclarationContext)
		//			&& typeof(T) != typeof(PackageContext))
		//			throw new NotSupportedException("Only package and namespace symbols can be imported into");

		//		var importedNamespace = child as Symbol<NamespaceDeclarationContext>;
		//		if(importedNamespace != null)
		//		{
		//			var existingSymbol = Lookup(importedNamespace.Name) as Symbol<NamespaceDeclarationContext>;
		//			if(existingSymbol == null)
		//			{
		//				existingSymbol = new Symbol<NamespaceDeclarationContext>(this, importedNamespace.Name, importedNamespace.Declarations, false);
		//				AddImportedChild(existingSymbol);
		//			}
		//			else
		//				foreach(var declaration in importedNamespace.Declarations)
		//					existingSymbol.AddDeclaration(declaration);

		//			foreach(var nsChild in importedNamespace.Children)
		//				existingSymbol.Import(nsChild);
		//		}
		//		else
		//			AddImportedChild(child);
		//	}
	}
}
