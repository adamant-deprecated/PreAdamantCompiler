//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from PreAdamantParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PreAdamant.Compiler.Parser {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PreAdamantParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface IPreAdamantParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] PreAdamantParser.CompilationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.usingDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsingDirective([NotNull] PreAdamantParser.UsingDirectiveContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] PreAdamantParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceName([NotNull] PreAdamantParser.NamespaceNameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NamespaceDeclaration</c>
	/// labeled alternative in <see cref="PreAdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceDeclaration([NotNull] PreAdamantParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ClassDeclaration</c>
	/// labeled alternative in <see cref="PreAdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclaration([NotNull] PreAdamantParser.ClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StructDeclaration</c>
	/// labeled alternative in <see cref="PreAdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructDeclaration([NotNull] PreAdamantParser.StructDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclaration</c>
	/// labeled alternative in <see cref="PreAdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] PreAdamantParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionDeclaration</c>
	/// labeled alternative in <see cref="PreAdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclaration([NotNull] PreAdamantParser.FunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExternalDeclaration</c>
	/// labeled alternative in <see cref="PreAdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExternalDeclaration([NotNull] PreAdamantParser.ExternalDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Precondition</c>
	/// labeled alternative in <see cref="PreAdamantParser.contract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrecondition([NotNull] PreAdamantParser.PreconditionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Postcondition</c>
	/// labeled alternative in <see cref="PreAdamantParser.contract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostcondition([NotNull] PreAdamantParser.PostconditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttribute([NotNull] PreAdamantParser.AttributeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.baseTypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBaseTypes([NotNull] PreAdamantParser.BaseTypesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.accessModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessModifier([NotNull] PreAdamantParser.AccessModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.safetyModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSafetyModifier([NotNull] PreAdamantParser.SafetyModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.classInheritanceModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassInheritanceModifier([NotNull] PreAdamantParser.ClassInheritanceModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.methodInheritanceModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodInheritanceModifier([NotNull] PreAdamantParser.MethodInheritanceModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.conversionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConversionModifier([NotNull] PreAdamantParser.ConversionModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.asyncModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsyncModifier([NotNull] PreAdamantParser.AsyncModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.typeParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameters([NotNull] PreAdamantParser.TypeParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameter([NotNull] PreAdamantParser.TypeParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeArguments([NotNull] PreAdamantParser.TypeArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.identifierOrPredefinedType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierOrPredefinedType([NotNull] PreAdamantParser.IdentifierOrPredefinedTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IdentifierName</c>
	/// labeled alternative in <see cref="PreAdamantParser.simpleName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierName([NotNull] PreAdamantParser.IdentifierNameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GenericName</c>
	/// labeled alternative in <see cref="PreAdamantParser.simpleName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericName([NotNull] PreAdamantParser.GenericNameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnqualifiedName</c>
	/// labeled alternative in <see cref="PreAdamantParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnqualifiedName([NotNull] PreAdamantParser.UnqualifiedNameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>QualifiedName</c>
	/// labeled alternative in <see cref="PreAdamantParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualifiedName([NotNull] PreAdamantParser.QualifiedNameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NamedType</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamedType([NotNull] PreAdamantParser.NamedTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionType</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionType([NotNull] PreAdamantParser.FunctionTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TupleType</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTupleType([NotNull] PreAdamantParser.TupleTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MaybeType</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMaybeType([NotNull] PreAdamantParser.MaybeTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PointerType</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointerType([NotNull] PreAdamantParser.PointerTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LifetimeType</c>
	/// labeled alternative in <see cref="PreAdamantParser.valueType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLifetimeType([NotNull] PreAdamantParser.LifetimeTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OwnedType</c>
	/// labeled alternative in <see cref="PreAdamantParser.valueType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOwnedType([NotNull] PreAdamantParser.OwnedTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RefType</c>
	/// labeled alternative in <see cref="PreAdamantParser.valueType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRefType([NotNull] PreAdamantParser.RefTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] PreAdamantParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.returnType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnType([NotNull] PreAdamantParser.ReturnTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.lifetime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLifetime([NotNull] PreAdamantParser.LifetimeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.funcTypeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncTypeParameterList([NotNull] PreAdamantParser.FuncTypeParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.funcTypeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncTypeParameter([NotNull] PreAdamantParser.FuncTypeParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.constExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstExpression([NotNull] PreAdamantParser.ConstExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.typeParameterConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameterConstraintClause([NotNull] PreAdamantParser.TypeParameterConstraintClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConstructorConstraint</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorConstraint([NotNull] PreAdamantParser.ConstructorConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TypeConstraint</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeConstraint([NotNull] PreAdamantParser.TypeConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TypeListParameterConstraint</c>
	/// labeled alternative in <see cref="PreAdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeListParameterConstraint([NotNull] PreAdamantParser.TypeListParameterConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Constructor</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructor([NotNull] PreAdamantParser.ConstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Destructor</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDestructor([NotNull] PreAdamantParser.DestructorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConversionMethod</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConversionMethod([NotNull] PreAdamantParser.ConversionMethodContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Field</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitField([NotNull] PreAdamantParser.FieldContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Accessor</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAccessor([NotNull] PreAdamantParser.AccessorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Indexer</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexer([NotNull] PreAdamantParser.IndexerContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Method</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethod([NotNull] PreAdamantParser.MethodContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OperatorOverload</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorOverload([NotNull] PreAdamantParser.OperatorOverloadContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NestedClassDeclaration</c>
	/// labeled alternative in <see cref="PreAdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNestedClassDeclaration([NotNull] PreAdamantParser.NestedClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] PreAdamantParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>namedParameter</c>
	/// labeled alternative in <see cref="PreAdamantParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamedParameter([NotNull] PreAdamantParser.NamedParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>selfParameter</c>
	/// labeled alternative in <see cref="PreAdamantParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelfParameter([NotNull] PreAdamantParser.SelfParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.parameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterModifier([NotNull] PreAdamantParser.ParameterModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.constructorInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorInitializer([NotNull] PreAdamantParser.ConstructorInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentList([NotNull] PreAdamantParser.ArgumentListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BlockMethodBody</c>
	/// labeled alternative in <see cref="PreAdamantParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockMethodBody([NotNull] PreAdamantParser.BlockMethodBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NoMethodBody</c>
	/// labeled alternative in <see cref="PreAdamantParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoMethodBody([NotNull] PreAdamantParser.NoMethodBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.overloadableOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOverloadableOperator([NotNull] PreAdamantParser.OverloadableOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarationStatement([NotNull] PreAdamantParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnsafeBlockStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsafeBlockStatement([NotNull] PreAdamantParser.UnsafeBlockStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BlockStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockStatement([NotNull] PreAdamantParser.BlockStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EmptyStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyStatement([NotNull] PreAdamantParser.EmptyStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionStatement([NotNull] PreAdamantParser.ExpressionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] PreAdamantParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ThrowStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThrowStatement([NotNull] PreAdamantParser.ThrowStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] PreAdamantParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LetIfStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetIfStatement([NotNull] PreAdamantParser.LetIfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] PreAdamantParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] PreAdamantParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DeleteStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeleteStatement([NotNull] PreAdamantParser.DeleteStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ContinueStatement</c>
	/// labeled alternative in <see cref="PreAdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContinueStatement([NotNull] PreAdamantParser.ContinueStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PreAdamantParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLocalVariableDeclaration([NotNull] PreAdamantParser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NullCheckExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNullCheckExpression([NotNull] PreAdamantParser.NullCheckExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StringLiteralExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringLiteralExpression([NotNull] PreAdamantParser.StringLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>XorExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXorExpression([NotNull] PreAdamantParser.XorExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NameExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNameExpression([NotNull] PreAdamantParser.NameExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>InExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInExpression([NotNull] PreAdamantParser.InExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] PreAdamantParser.UnaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OrExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpression([NotNull] PreAdamantParser.OrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IntLiteralExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntLiteralExpression([NotNull] PreAdamantParser.IntLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NewObjectExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewObjectExpression([NotNull] PreAdamantParser.NewObjectExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AndExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpression([NotNull] PreAdamantParser.AndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentExpression([NotNull] PreAdamantParser.AssignmentExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SelfExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelfExpression([NotNull] PreAdamantParser.SelfExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BooleanLiteralExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanLiteralExpression([NotNull] PreAdamantParser.BooleanLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EqualityExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualityExpression([NotNull] PreAdamantParser.EqualityExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] PreAdamantParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallExpression([NotNull] PreAdamantParser.CallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NullLiteralExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNullLiteralExpression([NotNull] PreAdamantParser.NullLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] PreAdamantParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] PreAdamantParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfExpression([NotNull] PreAdamantParser.IfExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExpression([NotNull] PreAdamantParser.NewExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UninitializedExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUninitializedExpression([NotNull] PreAdamantParser.UninitializedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TryExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTryExpression([NotNull] PreAdamantParser.TryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MagnitudeExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMagnitudeExpression([NotNull] PreAdamantParser.MagnitudeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MemberExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberExpression([NotNull] PreAdamantParser.MemberExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ComparativeExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparativeExpression([NotNull] PreAdamantParser.ComparativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CastExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCastExpression([NotNull] PreAdamantParser.CastExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CharLiteralExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharLiteralExpression([NotNull] PreAdamantParser.CharLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DotDotExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDotDotExpression([NotNull] PreAdamantParser.DotDotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LambdaExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaExpression([NotNull] PreAdamantParser.LambdaExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CoalesceExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCoalesceExpression([NotNull] PreAdamantParser.CoalesceExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ArrayAccessExpression</c>
	/// labeled alternative in <see cref="PreAdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAccessExpression([NotNull] PreAdamantParser.ArrayAccessExpressionContext context);
}
} // namespace PreAdamant.Compiler.Parser
