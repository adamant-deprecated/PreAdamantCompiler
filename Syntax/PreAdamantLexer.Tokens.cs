using System;
using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{

	public partial class WhitespaceToken : SyntaxToken
	{
		public WhitespaceToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NewlineToken : SyntaxToken
	{
		public NewlineToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PreprocessorLineToken : SyntaxToken
	{
		public PreprocessorLineToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class DocCommentToken : SyntaxToken
	{
		public DocCommentToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LineCommentToken : SyntaxToken
	{
		public LineCommentToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class BlockCommentToken : SyntaxToken
	{
		public BlockCommentToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class UsingToken : KeywordToken
	{
		public UsingToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NamespaceToken : KeywordToken
	{
		public NamespaceToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ClassToken : KeywordToken
	{
		public ClassToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class StructToken : KeywordToken
	{
		public StructToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class EnumToken : KeywordToken
	{
		public EnumToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NewToken : KeywordToken
	{
		public NewToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NewPanicToken : KeywordToken
	{
		public NewPanicToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NewResultToken : KeywordToken
	{
		public NewResultToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NewPointerToken : KeywordToken
	{
		public NewPointerToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NewPointerPanicToken : KeywordToken
	{
		public NewPointerPanicToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NewNullablePointerToken : KeywordToken
	{
		public NewNullablePointerToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class DeleteToken : KeywordToken
	{
		public DeleteToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SelfToken : KeywordToken
	{
		public SelfToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class UninitializedToken : KeywordToken
	{
		public UninitializedToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class WhereToken : KeywordToken
	{
		public WhereToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class BaseToken : KeywordToken
	{
		public BaseToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class OperatorToken : KeywordToken
	{
		public OperatorToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ExternalToken : KeywordToken
	{
		public ExternalToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class VarToken : KeywordToken
	{
		public VarToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LetToken : KeywordToken
	{
		public LetToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class GetToken : KeywordToken
	{
		public GetToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SetToken : KeywordToken
	{
		public SetToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SealedToken : KeywordToken
	{
		public SealedToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class OverrideToken : KeywordToken
	{
		public OverrideToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AbstractToken : KeywordToken
	{
		public AbstractToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ParamsToken : KeywordToken
	{
		public ParamsToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LoopToken : KeywordToken
	{
		public LoopToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class WhileToken : KeywordToken
	{
		public WhileToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class IfToken : KeywordToken
	{
		public IfToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ElseToken : KeywordToken
	{
		public ElseToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ForToken : KeywordToken
	{
		public ForToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class InToken : KeywordToken
	{
		public InToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SwitchToken : KeywordToken
	{
		public SwitchToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class BreakToken : KeywordToken
	{
		public BreakToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ContinueToken : KeywordToken
	{
		public ContinueToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ReturnToken : KeywordToken
	{
		public ReturnToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class TryToken : KeywordToken
	{
		public TryToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class TryPanicToken : KeywordToken
	{
		public TryPanicToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class TryResultToken : KeywordToken
	{
		public TryResultToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class CatchToken : KeywordToken
	{
		public CatchToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class FinallyToken : KeywordToken
	{
		public FinallyToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ThrowToken : KeywordToken
	{
		public ThrowToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ImplicitToken : KeywordToken
	{
		public ImplicitToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ExplicitToken : KeywordToken
	{
		public ExplicitToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ConversionToken : KeywordToken
	{
		public ConversionToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AsToken : KeywordToken
	{
		public AsToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AsPanicToken : KeywordToken
	{
		public AsPanicToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AsResultToken : KeywordToken
	{
		public AsResultToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PublicToken : KeywordToken
	{
		public PublicToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PrivateToken : KeywordToken
	{
		public PrivateToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ProtectedToken : KeywordToken
	{
		public ProtectedToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class InternalToken : KeywordToken
	{
		public InternalToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SafeToken : KeywordToken
	{
		public SafeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class UnsafeToken : KeywordToken
	{
		public UnsafeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class OwnToken : KeywordToken
	{
		public OwnToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class MutableToken : KeywordToken
	{
		public MutableToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ImmutableToken : KeywordToken
	{
		public ImmutableToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class CopyToken : KeywordToken
	{
		public CopyToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class MoveToken : KeywordToken
	{
		public MoveToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class RefToken : KeywordToken
	{
		public RefToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AsyncToken : KeywordToken
	{
		public AsyncToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AwaitToken : KeywordToken
	{
		public AwaitToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class RequiresToken : KeywordToken
	{
		public RequiresToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class EnsuresToken : KeywordToken
	{
		public EnsuresToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class VoidToken : KeywordToken
	{
		public VoidToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class StringToken : KeywordToken
	{
		public StringToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ByteTypeToken : KeywordToken
	{
		public ByteTypeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class IntTypeToken : KeywordToken
	{
		public IntTypeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class UIntTypeToken : KeywordToken
	{
		public UIntTypeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class FloatTypeToken : KeywordToken
	{
		public FloatTypeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SizeTypeToken : KeywordToken
	{
		public SizeTypeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class OffsetTypeToken : KeywordToken
	{
		public OffsetTypeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class UnsafeArrayTypeToken : KeywordToken
	{
		public UnsafeArrayTypeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PanicToken : SyntaxToken
	{
		public PanicToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ReservedWordToken : SyntaxToken
	{
		public ReservedWordToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class BooleanLiteralToken : SyntaxToken
	{
		public BooleanLiteralToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class IntLiteralToken : SyntaxToken
	{
		public IntLiteralToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NullLiteralToken : SyntaxToken
	{
		public NullLiteralToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class StringLiteralToken : SyntaxToken
	{
		public StringLiteralToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class CharLiteralToken : SyntaxToken
	{
		public CharLiteralToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SemicolonToken : SyntaxToken
	{
		public SemicolonToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ColonToken : SyntaxToken
	{
		public ColonToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class DotToken : SyntaxToken
	{
		public DotToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class DotDotToken : SyntaxToken
	{
		public DotDotToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ToToken : SyntaxToken
	{
		public ToToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class ColonColonToken : SyntaxToken
	{
		public ColonColonToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class TildeToken : SyntaxToken
	{
		public TildeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class CommaToken : SyntaxToken
	{
		public CommaToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LambdaToken : SyntaxToken
	{
		public LambdaToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LeftBraceToken : SyntaxToken
	{
		public LeftBraceToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class RightBraceToken : SyntaxToken
	{
		public RightBraceToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LeftAngleToken : SyntaxToken
	{
		public LeftAngleToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class RightAngleToken : SyntaxToken
	{
		public RightAngleToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LeftBracketToken : SyntaxToken
	{
		public LeftBracketToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class RightBracketToken : SyntaxToken
	{
		public RightBracketToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LeftParenToken : SyntaxToken
	{
		public LeftParenToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class RightParenToken : SyntaxToken
	{
		public RightParenToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AsteriskToken : SyntaxToken
	{
		public AsteriskToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AtSignToken : SyntaxToken
	{
		public AtSignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AddressOfToken : SyntaxToken
	{
		public AddressOfToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class CoalesceToken : SyntaxToken
	{
		public CoalesceToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class IsNullToken : SyntaxToken
	{
		public IsNullToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class EqualToken : SyntaxToken
	{
		public EqualToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NotEqualToken : SyntaxToken
	{
		public NotEqualToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class LessThanOrEqualToken : SyntaxToken
	{
		public LessThanOrEqualToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class GreaterThanOrEqualToken : SyntaxToken
	{
		public GreaterThanOrEqualToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class TypeListToken : SyntaxToken
	{
		public TypeListToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PlusToken : SyntaxToken
	{
		public PlusToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class MinusToken : SyntaxToken
	{
		public MinusToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class DivideToken : SyntaxToken
	{
		public DivideToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PipeToken : SyntaxToken
	{
		public PipeToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AndToken : SyntaxToken
	{
		public AndToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class XorToken : SyntaxToken
	{
		public XorToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class OrToken : SyntaxToken
	{
		public OrToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class NotToken : SyntaxToken
	{
		public NotToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AssignToken : SyntaxToken
	{
		public AssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AddAssignToken : SyntaxToken
	{
		public AddAssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class SubtractAssignToken : SyntaxToken
	{
		public SubtractAssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class MultiplyAssignToken : SyntaxToken
	{
		public MultiplyAssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class DivideAssignToken : SyntaxToken
	{
		public DivideAssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class AndAssignToken : SyntaxToken
	{
		public AndAssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class XorAssignToken : SyntaxToken
	{
		public XorAssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class OrAssignToken : SyntaxToken
	{
		public OrAssignToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PlaceHolderToken : SyntaxToken
	{
		public PlaceHolderToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class IdentifierToken : SyntaxToken
	{
		public IdentifierToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class EscapedIdentifierToken : SyntaxToken
	{
		public EscapedIdentifierToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class UnknownToken : SyntaxToken
	{
		public UnknownToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}

	public partial class PreprocessorSkippedSectionToken : SyntaxToken
	{
		public PreprocessorSkippedSectionToken(ISourceText source, int startIndex, int stopIndex, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, channel, text)
		{
		}
	}
}
