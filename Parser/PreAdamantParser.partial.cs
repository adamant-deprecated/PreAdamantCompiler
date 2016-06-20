using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Lexer;

namespace PreAdamant.Compiler.Parser
{
	public partial class PreAdamantParser
	{
		public PreAdamantParser(PreAdamantLexer lexer)
			: this(new CommonTokenStream(lexer))
		{
		}

		public PreAdamantParser(string fileName)
			: this(new PreAdamantLexer(fileName))
		{
		}

		public partial class CompilationUnitContext
		{
			public ISourceText SourceText { get; set; }
		}

		public partial class ClassDeclarationContext
		{
			public Symbol<ClassDeclarationContext> Symbol { get; set; }
			public string Name => identifier().Name;
		}

		public partial class FunctionDeclarationContext : IFunctionContext<FunctionDeclarationContext>
		{
			public Symbol<FunctionDeclarationContext> Symbol { get; set; }
			public string Name => identifier().Name;
			public bool HasBody => methodBody().Exists;
			public IEnumerable<ParameterContext> Parameters => parameterList().parameter();
		}

		public partial class NamespaceDeclarationContext
		{
			public Symbol<NamespaceDeclarationContext> Symbol { get; set; }
			public IEnumerable<string> Names => namespaceName().identifier().Select(i => i.GetText());
		}

		public partial class IdentifierContext
		{
			private string name;

			// Remove the `
			public string Name => name ?? (name = token.Type == PreAdamantParser.EscapedIdentifier ? token.Text.Substring(1) : token.Text);
		}

		public partial class IdentifierNameContext
		{
			public Symbol ReferencedSymbol { get; set; }
		}

		public partial class ReferenceTypeContext
		{
			public virtual ValueTypeContext ValueType { get { throw new NotSupportedException(); } }
			public virtual LifetimeContext Lifetime { get { throw new NotSupportedException(); } }
			public virtual bool IsOwned { get { throw new NotSupportedException(); } }
			public virtual bool IsMutable { get { throw new NotSupportedException(); } }
		}

		public partial class ImmutableReferenceTypeContext
		{
			public override ValueTypeContext ValueType => valueType();
			public override LifetimeContext Lifetime => lifetime();
			public override bool IsOwned => false;
			public override bool IsMutable => false;
		}

		public partial class MutableReferenceTypeContext
		{
			public override ValueTypeContext ValueType => valueType();
			public override LifetimeContext Lifetime => lifetime();
			public override bool IsOwned => false;
			public override bool IsMutable => true;
		}

		public partial class OwnedImmutableReferenceTypeContext
		{
			public override ValueTypeContext ValueType => valueType();
			public override LifetimeContext Lifetime => null;
			public override bool IsOwned => true;
			public override bool IsMutable => false;
		}

		public partial class OwnedMutableReferenceTypeContext
		{
			public override ValueTypeContext ValueType => valueType();
			public override LifetimeContext Lifetime => null;
			public override bool IsOwned => true;
			public override bool IsMutable => true;
		}

		public partial class MethodBodyContext
		{
			public virtual bool Exists { get { throw new NotSupportedException(); } }
			public virtual IEnumerable<StatementContext> Statements { get { throw new NotSupportedException(); } }
		}

		public partial class NoMethodBodyContext
		{
			public override bool Exists => false;
			public override IEnumerable<StatementContext> Statements => Enumerable.Empty<StatementContext>();
		}

		public partial class BlockMethodBodyContext
		{
			public override bool Exists => true;
			public override IEnumerable<StatementContext> Statements => _statements;
		}

		public partial class IntLiteralExpressionContext
		{
			private BigInteger? value;
			public BigInteger Value
			{
				get
				{
					if(value == null) value = BigInteger.Parse(IntLiteral().GetText());
					return value.Value;
				}
			}
		}

		public partial class StringLiteralExpressionContext
		{
			private string value;

			public string Value
			{
				get
				{
					if(value == null)
					{
						var text = StringLiteral().GetText();
						value = text.Substring(0, text.Length - 2);
					}
					return value;
				}
			}
		}

		public partial class ParameterContext
		{
			public Symbol Symbol { get; set; }
		}

		public partial class NamedParameterContext
		{
			public string Name => identifier().Name;
		}

		public partial class SelfParameterContext
		{
			public bool IsMutable => isMut != null;
		}

		public partial class NameExpressionContext
		{
			public Symbol ReferencedSymbol { get; set; }
		}

		public partial class MethodContext : IFunctionContext<MethodContext>
		{
			public Symbol<MethodContext> Symbol { get; set; }
			public string Name => identifier().Name;
			public bool HasBody => methodBody().Exists;
			public IEnumerable<ParameterContext> Parameters => parameterList().parameter();
		}

		public partial class LocalVariableDeclarationContext
		{
			public Symbol<LocalVariableDeclarationContext> Symbol { get; set; }
			public string Name => identifier().Name;
			public bool IsMutable => kind.Type == Var;
		}
	}
}
