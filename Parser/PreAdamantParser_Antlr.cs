//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from PreAdamantParser_Antlr.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PreAdamant.Compiler.Parser.Antlr {
using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class PreAdamantParser_Antlr : Parser {
	public const int
		Whitespace=1, Newline=2, PreprocessorLine=3, DocComment=4, LineComment=5, 
		BlockComment=6, Using=7, Namespace=8, Class=9, Struct=10, Enum=11, New=12, 
		NewPanic=13, NewResult=14, NewPointer=15, NewPointerPanic=16, NewNullablePointer=17, 
		Delete=18, Self=19, Uninitialized=20, Where=21, Base=22, Operator=23, 
		External=24, Var=25, Let=26, Get=27, Set=28, Sealed=29, Override=30, Abstract=31, 
		Params=32, Loop=33, While=34, If=35, Else=36, For=37, In=38, Switch=39, 
		Break=40, Continue=41, Return=42, Try=43, TryPanic=44, TryResult=45, Catch=46, 
		Finally=47, Throw=48, Implicit=49, Explicit=50, Conversion=51, As=52, 
		AsPanic=53, AsResult=54, Public=55, Private=56, Protected=57, Internal=58, 
		Safe=59, Unsafe=60, Own=61, Mutable=62, Immutable=63, Copy=64, Move=65, 
		Ref=66, Async=67, Await=68, Requires=69, Ensures=70, Void=71, String=72, 
		ByteType=73, IntType=74, UIntType=75, FloatType=76, SizeType=77, OffsetType=78, 
		UnsafeArrayType=79, Panic=80, ReservedWord=81, BooleanLiteral=82, IntLiteral=83, 
		NullLiteral=84, StringLiteral=85, CharLiteral=86, Semicolon=87, Colon=88, 
		Dot=89, DotDot=90, To=91, ColonColon=92, Tilde=93, Comma=94, Lambda=95, 
		LeftBrace=96, RightBrace=97, LeftAngle=98, RightAngle=99, LeftBracket=100, 
		RightBracket=101, LeftParen=102, RightParen=103, Asterisk=104, AtSign=105, 
		AddressOf=106, Coalesce=107, IsNull=108, Equal=109, NotEqual=110, LessThanOrEqual=111, 
		GreaterThanOrEqual=112, TypeList=113, Plus=114, Minus=115, Divide=116, 
		Pipe=117, And=118, Xor=119, Or=120, Not=121, Assign=122, AddAssign=123, 
		SubtractAssign=124, MultiplyAssign=125, DivideAssign=126, AndAssign=127, 
		XorAssign=128, OrAssign=129, PlaceHolder=130, Identifier=131, EscapedIdentifier=132, 
		Unknown=133, PreprocessorSkippedSection=134, BadNotEqual=135;
	public const int
		RULE_compilationUnit = 0, RULE_usingDirective = 1, RULE_identifier = 2, 
		RULE_namespaceName = 3, RULE_declaration = 4;
	public static readonly string[] ruleNames = {
		"compilationUnit", "usingDirective", "identifier", "namespaceName", "declaration"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, "'using'", "'namespace'", "'class'", 
		"'struct'", "'enum'", "'new'", "'new!'", "'new?'", "'new*'", "'new*!'", 
		"'new*?'", "'delete'", "'self'", "'uninitialized'", "'where'", "'base'", 
		"'operator'", "'external'", "'var'", "'let'", "'get'", "'set'", "'sealed'", 
		"'override'", "'abstract'", "'params'", "'loop'", "'while'", "'if'", "'else'", 
		"'for'", "'in'", "'switch'", "'break'", "'continue'", "'return'", "'try'", 
		"'try!'", "'try?'", "'catch'", "'finally'", "'throw'", "'implicit'", "'explicit'", 
		"'conversion'", "'as'", "'as!'", "'as?'", "'public'", "'private'", "'protected'", 
		"'internal'", "'safe'", "'unsafe'", "'own'", "'mut'", "'immut'", "'copy'", 
		"'move'", "'ref'", "'async'", "'await'", "'requires'", "'ensures'", "'void'", 
		"'string'", "'byte'", null, null, null, "'size'", "'offset'", "'UnsafeArray'", 
		"'!'", null, null, null, "'null'", null, null, "';'", "':'", "'.'", "'..'", 
		"'to'", "'::'", "'~'", "','", "'->'", "'{'", "'}'", "'<'", "'>'", "'['", 
		"']'", "'('", "')'", "'*'", "'@'", "'&'", "'??'", "'?'", "'=='", "'<>'", 
		"'<='", "'>='", "'...'", "'+'", "'-'", "'/'", "'|'", "'and'", "'xor'", 
		"'or'", "'not'", "'='", "'+='", "'-='", "'*='", "'/='", "'and='", "'xor='", 
		"'or='", "'_'", null, null, null, null, "'!='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Whitespace", "Newline", "PreprocessorLine", "DocComment", "LineComment", 
		"BlockComment", "Using", "Namespace", "Class", "Struct", "Enum", "New", 
		"NewPanic", "NewResult", "NewPointer", "NewPointerPanic", "NewNullablePointer", 
		"Delete", "Self", "Uninitialized", "Where", "Base", "Operator", "External", 
		"Var", "Let", "Get", "Set", "Sealed", "Override", "Abstract", "Params", 
		"Loop", "While", "If", "Else", "For", "In", "Switch", "Break", "Continue", 
		"Return", "Try", "TryPanic", "TryResult", "Catch", "Finally", "Throw", 
		"Implicit", "Explicit", "Conversion", "As", "AsPanic", "AsResult", "Public", 
		"Private", "Protected", "Internal", "Safe", "Unsafe", "Own", "Mutable", 
		"Immutable", "Copy", "Move", "Ref", "Async", "Await", "Requires", "Ensures", 
		"Void", "String", "ByteType", "IntType", "UIntType", "FloatType", "SizeType", 
		"OffsetType", "UnsafeArrayType", "Panic", "ReservedWord", "BooleanLiteral", 
		"IntLiteral", "NullLiteral", "StringLiteral", "CharLiteral", "Semicolon", 
		"Colon", "Dot", "DotDot", "To", "ColonColon", "Tilde", "Comma", "Lambda", 
		"LeftBrace", "RightBrace", "LeftAngle", "RightAngle", "LeftBracket", "RightBracket", 
		"LeftParen", "RightParen", "Asterisk", "AtSign", "AddressOf", "Coalesce", 
		"IsNull", "Equal", "NotEqual", "LessThanOrEqual", "GreaterThanOrEqual", 
		"TypeList", "Plus", "Minus", "Divide", "Pipe", "And", "Xor", "Or", "Not", 
		"Assign", "AddAssign", "SubtractAssign", "MultiplyAssign", "DivideAssign", 
		"AndAssign", "XorAssign", "OrAssign", "PlaceHolder", "Identifier", "EscapedIdentifier", 
		"Unknown", "PreprocessorSkippedSection", "BadNotEqual"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PreAdamantParser_Antlr.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public PreAdamantParser_Antlr(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompilationUnitContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(PreAdamantParser_Antlr.Eof, 0); }
		public UsingDirectiveContext[] usingDirective() {
			return GetRuleContexts<UsingDirectiveContext>();
		}
		public UsingDirectiveContext usingDirective(int i) {
			return GetRuleContext<UsingDirectiveContext>(i);
		}
		public DeclarationContext[] declaration() {
			return GetRuleContexts<DeclarationContext>();
		}
		public DeclarationContext declaration(int i) {
			return GetRuleContext<DeclarationContext>(i);
		}
		public CompilationUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compilationUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.EnterCompilationUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.ExitCompilationUnit(this);
		}
	}

	[RuleVersion(0)]
	public CompilationUnitContext compilationUnit() {
		CompilationUnitContext _localctx = new CompilationUnitContext(Context, State);
		EnterRule(_localctx, 0, RULE_compilationUnit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 13;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Using) {
				{
				{
				State = 10; usingDirective();
				}
				}
				State = 15;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			}
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Identifier || _la==EscapedIdentifier) {
				{
				{
				State = 16; declaration();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			}
			State = 22; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UsingDirectiveContext : ParserRuleContext {
		public NamespaceNameContext namespaceName() {
			return GetRuleContext<NamespaceNameContext>(0);
		}
		public UsingDirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_usingDirective; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.EnterUsingDirective(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.ExitUsingDirective(this);
		}
	}

	[RuleVersion(0)]
	public UsingDirectiveContext usingDirective() {
		UsingDirectiveContext _localctx = new UsingDirectiveContext(Context, State);
		EnterRule(_localctx, 2, RULE_usingDirective);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24; Match(Using);
			State = 25; namespaceName();
			State = 26; Match(Semicolon);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdentifierContext : ParserRuleContext {
		public ITerminalNode Identifier() { return GetToken(PreAdamantParser_Antlr.Identifier, 0); }
		public ITerminalNode EscapedIdentifier() { return GetToken(PreAdamantParser_Antlr.EscapedIdentifier, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.EnterIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.ExitIdentifier(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierContext identifier() {
		IdentifierContext _localctx = new IdentifierContext(Context, State);
		EnterRule(_localctx, 4, RULE_identifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 28;
			_la = TokenStream.La(1);
			if ( !(_la==Identifier || _la==EscapedIdentifier) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NamespaceNameContext : ParserRuleContext {
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public NamespaceNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.EnterNamespaceName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.ExitNamespaceName(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceNameContext namespaceName() {
		NamespaceNameContext _localctx = new NamespaceNameContext(Context, State);
		EnterRule(_localctx, 6, RULE_namespaceName);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 30; identifier();
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==Dot) {
				{
				{
				State = 31; Match(Dot);
				State = 32; identifier();
				}
				}
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
		public override void EnterRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.EnterDeclaration(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IPreAdamantParser_AntlrListener typedListener = listener as IPreAdamantParser_AntlrListener;
			if (typedListener != null) typedListener.ExitDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(Context, State);
		EnterRule(_localctx, 8, RULE_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; identifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x89+\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x3\x2\a\x2\xE\n\x2\f\x2\xE"+
		"\x2\x11\v\x2\x3\x2\a\x2\x14\n\x2\f\x2\xE\x2\x17\v\x2\x3\x2\x3\x2\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\a\x5$\n\x5\f\x5\xE\x5"+
		"\'\v\x5\x3\x6\x3\x6\x3\x6\x2\x2\a\x2\x4\x6\b\n\x2\x3\x3\x2\x85\x86(\x2"+
		"\xF\x3\x2\x2\x2\x4\x1A\x3\x2\x2\x2\x6\x1E\x3\x2\x2\x2\b \x3\x2\x2\x2\n"+
		"(\x3\x2\x2\x2\f\xE\x5\x4\x3\x2\r\f\x3\x2\x2\x2\xE\x11\x3\x2\x2\x2\xF\r"+
		"\x3\x2\x2\x2\xF\x10\x3\x2\x2\x2\x10\x15\x3\x2\x2\x2\x11\xF\x3\x2\x2\x2"+
		"\x12\x14\x5\n\x6\x2\x13\x12\x3\x2\x2\x2\x14\x17\x3\x2\x2\x2\x15\x13\x3"+
		"\x2\x2\x2\x15\x16\x3\x2\x2\x2\x16\x18\x3\x2\x2\x2\x17\x15\x3\x2\x2\x2"+
		"\x18\x19\a\x2\x2\x3\x19\x3\x3\x2\x2\x2\x1A\x1B\a\t\x2\x2\x1B\x1C\x5\b"+
		"\x5\x2\x1C\x1D\aY\x2\x2\x1D\x5\x3\x2\x2\x2\x1E\x1F\t\x2\x2\x2\x1F\a\x3"+
		"\x2\x2\x2 %\x5\x6\x4\x2!\"\a[\x2\x2\"$\x5\x6\x4\x2#!\x3\x2\x2\x2$\'\x3"+
		"\x2\x2\x2%#\x3\x2\x2\x2%&\x3\x2\x2\x2&\t\x3\x2\x2\x2\'%\x3\x2\x2\x2()"+
		"\x5\x6\x4\x2)\v\x3\x2\x2\x2\x5\xF\x15%";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace PreAdamant.Compiler.Parser.Antlr
