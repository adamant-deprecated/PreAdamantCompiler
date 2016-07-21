//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SpecParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PreAdamant.Compiler.Tools.Parse {
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
public partial class SpecParser : Parser {
	public const int
		Comment=1, Whitespace=2, Parser=3, Namespace=4, Import=5, StartRule=6, 
		OfType=7, Scope=8, Dot=9, Definition=10, Alternation=11, Optional=12, 
		Repetition=13, OneOrMore=14, BeginGroup=15, EndGroup=16, LeftBrace=17, 
		RightBrace=18, Terminator=19, Comma=20, Number=21, Identifier=22, Literal=23, 
		InvalidKeyword=24, UnexpectedChar=25;
	public const int
		RULE_spec = 0, RULE_directive = 1, RULE_parseRule = 2, RULE_pattern = 3;
	public static readonly string[] ruleNames = {
		"spec", "directive", "parseRule", "pattern"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, "'@parser'", "'@namespace'", "'@import'", "'@startRule'", 
		"':'", "'::'", "'.'", "'='", "'|'", "'?'", "'*'", "'+'", "'('", "')'", 
		"'{'", "'}'", "';'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Comment", "Whitespace", "Parser", "Namespace", "Import", "StartRule", 
		"OfType", "Scope", "Dot", "Definition", "Alternation", "Optional", "Repetition", 
		"OneOrMore", "BeginGroup", "EndGroup", "LeftBrace", "RightBrace", "Terminator", 
		"Comma", "Number", "Identifier", "Literal", "InvalidKeyword", "UnexpectedChar"
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

	public override string GrammarFileName { get { return "SpecParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public SpecParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class SpecContext : ParserRuleContext {
		public DirectiveContext[] directive() {
			return GetRuleContexts<DirectiveContext>();
		}
		public DirectiveContext directive(int i) {
			return GetRuleContext<DirectiveContext>(i);
		}
		public ParseRuleContext[] parseRule() {
			return GetRuleContexts<ParseRuleContext>();
		}
		public ParseRuleContext parseRule(int i) {
			return GetRuleContext<ParseRuleContext>(i);
		}
		public SpecContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_spec; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterSpec(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitSpec(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSpec(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SpecContext spec() {
		SpecContext _localctx = new SpecContext(Context, State);
		EnterRule(_localctx, 0, RULE_spec);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Parser) | (1L << Namespace) | (1L << Import) | (1L << StartRule) | (1L << Identifier))) != 0)) {
				{
				State = 10;
				switch (TokenStream.La(1)) {
				case Parser:
				case Namespace:
				case Import:
				case StartRule:
					{
					State = 8; directive();
					}
					break;
				case Identifier:
					{
					State = 9; parseRule();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 14;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
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

	public partial class DirectiveContext : ParserRuleContext {
		public DirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directive; } }
	 
		public DirectiveContext() { }
		public virtual void CopyFrom(DirectiveContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ImportDirectiveContext : DirectiveContext {
		public IToken alias;
		public IToken lexerName;
		public ITerminalNode[] Identifier() { return GetTokens(SpecParser.Identifier); }
		public ITerminalNode Identifier(int i) {
			return GetToken(SpecParser.Identifier, i);
		}
		public ImportDirectiveContext(DirectiveContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterImportDirective(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitImportDirective(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitImportDirective(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NameDirectiveContext : DirectiveContext {
		public ITerminalNode Identifier() { return GetToken(SpecParser.Identifier, 0); }
		public NameDirectiveContext(DirectiveContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterNameDirective(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitNameDirective(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNameDirective(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NamespaceDirectiveContext : DirectiveContext {
		public ITerminalNode[] Identifier() { return GetTokens(SpecParser.Identifier); }
		public ITerminalNode Identifier(int i) {
			return GetToken(SpecParser.Identifier, i);
		}
		public NamespaceDirectiveContext(DirectiveContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterNamespaceDirective(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitNamespaceDirective(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNamespaceDirective(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StartRuleDirectiveContext : DirectiveContext {
		public ITerminalNode Identifier() { return GetToken(SpecParser.Identifier, 0); }
		public StartRuleDirectiveContext(DirectiveContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterStartRuleDirective(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitStartRuleDirective(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStartRuleDirective(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DirectiveContext directive() {
		DirectiveContext _localctx = new DirectiveContext(Context, State);
		EnterRule(_localctx, 2, RULE_directive);
		int _la;
		try {
			State = 38;
			switch (TokenStream.La(1)) {
			case Parser:
				_localctx = new NameDirectiveContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 15; Match(Parser);
				State = 16; Match(Identifier);
				State = 17; Match(Terminator);
				}
				break;
			case Namespace:
				_localctx = new NamespaceDirectiveContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 18; Match(Namespace);
				State = 19; Match(Identifier);
				State = 24;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
				while (_la==Dot) {
					{
					{
					State = 20; Match(Dot);
					State = 21; Match(Identifier);
					}
					}
					State = 26;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
				}
				State = 27; Match(Terminator);
				}
				break;
			case Import:
				_localctx = new ImportDirectiveContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 28; Match(Import);
				State = 31;
				switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
				case 1:
					{
					State = 29; ((ImportDirectiveContext)_localctx).alias = Match(Identifier);
					State = 30; Match(Definition);
					}
					break;
				}
				State = 33; ((ImportDirectiveContext)_localctx).lexerName = Match(Identifier);
				State = 34; Match(Terminator);
				}
				break;
			case StartRule:
				_localctx = new StartRuleDirectiveContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 35; Match(StartRule);
				State = 36; Match(Identifier);
				State = 37; Match(Terminator);
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class ParseRuleContext : ParserRuleContext {
		public IToken name;
		public IToken @base;
		public IToken _Identifier;
		public IList<IToken> _attributes = new List<IToken>();
		public ITerminalNode[] Identifier() { return GetTokens(SpecParser.Identifier); }
		public ITerminalNode Identifier(int i) {
			return GetToken(SpecParser.Identifier, i);
		}
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public ParseRuleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parseRule; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterParseRule(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitParseRule(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParseRule(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParseRuleContext parseRule() {
		ParseRuleContext _localctx = new ParseRuleContext(Context, State);
		EnterRule(_localctx, 4, RULE_parseRule);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 40; _localctx.name = Match(Identifier);
			State = 43;
			_la = TokenStream.La(1);
			if (_la==OfType) {
				{
				State = 41; Match(OfType);
				State = 42; _localctx.@base = Match(Identifier);
				}
			}

			State = 59;
			_la = TokenStream.La(1);
			if (_la==Definition) {
				{
				State = 45; Match(Definition);
				State = 46; pattern(0);
				State = 57;
				_la = TokenStream.La(1);
				if (_la==LeftBrace) {
					{
					State = 47; Match(LeftBrace);
					State = 48; _localctx._Identifier = Match(Identifier);
					_localctx._attributes.Add(_localctx._Identifier);
					State = 53;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
					while (_la==Comma) {
						{
						{
						State = 49; Match(Comma);
						State = 50; _localctx._Identifier = Match(Identifier);
						_localctx._attributes.Add(_localctx._Identifier);
						}
						}
						State = 55;
						ErrorHandler.Sync(this);
						_la = TokenStream.La(1);
					}
					State = 56; Match(RightBrace);
					}
				}

				}
			}

			State = 61; Match(Terminator);
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

	public partial class PatternContext : ParserRuleContext {
		public PatternContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pattern; } }
	 
		public PatternContext() { }
		public virtual void CopyFrom(PatternContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class LiteralPatternContext : PatternContext {
		public ITerminalNode Literal() { return GetToken(SpecParser.Literal, 0); }
		public LiteralPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterLiteralPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitLiteralPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLiteralPattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class OptionalPatternContext : PatternContext {
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public OptionalPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterOptionalPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitOptionalPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOptionalPattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RepeatWithSeparatorPatternContext : PatternContext {
		public IToken separator;
		public IToken min;
		public IToken range;
		public IToken max;
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public ITerminalNode Literal() { return GetToken(SpecParser.Literal, 0); }
		public ITerminalNode[] Number() { return GetTokens(SpecParser.Number); }
		public ITerminalNode Number(int i) {
			return GetToken(SpecParser.Number, i);
		}
		public RepeatWithSeparatorPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterRepeatWithSeparatorPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitRepeatWithSeparatorPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRepeatWithSeparatorPattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ZeroOrMorePatternContext : PatternContext {
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public ZeroOrMorePatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterZeroOrMorePattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitZeroOrMorePattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitZeroOrMorePattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class GroupingPatternContext : PatternContext {
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public GroupingPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterGroupingPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitGroupingPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGroupingPattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ImportedRulePatternContext : PatternContext {
		public IToken lexerName;
		public IToken ruleName;
		public ITerminalNode[] Identifier() { return GetTokens(SpecParser.Identifier); }
		public ITerminalNode Identifier(int i) {
			return GetToken(SpecParser.Identifier, i);
		}
		public ImportedRulePatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterImportedRulePattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitImportedRulePattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitImportedRulePattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ConcatPatternContext : PatternContext {
		public PatternContext[] pattern() {
			return GetRuleContexts<PatternContext>();
		}
		public PatternContext pattern(int i) {
			return GetRuleContext<PatternContext>(i);
		}
		public ConcatPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterConcatPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitConcatPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConcatPattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class OneOrMorePatternContext : PatternContext {
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public OneOrMorePatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterOneOrMorePattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitOneOrMorePattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOneOrMorePattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RepeatPatternContext : PatternContext {
		public IToken min;
		public IToken range;
		public IToken max;
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public ITerminalNode[] Number() { return GetTokens(SpecParser.Number); }
		public ITerminalNode Number(int i) {
			return GetToken(SpecParser.Number, i);
		}
		public RepeatPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterRepeatPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitRepeatPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRepeatPattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RulePatternContext : PatternContext {
		public IToken ruleName;
		public ITerminalNode Identifier() { return GetToken(SpecParser.Identifier, 0); }
		public RulePatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterRulePattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitRulePattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRulePattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LabelPatternContext : PatternContext {
		public IToken label;
		public PatternContext pattern() {
			return GetRuleContext<PatternContext>(0);
		}
		public ITerminalNode Identifier() { return GetToken(SpecParser.Identifier, 0); }
		public LabelPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterLabelPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitLabelPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLabelPattern(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlternationPatternContext : PatternContext {
		public PatternContext[] pattern() {
			return GetRuleContexts<PatternContext>();
		}
		public PatternContext pattern(int i) {
			return GetRuleContext<PatternContext>(i);
		}
		public AlternationPatternContext(PatternContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.EnterAlternationPattern(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpecParserListener typedListener = listener as ISpecParserListener;
			if (typedListener != null) typedListener.ExitAlternationPattern(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISpecParserVisitor<TResult> typedVisitor = visitor as ISpecParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlternationPattern(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PatternContext pattern() {
		return pattern(0);
	}

	private PatternContext pattern(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		PatternContext _localctx = new PatternContext(Context, _parentState);
		PatternContext _prevctx = _localctx;
		int _startState = 6;
		EnterRecursionRule(_localctx, 6, RULE_pattern, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 76;
			switch ( Interpreter.AdaptivePredict(TokenStream,9,Context) ) {
			case 1:
				{
				_localctx = new LabelPatternContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 64; ((LabelPatternContext)_localctx).label = Match(Identifier);
				State = 65; Match(OfType);
				State = 66; pattern(10);
				}
				break;
			case 2:
				{
				_localctx = new GroupingPatternContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 67; Match(BeginGroup);
				State = 68; pattern(0);
				State = 69; Match(EndGroup);
				}
				break;
			case 3:
				{
				_localctx = new ImportedRulePatternContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 71; ((ImportedRulePatternContext)_localctx).lexerName = Match(Identifier);
				State = 72; Match(Scope);
				State = 73; ((ImportedRulePatternContext)_localctx).ruleName = Match(Identifier);
				}
				break;
			case 4:
				{
				_localctx = new RulePatternContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 74; ((RulePatternContext)_localctx).ruleName = Match(Identifier);
				}
				break;
			case 5:
				{
				_localctx = new LiteralPatternContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 75; Match(Literal);
				}
				break;
			}
			Context.Stop = TokenStream.Lt(-1);
			State = 114;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,16,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 112;
					switch ( Interpreter.AdaptivePredict(TokenStream,15,Context) ) {
					case 1:
						{
						_localctx = new ConcatPatternContext(new PatternContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_pattern);
						State = 78;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 79; pattern(5);
						}
						break;
					case 2:
						{
						_localctx = new AlternationPatternContext(new PatternContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_pattern);
						State = 80;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 81; Match(Alternation);
						State = 82; pattern(4);
						}
						break;
					case 3:
						{
						_localctx = new OptionalPatternContext(new PatternContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_pattern);
						State = 83;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 84; Match(Optional);
						}
						break;
					case 4:
						{
						_localctx = new ZeroOrMorePatternContext(new PatternContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_pattern);
						State = 85;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 86; Match(Repetition);
						}
						break;
					case 5:
						{
						_localctx = new OneOrMorePatternContext(new PatternContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_pattern);
						State = 87;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 88; Match(OneOrMore);
						}
						break;
					case 6:
						{
						_localctx = new RepeatWithSeparatorPatternContext(new PatternContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_pattern);
						State = 89;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 90; Match(LeftBrace);
						State = 91; ((RepeatWithSeparatorPatternContext)_localctx).separator = Match(Literal);
						State = 99;
						_la = TokenStream.La(1);
						if (_la==Number) {
							{
							State = 92; ((RepeatWithSeparatorPatternContext)_localctx).min = Match(Number);
							State = 97;
							_la = TokenStream.La(1);
							if (_la==Comma) {
								{
								State = 93; ((RepeatWithSeparatorPatternContext)_localctx).range = Match(Comma);
								State = 95;
								_la = TokenStream.La(1);
								if (_la==Number) {
									{
									State = 94; ((RepeatWithSeparatorPatternContext)_localctx).max = Match(Number);
									}
								}

								}
							}

							}
						}

						State = 101; Match(RightBrace);
						}
						break;
					case 7:
						{
						_localctx = new RepeatPatternContext(new PatternContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_pattern);
						State = 102;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 103; Match(LeftBrace);
						State = 104; ((RepeatPatternContext)_localctx).min = Match(Number);
						State = 109;
						_la = TokenStream.La(1);
						if (_la==Comma) {
							{
							State = 105; ((RepeatPatternContext)_localctx).range = Match(Comma);
							State = 107;
							_la = TokenStream.La(1);
							if (_la==Number) {
								{
								State = 106; ((RepeatPatternContext)_localctx).max = Match(Number);
								}
							}

							}
						}

						State = 111; Match(RightBrace);
						}
						break;
					}
					} 
				}
				State = 116;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,16,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 3: return pattern_sempred((PatternContext)_localctx, predIndex);
		}
		return true;
	}
	private bool pattern_sempred(PatternContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		case 2: return Precpred(Context, 9);
		case 3: return Precpred(Context, 8);
		case 4: return Precpred(Context, 7);
		case 5: return Precpred(Context, 6);
		case 6: return Precpred(Context, 5);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x1Bx\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x3\x2\x3\x2\a\x2\r\n\x2\f\x2\xE\x2\x10"+
		"\v\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\a\x3\x19\n\x3\f\x3\xE"+
		"\x3\x1C\v\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3\"\n\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x5\x3)\n\x3\x3\x4\x3\x4\x3\x4\x5\x4.\n\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\a\x4\x36\n\x4\f\x4\xE\x4\x39\v\x4\x3\x4\x5\x4<\n\x4"+
		"\x5\x4>\n\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5O\n\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x5\x5\x62\n\x5\x5\x5\x64\n\x5\x5\x5\x66\n\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x5\x5n\n\x5\x5\x5p\n\x5\x3\x5\a\x5s\n\x5\f\x5\xE"+
		"\x5v\v\x5\x3\x5\x2\x3\b\x6\x2\x4\x6\b\x2\x2\x8E\x2\xE\x3\x2\x2\x2\x4("+
		"\x3\x2\x2\x2\x6*\x3\x2\x2\x2\bN\x3\x2\x2\x2\n\r\x5\x4\x3\x2\v\r\x5\x6"+
		"\x4\x2\f\n\x3\x2\x2\x2\f\v\x3\x2\x2\x2\r\x10\x3\x2\x2\x2\xE\f\x3\x2\x2"+
		"\x2\xE\xF\x3\x2\x2\x2\xF\x3\x3\x2\x2\x2\x10\xE\x3\x2\x2\x2\x11\x12\a\x5"+
		"\x2\x2\x12\x13\a\x18\x2\x2\x13)\a\x15\x2\x2\x14\x15\a\x6\x2\x2\x15\x1A"+
		"\a\x18\x2\x2\x16\x17\a\v\x2\x2\x17\x19\a\x18\x2\x2\x18\x16\x3\x2\x2\x2"+
		"\x19\x1C\x3\x2\x2\x2\x1A\x18\x3\x2\x2\x2\x1A\x1B\x3\x2\x2\x2\x1B\x1D\x3"+
		"\x2\x2\x2\x1C\x1A\x3\x2\x2\x2\x1D)\a\x15\x2\x2\x1E!\a\a\x2\x2\x1F \a\x18"+
		"\x2\x2 \"\a\f\x2\x2!\x1F\x3\x2\x2\x2!\"\x3\x2\x2\x2\"#\x3\x2\x2\x2#$\a"+
		"\x18\x2\x2$)\a\x15\x2\x2%&\a\b\x2\x2&\'\a\x18\x2\x2\')\a\x15\x2\x2(\x11"+
		"\x3\x2\x2\x2(\x14\x3\x2\x2\x2(\x1E\x3\x2\x2\x2(%\x3\x2\x2\x2)\x5\x3\x2"+
		"\x2\x2*-\a\x18\x2\x2+,\a\t\x2\x2,.\a\x18\x2\x2-+\x3\x2\x2\x2-.\x3\x2\x2"+
		"\x2.=\x3\x2\x2\x2/\x30\a\f\x2\x2\x30;\x5\b\x5\x2\x31\x32\a\x13\x2\x2\x32"+
		"\x37\a\x18\x2\x2\x33\x34\a\x16\x2\x2\x34\x36\a\x18\x2\x2\x35\x33\x3\x2"+
		"\x2\x2\x36\x39\x3\x2\x2\x2\x37\x35\x3\x2\x2\x2\x37\x38\x3\x2\x2\x2\x38"+
		":\x3\x2\x2\x2\x39\x37\x3\x2\x2\x2:<\a\x14\x2\x2;\x31\x3\x2\x2\x2;<\x3"+
		"\x2\x2\x2<>\x3\x2\x2\x2=/\x3\x2\x2\x2=>\x3\x2\x2\x2>?\x3\x2\x2\x2?@\a"+
		"\x15\x2\x2@\a\x3\x2\x2\x2\x41\x42\b\x5\x1\x2\x42\x43\a\x18\x2\x2\x43\x44"+
		"\a\t\x2\x2\x44O\x5\b\x5\f\x45\x46\a\x11\x2\x2\x46G\x5\b\x5\x2GH\a\x12"+
		"\x2\x2HO\x3\x2\x2\x2IJ\a\x18\x2\x2JK\a\n\x2\x2KO\a\x18\x2\x2LO\a\x18\x2"+
		"\x2MO\a\x19\x2\x2N\x41\x3\x2\x2\x2N\x45\x3\x2\x2\x2NI\x3\x2\x2\x2NL\x3"+
		"\x2\x2\x2NM\x3\x2\x2\x2Ot\x3\x2\x2\x2PQ\f\x6\x2\x2Qs\x5\b\x5\aRS\f\x5"+
		"\x2\x2ST\a\r\x2\x2Ts\x5\b\x5\x6UV\f\v\x2\x2Vs\a\xE\x2\x2WX\f\n\x2\x2X"+
		"s\a\xF\x2\x2YZ\f\t\x2\x2Zs\a\x10\x2\x2[\\\f\b\x2\x2\\]\a\x13\x2\x2]\x65"+
		"\a\x19\x2\x2^\x63\a\x17\x2\x2_\x61\a\x16\x2\x2`\x62\a\x17\x2\x2\x61`\x3"+
		"\x2\x2\x2\x61\x62\x3\x2\x2\x2\x62\x64\x3\x2\x2\x2\x63_\x3\x2\x2\x2\x63"+
		"\x64\x3\x2\x2\x2\x64\x66\x3\x2\x2\x2\x65^\x3\x2\x2\x2\x65\x66\x3\x2\x2"+
		"\x2\x66g\x3\x2\x2\x2gs\a\x14\x2\x2hi\f\a\x2\x2ij\a\x13\x2\x2jo\a\x17\x2"+
		"\x2km\a\x16\x2\x2ln\a\x17\x2\x2ml\x3\x2\x2\x2mn\x3\x2\x2\x2np\x3\x2\x2"+
		"\x2ok\x3\x2\x2\x2op\x3\x2\x2\x2pq\x3\x2\x2\x2qs\a\x14\x2\x2rP\x3\x2\x2"+
		"\x2rR\x3\x2\x2\x2rU\x3\x2\x2\x2rW\x3\x2\x2\x2rY\x3\x2\x2\x2r[\x3\x2\x2"+
		"\x2rh\x3\x2\x2\x2sv\x3\x2\x2\x2tr\x3\x2\x2\x2tu\x3\x2\x2\x2u\t\x3\x2\x2"+
		"\x2vt\x3\x2\x2\x2\x13\f\xE\x1A!(-\x37;=N\x61\x63\x65mort";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace PreAdamant.Compiler.Tools.Parse
