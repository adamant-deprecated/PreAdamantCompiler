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

namespace PreAdamant.Compiler.Syntax.Antlr {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PreAdamantParser_Antlr"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface IPreAdamantParser_AntlrListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] PreAdamantParser_Antlr.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] PreAdamantParser_Antlr.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.usingDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingDirective([NotNull] PreAdamantParser_Antlr.UsingDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.usingDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingDirective([NotNull] PreAdamantParser_Antlr.UsingDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] PreAdamantParser_Antlr.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] PreAdamantParser_Antlr.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceName([NotNull] PreAdamantParser_Antlr.NamespaceNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceName([NotNull] PreAdamantParser_Antlr.NamespaceNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PreAdamantParser_Antlr.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] PreAdamantParser_Antlr.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PreAdamantParser_Antlr.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] PreAdamantParser_Antlr.DeclarationContext context);
}
} // namespace PreAdamant.Compiler.Syntax.Antlr