using System;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Lexer.Antlr;

namespace PreAdamant.Compiler.Lexer
{
	public partial class PreAdamantLexer
	{
		private const int StartMode = PreAdamantLexer_Antlr.Code;
		public enum Channel
		{
			Main = 0,
			Trivia,
		}

		private Token CreateToken(SourceText source, int startIndex, int stopIndex, int type, Channel channel, string text)
		{
			switch(type)
			{
				case PreAdamantLexer_Antlr.Whitespace:
					return new WhitespaceToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Newline:
					return new NewlineToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.PreprocessorLine:
					return new PreprocessorLineToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.DocComment:
					return new DocCommentToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.LineComment:
					return new LineCommentToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.BlockComment:
					return new BlockCommentToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Using:
					return new UsingToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Namespace:
					return new NamespaceToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Class:
					return new ClassToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Struct:
					return new StructToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Enum:
					return new EnumToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.New:
					return new NewToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.NewPanic:
					return new NewPanicToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.NewResult:
					return new NewResultToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.NewPointer:
					return new NewPointerToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.NewPointerPanic:
					return new NewPointerPanicToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.NewNullablePointer:
					return new NewNullablePointerToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Delete:
					return new DeleteToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Self:
					return new SelfToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Uninitialized:
					return new UninitializedToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Where:
					return new WhereToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Base:
					return new BaseToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Operator:
					return new OperatorToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.External:
					return new ExternalToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Var:
					return new VarToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Let:
					return new LetToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Get:
					return new GetToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Set:
					return new SetToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Sealed:
					return new SealedToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Override:
					return new OverrideToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Abstract:
					return new AbstractToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Params:
					return new ParamsToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Loop:
					return new LoopToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.While:
					return new WhileToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.If:
					return new IfToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Else:
					return new ElseToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.For:
					return new ForToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.In:
					return new InToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Switch:
					return new SwitchToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Break:
					return new BreakToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Continue:
					return new ContinueToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Return:
					return new ReturnToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Try:
					return new TryToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.TryPanic:
					return new TryPanicToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.TryResult:
					return new TryResultToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Catch:
					return new CatchToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Finally:
					return new FinallyToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Throw:
					return new ThrowToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Implicit:
					return new ImplicitToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Explicit:
					return new ExplicitToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Conversion:
					return new ConversionToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.As:
					return new AsToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.AsPanic:
					return new AsPanicToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.AsResult:
					return new AsResultToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Public:
					return new PublicToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Private:
					return new PrivateToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Protected:
					return new ProtectedToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Internal:
					return new InternalToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Safe:
					return new SafeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Unsafe:
					return new UnsafeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Own:
					return new OwnToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Mutable:
					return new MutableToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Immutable:
					return new ImmutableToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Copy:
					return new CopyToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Move:
					return new MoveToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Ref:
					return new RefToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Async:
					return new AsyncToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Await:
					return new AwaitToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Requires:
					return new RequiresToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Ensures:
					return new EnsuresToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Void:
					return new VoidToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.String:
					return new StringToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.ByteType:
					return new ByteTypeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.IntType:
					return new IntTypeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.UIntType:
					return new UIntTypeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.FloatType:
					return new FloatTypeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.SizeType:
					return new SizeTypeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.OffsetType:
					return new OffsetTypeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.UnsafeArrayType:
					return new UnsafeArrayTypeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Panic:
					return new PanicToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.ReservedWord:
					return new ReservedWordToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.BooleanLiteral:
					return new BooleanLiteralToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.IntLiteral:
					return new IntLiteralToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.NullLiteral:
					return new NullLiteralToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.StringLiteral:
					return new StringLiteralToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.CharLiteral:
					return new CharLiteralToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Semicolon:
					return new SemicolonToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Colon:
					return new ColonToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Dot:
					return new DotToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.DotDot:
					return new DotDotToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.To:
					return new ToToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.ColonColon:
					return new ColonColonToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Tilde:
					return new TildeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Comma:
					return new CommaToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Lambda:
					return new LambdaToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.LeftBrace:
					return new LeftBraceToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.RightBrace:
					return new RightBraceToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.LeftAngle:
					return new LeftAngleToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.RightAngle:
					return new RightAngleToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.LeftBracket:
					return new LeftBracketToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.RightBracket:
					return new RightBracketToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.LeftParen:
					return new LeftParenToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.RightParen:
					return new RightParenToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Asterisk:
					return new AsteriskToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.AtSign:
					return new AtSignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.AddressOf:
					return new AddressOfToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Coalesce:
					return new CoalesceToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.IsNull:
					return new IsNullToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Equal:
					return new EqualToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.NotEqual:
					return new NotEqualToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.LessThanOrEqual:
					return new LessThanOrEqualToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.GreaterThanOrEqual:
					return new GreaterThanOrEqualToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.TypeList:
					return new TypeListToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Plus:
					return new PlusToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Minus:
					return new MinusToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Divide:
					return new DivideToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Pipe:
					return new PipeToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.And:
					return new AndToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Xor:
					return new XorToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Or:
					return new OrToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Not:
					return new NotToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Assign:
					return new AssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.AddAssign:
					return new AddAssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.SubtractAssign:
					return new SubtractAssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.MultiplyAssign:
					return new MultiplyAssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.DivideAssign:
					return new DivideAssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.AndAssign:
					return new AndAssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.XorAssign:
					return new XorAssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.OrAssign:
					return new OrAssignToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.PlaceHolder:
					return new PlaceHolderToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Identifier:
					return new IdentifierToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.EscapedIdentifier:
					return new EscapedIdentifierToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.Unknown:
					return new UnknownToken(source, startIndex, stopIndex, type, channel, text);
				case PreAdamantLexer_Antlr.PreprocessorSkippedSection:
					return new PreprocessorSkippedSectionToken(source, startIndex, stopIndex, type, channel, text);
				default:
					throw new Exception($"Unknown token type {type}");
			}
		}
	}

