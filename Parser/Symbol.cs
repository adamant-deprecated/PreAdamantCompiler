using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using static PreAdamant.Compiler.Parser.PreAdamantParser;

namespace PreAdamant.Compiler.Parser
{
	public abstract class Symbol
	{
		public readonly Symbol Parent;
		public readonly string Name;
		private readonly List<Symbol> children = new List<Symbol>();
		public IReadOnlyList<Symbol> Children => children;

		protected Symbol(Symbol parent, string name)
		{
			Parent = parent;
			Name = name;
		}

		public static Symbol<T> For<T>(Symbol parent, string name, T declaration)
			where T : ParserRuleContext
		{
			var symbol = new Symbol<T>(parent, name, declaration);
			parent?.children.Add(symbol);
			return symbol;
		}

		public static Symbol<NamespaceDeclarationContext> For(Symbol parent, string name, NamespaceDeclarationContext declaration)
		{
			var existingSymbol = parent.Lookup(name) as Symbol<NamespaceDeclarationContext>;
			if(existingSymbol != null)
			{
				existingSymbol.AddDeclaration(declaration);
				return existingSymbol;
			}

			return For<NamespaceDeclarationContext>(parent, name, declaration);
		}

		public string FullyQualifiedName
		{
			get
			{
				if(Parent == null) return Name;
				if(Parent is Symbol<PackageContext>) return Parent.FullyQualifiedName + "::" + Name;

				return Parent.FullyQualifiedName + "." + Name;
			}
		}

		public Symbol Lookup(string name)
		{
			return Children.SingleOrDefault(sym => sym.Name == name);
		}
	}

	public class Symbol<T> : Symbol
		where T : ParserRuleContext
	{
		private readonly List<T> declarations;
		public IReadOnlyList<T> Declarations => declarations;

		public Symbol(Symbol parent, string name, T declaration)
			: base(parent, name)
		{
			declarations = new List<T>() { declaration };
		}

		public void AddDeclaration(T declaration)
		{
			declarations.Add(declaration);
		}
	}
}
