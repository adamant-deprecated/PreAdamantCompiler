using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Semantics
{
	public class SymbolBuilder
	{
		public readonly SymbolBuilder Parent;
		public readonly string Name;
		public readonly bool IsPredefined;
		private readonly List<ISyntax> declarations = new List<ISyntax>();
		public IReadOnlyList<ISyntax> Declarations => declarations;
		private readonly List<SymbolBuilder> children = new List<SymbolBuilder>();
		public IReadOnlyList<SymbolBuilder> Children => children;

		public SymbolBuilder(SymbolBuilder parent, string name, bool isPredefined)
		{
			Parent = parent;
			Name = name;
			IsPredefined = isPredefined;
		}

		public void AddDeclaration(ISyntax syntax)
		{
			declarations.Add(syntax);
		}

		public void AddChild(SymbolBuilder child)
		{
			Requires.That(child.Parent == this, nameof(child), "Must be a child of this symbol");
			children.Add(child);
		}

		public Symbol Build()
		{
			Requires.That(Parent == null, nameof(Parent), "Must be called on the root symbol");

			return Build(null);
		}

		private Symbol Build(Symbol parent)
		{
			var symbolChildren = new List<Symbol>(children.Count);
			var symbol = new Symbol(parent, Name, IsPredefined, Declarations, symbolChildren);
			symbolChildren.AddRange(children.Select(child => child.Build(symbol)));
			return symbol;
		}
	}
}
