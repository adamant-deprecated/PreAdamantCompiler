using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Lexer;
using PreAdamant.Compiler.Parser.Antlr;

namespace PreAdamant.Compiler.Parser
{
	public partial class PreAdamantParser
	{
		private readonly IEnumerable<SyntaxToken> tokens;

		public PreAdamantParser(IEnumerable<SyntaxToken> tokens)
		{
			this.tokens = tokens;
		}

		public PreAdamantParser(SourceText source)
			: this(new PreAdamantLexer(source))
		{
		}

		public void Parse()
		{
			var parser = new PreAdamantParser_Antlr(new CommonTokenStream(new TokenSourceAdapter(tokens)));
			var unit = parser.compilationUnit();
		}

		private class TokenSourceAdapter : ITokenSource
		{
			private readonly IEnumerator<SyntaxToken> tokens;

			public TokenSourceAdapter(IEnumerable<SyntaxToken> tokens)
			{
				this.tokens = tokens.GetEnumerator();
			}

			public IToken NextToken()
			{
				return tokens.MoveNext() ? new TokenAdapter(tokens.Current) : null;
			}

			public int Line
			{
				get { throw new System.NotSupportedException(); }
			}

			public int Column
			{
				get { throw new System.NotSupportedException(); }
			}

			public ICharStream InputStream
			{
				get { throw new System.NotSupportedException(); }
			}

			public string SourceName
			{
				get { throw new System.NotSupportedException(); }
			}

			public ITokenFactory TokenFactory
			{
				get { throw new System.NotSupportedException(); }
				set { throw new System.NotSupportedException(); }
			}
		}

		internal class TokenAdapter : IToken
		{
			private readonly SyntaxToken token;

			public TokenAdapter(SyntaxToken token)
			{
				this.token = token;
			}

			public string Text => token.Text;

			public int Type => token.TokenNumber;

			public int Line
			{
				get { throw new NotSupportedException(); }
			}

			public int Column
			{
				get { throw new NotSupportedException(); }
			}

			public int Channel => (int)token.Channel;

			public int TokenIndex
			{
				get { throw new NotSupportedException(); }
			}

			public int StartIndex => (int)token.Offset;

			public int StopIndex => (int)(token.Offset + token.Length);

			public ITokenSource TokenSource
			{
				get { throw new NotSupportedException(); }
			}

			public ICharStream InputStream
			{
				get { throw new NotSupportedException(); }
			}
		}

		//public partial class CompilationUnitContext
		//{
		//	public ISourceText SourceText { get; set; }
		//}

		//public partial class ClassDeclarationContext
		//{
		//	public Symbol<ClassDeclarationContext> Symbol { get; set; }
		//	public string Name => identifier().Name;
		//}

		//public partial class StructDeclarationContext
		//{
		//	public Symbol<StructDeclarationContext> Symbol { get; set; }
		//	public string Name => identifier().Name;
		//}

		//public partial class FunctionDeclarationContext : IFunctionContext<FunctionDeclarationContext>
		//{
		//	public Symbol<FunctionDeclarationContext> Symbol { get; set; }
		//	public string Name => identifier().Name;
		//	public bool HasBody => methodBody().Exists;
		//	public IEnumerable<ParameterContext> Parameters => parameterList().parameter();
		//}

		//public partial class NamespaceDeclarationContext
		//{
		//	public Symbol<NamespaceDeclarationContext> Symbol { get; set; }
		//	public IEnumerable<string> Names => namespaceName().identifier().Select(i => i.GetText());
		//}

		//public partial class IdentifierContext
		//{
		//	private string name;

		//	// Remove the `
		//	public string Name => name ?? (name = token.Type == PreAdamantParser.EscapedIdentifier ? token.Text.Substring(1) : token.Text);
		//}

		//public partial class IdentifierNameContext
		//{
		//}

		//public partial class TypeNameContext
		//{
		//	public virtual Symbol ReferencedSymbol { get; set; }
		//}

		//public partial class ValueTypeContext
		//{
		//	public virtual TypeNameContext TypeName { get { throw new NotSupportedException(); } }
		//	public virtual LifetimeContext Lifetime { get { throw new NotSupportedException(); } }
		//	public virtual bool IsOwned { get { throw new NotSupportedException(); } }
		//	public virtual bool IsMutable { get { throw new NotSupportedException(); } }
		//}

