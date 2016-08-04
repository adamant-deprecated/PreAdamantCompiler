using System;
using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	internal partial class PreAdamantTokenTransformer
	{
		private readonly ISourceText source;

		public PreAdamantTokenTransformer(ISourceText source)
		{
			this.source = source;
		}

		internal SyntaxToken Transform(IToken token)
		{
			var type = token.Type;
			var startIndex = token.StartIndex;
			var stopIndex = token.StopIndex + 1; // their stop index is in the value, ours is past the value
			var channel = (PreAdamantLexer.Channel)token.Channel;
			var text = token.Text;
			switch(type)
			{
				case PreAdamantLexer_Antlr.Eof:
					return new EndOfFileToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Whitespace:
					return new WhitespaceToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Newline:
					return new NewlineToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.PreprocessorLine:
					return new PreprocessorLineToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.DocComment:
					return new DocCommentToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.LineComment:
					return new LineCommentToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.BlockComment:
					return new BlockCommentToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Using:
					return new UsingToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Namespace:
					return new NamespaceToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Class:
					return new ClassToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Struct:
					return new StructToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Enum:
					return new EnumToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.New:
					return new NewToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.NewPanic:
					return new NewPanicToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.NewResult:
					return new NewResultToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.NewPointer:
					return new NewPointerToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.NewPointerPanic:
					return new NewPointerPanicToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.NewNullablePointer:
					return new NewNullablePointerToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Delete:
					return new DeleteToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Self:
					return new SelfToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Uninitialized:
					return new UninitializedToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Where:
					return new WhereToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Base:
					return new BaseToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Operator:
					return new OperatorToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.External:
					return new ExternalToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Var:
					return new VarToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Let:
					return new LetToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Get:
					return new GetToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Set:
					return new SetToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Sealed:
					return new SealedToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Override:
					return new OverrideToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Abstract:
					return new AbstractToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Params:
					return new ParamsToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Loop:
					return new LoopToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.While:
					return new WhileToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.If:
					return new IfToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Else:
					return new ElseToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.For:
					return new ForToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.In:
					return new InToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Switch:
					return new SwitchToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Break:
					return new BreakToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Continue:
					return new ContinueToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Return:
					return new ReturnToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Try:
					return new TryToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.TryPanic:
					return new TryPanicToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.TryResult:
					return new TryResultToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Catch:
					return new CatchToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Finally:
					return new FinallyToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Throw:
					return new ThrowToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Implicit:
					return new ImplicitToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Explicit:
					return new ExplicitToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Conversion:
					return new ConversionToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.As:
					return new AsToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.AsPanic:
					return new AsPanicToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.AsResult:
					return new AsResultToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Public:
					return new PublicToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Private:
					return new PrivateToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Protected:
					return new ProtectedToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Internal:
					return new InternalToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Safe:
					return new SafeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Unsafe:
					return new UnsafeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Own:
					return new OwnToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Mutable:
					return new MutableToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Immutable:
					return new ImmutableToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Copy:
					return new CopyToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Move:
					return new MoveToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Ref:
					return new RefToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Async:
					return new AsyncToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Await:
					return new AwaitToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Requires:
					return new RequiresToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Ensures:
					return new EnsuresToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Void:
					return new VoidToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.String:
					return new StringToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.ByteType:
					return new ByteTypeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.IntType:
					return new IntTypeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.UIntType:
					return new UIntTypeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.FloatType:
					return new FloatTypeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.SizeType:
					return new SizeTypeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.OffsetType:
					return new OffsetTypeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.UnsafeArrayType:
					return new UnsafeArrayTypeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Panic:
					return new PanicToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.ReservedWord:
					return new ReservedWordToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.BooleanLiteral:
					return new BooleanLiteralToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.IntLiteral:
					return new IntLiteralToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.NullLiteral:
					return new NullLiteralToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.StringLiteral:
					return new StringLiteralToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.CharLiteral:
					return new CharLiteralToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Semicolon:
					return new SemicolonToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Colon:
					return new ColonToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Dot:
					return new DotToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.DotDot:
					return new DotDotToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.To:
					return new ToToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.ColonColon:
					return new ColonColonToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Tilde:
					return new TildeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Comma:
					return new CommaToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Lambda:
					return new LambdaToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.LeftBrace:
					return new LeftBraceToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.RightBrace:
					return new RightBraceToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.LeftAngle:
					return new LeftAngleToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.RightAngle:
					return new RightAngleToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.LeftBracket:
					return new LeftBracketToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.RightBracket:
					return new RightBracketToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.LeftParen:
					return new LeftParenToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.RightParen:
					return new RightParenToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Asterisk:
					return new AsteriskToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.AtSign:
					return new AtSignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.AddressOf:
					return new AddressOfToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Coalesce:
					return new CoalesceToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.IsNull:
					return new IsNullToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Equal:
					return new EqualToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.NotEqual:
					return new NotEqualToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.LessThanOrEqual:
					return new LessThanOrEqualToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.GreaterThanOrEqual:
					return new GreaterThanOrEqualToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.TypeList:
					return new TypeListToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Plus:
					return new PlusToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Minus:
					return new MinusToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Divide:
					return new DivideToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Pipe:
					return new PipeToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.And:
					return new AndToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Xor:
					return new XorToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Or:
					return new OrToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Not:
					return new NotToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Assign:
					return new AssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.AddAssign:
					return new AddAssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.SubtractAssign:
					return new SubtractAssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.MultiplyAssign:
					return new MultiplyAssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.DivideAssign:
					return new DivideAssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.AndAssign:
					return new AndAssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.XorAssign:
					return new XorAssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.OrAssign:
					return new OrAssignToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.PlaceHolder:
					return new PlaceHolderToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Identifier:
					return new IdentifierToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.EscapedIdentifier:
					return new EscapedIdentifierToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.Unknown:
					return new UnknownToken(source, startIndex, stopIndex, channel, text);
				case PreAdamantLexer_Antlr.PreprocessorSkippedSection:
					return new PreprocessorSkippedSectionToken(source, startIndex, stopIndex, channel, text);
				default:
					throw new Exception($"Unknown token type {type}");
			}
		}
	}
}
