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
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SpecParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface ISpecParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SpecParser.spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpec([NotNull] SpecParser.SpecContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NameDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNameDirective([NotNull] SpecParser.NameDirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NamespaceDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceDirective([NotNull] SpecParser.NamespaceDirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ImportDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportDirective([NotNull] SpecParser.ImportDirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StartRuleDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStartRuleDirective([NotNull] SpecParser.StartRuleDirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SpecParser.parseRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParseRule([NotNull] SpecParser.ParseRuleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralPattern([NotNull] SpecParser.LiteralPatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OptionalPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptionalPattern([NotNull] SpecParser.OptionalPatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RepeatWithSeparatorPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatWithSeparatorPattern([NotNull] SpecParser.RepeatWithSeparatorPatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ZeroOrMorePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitZeroOrMorePattern([NotNull] SpecParser.ZeroOrMorePatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GroupingPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupingPattern([NotNull] SpecParser.GroupingPatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ImportedRulePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportedRulePattern([NotNull] SpecParser.ImportedRulePatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConcatPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConcatPattern([NotNull] SpecParser.ConcatPatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OneOrMorePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOneOrMorePattern([NotNull] SpecParser.OneOrMorePatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RepeatPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatPattern([NotNull] SpecParser.RepeatPatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RulePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRulePattern([NotNull] SpecParser.RulePatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LabelPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabelPattern([NotNull] SpecParser.LabelPatternContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AlternationPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlternationPattern([NotNull] SpecParser.AlternationPatternContext context);
}
} // namespace PreAdamant.Compiler.Tools.Parse
