using System;
using System.Collections.Generic;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Semantics
{
	public abstract class NameBinder
	{
		protected RuleBuilder<T> For<T>()
			where T : SyntaxNode
		{
			throw new System.NotImplementedException();
		}

		protected Namespace CreateNamespace(string name)
		{
			throw new System.NotImplementedException();
		}

		protected class RuleBuilder<T>
			where T : SyntaxNode
		{
			public RuleBuilder<T> Define(Func<T, Symbol<T>> action, bool unique)
			{
				throw new NotImplementedException();
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
			//public Symbol Of(string name, IEnumerable<ParameterType> parameterTypes)
			//{
			//	throw new NotImplementedException();
			//}
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