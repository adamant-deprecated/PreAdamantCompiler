using System;
using System.Collections.Generic;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Semantics
{
	public abstract class NameBinder
	{
		private readonly IList<Namespace> namespaces = new List<Namespace>();
		private readonly Dictionary<Type, Func<ISyntax, SymbolBuilder>> definitionActions = new Dictionary<Type, Func<ISyntax, SymbolBuilder>>();

		public Symbol BuildSymbols(PackageSyntax syntax)
		{
			return BuildSymbols(syntax, null);
		}

		private Symbol BuildSymbols(ISyntax syntax, SymbolBuilder parentSymbol)
		{
			var syntaxType = syntax.GetType();
			Func<ISyntax, SymbolBuilder> buildDefinition;
			SymbolBuilder symbol = null;
			if(definitionActions.TryGetValue(syntaxType, out buildDefinition))
				symbol = buildDefinition(syntax);

			foreach(var child in syntax.Children)
			{
			}

			return symbol.Build();
		}

		protected RuleBuilder<T> For<T>()
			where T : ISyntax
		{
			return new RuleBuilder<T>(this);
		}

		protected Namespace CreateNamespace(string name)
		{
			var ns = new Namespace(name);
			namespaces.Add(ns);
			return ns;
		}

		protected class RuleBuilder<T>
			where T : ISyntax
		{
			private readonly NameBinder nameBinder;

			public RuleBuilder(NameBinder nameBinder)
			{
				this.nameBinder = nameBinder;
			}

			public RuleBuilder<T> Define(Func<T, SymbolBuilder> action, bool unique)
			{
				nameBinder.definitionActions.Add(typeof(T), s=> action((T)s));
				return this;
			}

			public RuleBuilder<T> Scope(params Namespace[] namespaces)
			{
				throw new NotImplementedException();
			}

			public RuleBuilder<T> Import(Func<T, IEnumerable<Symbol>> action)
			{
				throw new NotImplementedException();
			}
		}

		protected class Namespace
		{
			private readonly string name;

			public Namespace(string name)
			{
				this.name = name;
			}

			public SymbolBuilder Of(string name, IEnumerable<object> parameterTypes)
			{
				throw new NotImplementedException();
			}

			public SymbolBuilder Of(string name)
			{
				throw new NotImplementedException();
			}
		}

		protected object TypeOf(IEnumerable<Symbol> symbols)
		{
			throw new System.NotImplementedException();
		}

		protected IEnumerable<Symbol> ResolveReference(Symbol context, Namespace ns)
		{
			throw new System.NotImplementedException();
		}

		protected Symbol ResolveReference(SyntaxNode context, Namespace ns, string name)
		{
			throw new System.NotImplementedException();
		}
	}
}