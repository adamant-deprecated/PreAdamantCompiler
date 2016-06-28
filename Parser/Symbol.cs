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
			return For<T>(parent, name, new[] { declaration });
		}

		public static Symbol<T> For<T>(Symbol parent, string name, IEnumerable<T> declarations)
			where T : ParserRuleContext
		{
			// In the case that we are adding a namespace, merge with any existing namespace
			if(typeof(T) == typeof(NamespaceDeclarationContext))
			{
				var existingSymbol = parent.Lookup(name) as Symbol<T>;
				if(existingSymbol != null)
				{
					foreach(var declaration in declarations)
						existingSymbol.AddDeclaration(declaration);
					return existingSymbol;
				}
			}

			var symbol = new Symbol<T>(parent, name, declarations);
			parent?.children.Add(symbol);
			return symbol;
		}

		public abstract Symbol ImportInto(Symbol parent);

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

		public Symbol(Symbol parent, string name, IEnumerable<T> declarations)
			: base(parent, name)
		{
			this.declarations = declarations.ToList();
		}
		public void AddDeclaration(T declaration)
		{
			declarations.Add(declaration);
		}

		public override Symbol ImportInto(Symbol parent)
		{
			var symbol = For<T>(parent, Name, Declarations);
			foreach(var child in Children)
				child.ImportInto(symbol);

			return symbol;
		}
	}
}