		//public partial class LifetimeTypeContext
		//{
		//	public override TypeNameContext TypeName => typeName();
		//	public override LifetimeContext Lifetime => lifetime();
		//	public override bool IsOwned => false;
		//	public override bool IsMutable => isMut != null;
		//}

		//public partial class RefTypeContext
		//{
		//	public override TypeNameContext TypeName => typeName();
		//	public override LifetimeContext Lifetime => null;
		//	public override bool IsOwned => false;
		//	public override bool IsMutable => isMut != null;
		//}

		//public partial class MethodBodyContext
		//{
		//	public virtual bool Exists { get { throw new NotSupportedException(); } }
		//	public virtual IEnumerable<StatementContext> Statements { get { throw new NotSupportedException(); } }
		//}

		//public partial class NoMethodBodyContext
		//{
		//	public override bool Exists => false;
		//	public override IEnumerable<StatementContext> Statements => Enumerable.Empty<StatementContext>();
		//}

		//public partial class BlockMethodBodyContext
		//{
		//	public override bool Exists => true;
		//	public override IEnumerable<StatementContext> Statements => _statements;
		//}

		//public partial class IntLiteralExpressionContext
		//{
		//	private BigInteger? value;
		//	public BigInteger Value
		//	{
		//		get
		//		{
		//			if(value == null) value = BigInteger.Parse(IntLiteral().GetText());
		//			return value.Value;
		//		}
		//	}
		//}

		//public partial class StringLiteralExpressionContext
		//{
		//	private string value;

		//	public string Value
		//	{
		//		get
		//		{
		//			if(value == null)
		//			{
		//				var text = StringLiteral().GetText();
		//				value = text.Substring(1, text.Length - 2);
		//			}
		//			return value;
		//		}
		//	}
		//}

		//public partial class ParameterContext
		//{
		//	public Symbol Symbol { get; set; }
		//}

		//public partial class NamedParameterContext
		//{
		//	public string Name => identifier().Name;
		//}

		//public partial class SelfParameterContext
		//{
		//	public bool IsMutable => isMut != null;
		//}

		//public partial class NameExpressionContext
		//{
		//	public Symbol ReferencedSymbol { get; set; }
		//}

		//public partial class MethodContext : IFunctionContext<MethodContext>
		//{
		//	public Symbol<MethodContext> Symbol { get; set; }
		//	public string Name => identifier().Name;
		//	public bool HasBody => methodBody().Exists;
		//	public IEnumerable<ParameterContext> Parameters => parameterList().parameter();
		//}

		//public partial class ConstructorContext : IFunctionContext<ConstructorContext>
		//{
		//	public Symbol<ConstructorContext> Symbol { get; set; }
		//	public string Name => identifier() == null ? "new" : $"__new_{identifier().Name}";
		//	public IEnumerable<ParameterContext> Parameters => parameterList().parameter();
		//}

		//public partial class CopyConstructorContext : IFunctionContext<CopyConstructorContext>
		//{
		//	public Symbol<CopyConstructorContext> Symbol { get; set; }
		//	public string Name => "__copy";
		//	public IEnumerable<ParameterContext> Parameters => parameterList().parameter();
		//}

		//public partial class OperatorOverloadContext : IFunctionContext<OperatorOverloadContext>
		//{
		//	public Symbol<OperatorOverloadContext> Symbol { get; set; }
		//	public string Name => $"__op_{overloadableOperator().GetText()}";
		//	public IEnumerable<ParameterContext> Parameters => parameterList().parameter();
		//}

		//public partial class LocalVariableDeclarationContext
		//{
		//	public Symbol<LocalVariableDeclarationContext> Symbol { get; set; }
		//	public string Name => identifier().Single().Name;
		//	public bool IsMutable => kind.Type == Var;
		//}

		//public partial class NameContext
		//{
		//	public Symbol ReferencedSymbol { get; set; }
		//}

		//public partial class SimpleNameContext
		//{
		//	public Symbol ReferencedSymbol { get; set; }
		//}

		//public partial class FieldContext
		//{
		//	public Symbol<FieldContext> Symbol { get; set; }
		//	public bool IsMutable => kind.Type == Var;
		//}

		//public partial class PointerTypeContext
		//{
		//	public bool IsMutable => isMut != null;
		//}
	}
}
