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

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPreAdamantParser_AntlrListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class PreAdamantParser_AntlrBaseListener : IPreAdamantParser_AntlrListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompilationUnit([NotNull] PreAdamantParser_Antlr.CompilationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompilationUnit([NotNull] PreAdamantParser_Antlr.CompilationUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.usingDirective"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsingDirective([NotNull] PreAdamantParser_Antlr.UsingDirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.usingDirective"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsingDirective([NotNull] PreAdamantParser_Antlr.UsingDirectiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] PreAdamantParser_Antlr.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] PreAdamantParser_Antlr.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.namespaceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespaceName([NotNull] PreAdamantParser_Antlr.NamespaceNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.namespaceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespaceName([NotNull] PreAdamantParser_Antlr.NamespaceNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] PreAdamantParser_Antlr.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] PreAdamantParser_Antlr.DeclarationContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace PreAdamant.Compiler.Parser.Antlr