	public partial class WhitespaceToken : Token
	{
		public WhitespaceToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NewlineToken : Token
	{
		public NewlineToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PreprocessorLineToken : Token
	{
		public PreprocessorLineToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class DocCommentToken : Token
	{
		public DocCommentToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LineCommentToken : Token
	{
		public LineCommentToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class BlockCommentToken : Token
	{
		public BlockCommentToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class UsingToken : KeywordToken
	{
		public UsingToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NamespaceToken : KeywordToken
	{
		public NamespaceToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ClassToken : KeywordToken
	{
		public ClassToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class StructToken : KeywordToken
	{
		public StructToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class EnumToken : KeywordToken
	{
		public EnumToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NewToken : KeywordToken
	{
		public NewToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NewPanicToken : KeywordToken
	{
		public NewPanicToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NewResultToken : KeywordToken
	{
		public NewResultToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NewPointerToken : KeywordToken
	{
		public NewPointerToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NewPointerPanicToken : KeywordToken
	{
		public NewPointerPanicToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NewNullablePointerToken : KeywordToken
	{
		public NewNullablePointerToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class DeleteToken : KeywordToken
	{
		public DeleteToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SelfToken : KeywordToken
	{
		public SelfToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class UninitializedToken : KeywordToken
	{
		public UninitializedToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class WhereToken : KeywordToken
	{
		public WhereToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class BaseToken : KeywordToken
	{
		public BaseToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class OperatorToken : KeywordToken
	{
		public OperatorToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ExternalToken : KeywordToken
	{
		public ExternalToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class VarToken : KeywordToken
	{
		public VarToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LetToken : KeywordToken
	{
		public LetToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class GetToken : KeywordToken
	{
		public GetToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SetToken : KeywordToken
	{
		public SetToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SealedToken : KeywordToken
	{
		public SealedToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class OverrideToken : KeywordToken
	{
		public OverrideToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AbstractToken : KeywordToken
	{
		public AbstractToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ParamsToken : KeywordToken
	{
		public ParamsToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LoopToken : KeywordToken
	{
		public LoopToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class WhileToken : KeywordToken
	{
		public WhileToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class IfToken : KeywordToken
	{
		public IfToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ElseToken : KeywordToken
	{
		public ElseToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ForToken : KeywordToken
	{
		public ForToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class InToken : KeywordToken
	{
		public InToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SwitchToken : KeywordToken
	{
		public SwitchToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class BreakToken : KeywordToken
	{
		public BreakToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ContinueToken : KeywordToken
	{
		public ContinueToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ReturnToken : KeywordToken
	{
		public ReturnToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class TryToken : KeywordToken
	{
		public TryToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class TryPanicToken : KeywordToken
	{
		public TryPanicToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class TryResultToken : KeywordToken
	{
		public TryResultToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class CatchToken : KeywordToken
	{
		public CatchToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class FinallyToken : KeywordToken
	{
		public FinallyToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ThrowToken : KeywordToken
	{
		public ThrowToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ImplicitToken : KeywordToken
	{
		public ImplicitToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ExplicitToken : KeywordToken
	{
		public ExplicitToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ConversionToken : KeywordToken
	{
		public ConversionToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AsToken : KeywordToken
	{
		public AsToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AsPanicToken : KeywordToken
	{
		public AsPanicToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AsResultToken : KeywordToken
	{
		public AsResultToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PublicToken : KeywordToken
	{
		public PublicToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PrivateToken : KeywordToken
	{
		public PrivateToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ProtectedToken : KeywordToken
	{
		public ProtectedToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class InternalToken : KeywordToken
	{
		public InternalToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SafeToken : KeywordToken
	{
		public SafeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class UnsafeToken : KeywordToken
	{
		public UnsafeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class OwnToken : KeywordToken
	{
		public OwnToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class MutableToken : KeywordToken
	{
		public MutableToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ImmutableToken : KeywordToken
	{
		public ImmutableToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class CopyToken : KeywordToken
	{
		public CopyToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class MoveToken : KeywordToken
	{
		public MoveToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class RefToken : KeywordToken
	{
		public RefToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AsyncToken : KeywordToken
	{
		public AsyncToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AwaitToken : KeywordToken
	{
		public AwaitToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class RequiresToken : KeywordToken
	{
		public RequiresToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class EnsuresToken : KeywordToken
	{
		public EnsuresToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class VoidToken : KeywordToken
	{
		public VoidToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class StringToken : KeywordToken
	{
		public StringToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ByteTypeToken : KeywordToken
	{
		public ByteTypeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class IntTypeToken : KeywordToken
	{
		public IntTypeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class UIntTypeToken : KeywordToken
	{
		public UIntTypeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class FloatTypeToken : KeywordToken
	{
		public FloatTypeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SizeTypeToken : KeywordToken
	{
		public SizeTypeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class OffsetTypeToken : KeywordToken
	{
		public OffsetTypeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class UnsafeArrayTypeToken : KeywordToken
	{
		public UnsafeArrayTypeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PanicToken : Token
	{
		public PanicToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ReservedWordToken : Token
	{
		public ReservedWordToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class BooleanLiteralToken : Token
	{
		public BooleanLiteralToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class IntLiteralToken : Token
	{
		public IntLiteralToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NullLiteralToken : Token
	{
		public NullLiteralToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class StringLiteralToken : Token
	{
		public StringLiteralToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class CharLiteralToken : Token
	{
		public CharLiteralToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SemicolonToken : Token
	{
		public SemicolonToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ColonToken : Token
	{
		public ColonToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class DotToken : Token
	{
		public DotToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class DotDotToken : Token
	{
		public DotDotToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ToToken : Token
	{
		public ToToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class ColonColonToken : Token
	{
		public ColonColonToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class TildeToken : Token
	{
		public TildeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class CommaToken : Token
	{
		public CommaToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LambdaToken : Token
	{
		public LambdaToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LeftBraceToken : Token
	{
		public LeftBraceToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class RightBraceToken : Token
	{
		public RightBraceToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LeftAngleToken : Token
	{
		public LeftAngleToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class RightAngleToken : Token
	{
		public RightAngleToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LeftBracketToken : Token
	{
		public LeftBracketToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class RightBracketToken : Token
	{
		public RightBracketToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LeftParenToken : Token
	{
		public LeftParenToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class RightParenToken : Token
	{
		public RightParenToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AsteriskToken : Token
	{
		public AsteriskToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AtSignToken : Token
	{
		public AtSignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AddressOfToken : Token
	{
		public AddressOfToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class CoalesceToken : Token
	{
		public CoalesceToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class IsNullToken : Token
	{
		public IsNullToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class EqualToken : Token
	{
		public EqualToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NotEqualToken : Token
	{
		public NotEqualToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class LessThanOrEqualToken : Token
	{
		public LessThanOrEqualToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class GreaterThanOrEqualToken : Token
	{
		public GreaterThanOrEqualToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class TypeListToken : Token
	{
		public TypeListToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PlusToken : Token
	{
		public PlusToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class MinusToken : Token
	{
		public MinusToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class DivideToken : Token
	{
		public DivideToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PipeToken : Token
	{
		public PipeToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AndToken : Token
	{
		public AndToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class XorToken : Token
	{
		public XorToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class OrToken : Token
	{
		public OrToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class NotToken : Token
	{
		public NotToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AssignToken : Token
	{
		public AssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AddAssignToken : Token
	{
		public AddAssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class SubtractAssignToken : Token
	{
		public SubtractAssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class MultiplyAssignToken : Token
	{
		public MultiplyAssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class DivideAssignToken : Token
	{
		public DivideAssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class AndAssignToken : Token
	{
		public AndAssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class XorAssignToken : Token
	{
		public XorAssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class OrAssignToken : Token
	{
		public OrAssignToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PlaceHolderToken : Token
	{
		public PlaceHolderToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class IdentifierToken : Token
	{
		public IdentifierToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class EscapedIdentifierToken : Token
	{
		public EscapedIdentifierToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class UnknownToken : Token
	{
		public UnknownToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}

	public partial class PreprocessorSkippedSectionToken : Token
	{
		public PreprocessorSkippedSectionToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}
}
