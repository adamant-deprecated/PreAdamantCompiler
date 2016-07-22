using System.Linq;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	internal partial class PreAdamantSyntaxTransformer : IPreAdamantParser_AntlrVisitor<ISyntax>
	{
		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCompilationUnit(PreAdamantParser_Antlr.CompilationUnitContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new CompilationUnitSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUsingDirective(PreAdamantParser_Antlr.UsingDirectiveContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new UsingDirectiveSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIdentifier(PreAdamantParser_Antlr.IdentifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new IdentifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamespaceName(PreAdamantParser_Antlr.NamespaceNameContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NamespaceNameSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamespaceDeclaration(PreAdamantParser_Antlr.NamespaceDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NamespaceDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitClassDeclaration(PreAdamantParser_Antlr.ClassDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ClassDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitStructDeclaration(PreAdamantParser_Antlr.StructDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new StructDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitVariableDeclaration(PreAdamantParser_Antlr.VariableDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new VariableDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFunctionDeclaration(PreAdamantParser_Antlr.FunctionDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new FunctionDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitExternalBlockDeclaration(PreAdamantParser_Antlr.ExternalBlockDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ExternalBlockDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPrecondition(PreAdamantParser_Antlr.PreconditionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new PreconditionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPostcondition(PreAdamantParser_Antlr.PostconditionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new PostconditionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAttribute(PreAdamantParser_Antlr.AttributeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AttributeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBaseTypes(PreAdamantParser_Antlr.BaseTypesContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new BaseTypesSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAccessModifier(PreAdamantParser_Antlr.AccessModifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AccessModifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitSafetyModifier(PreAdamantParser_Antlr.SafetyModifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new SafetyModifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitClassInheritanceModifier(PreAdamantParser_Antlr.ClassInheritanceModifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ClassInheritanceModifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMethodInheritanceModifier(PreAdamantParser_Antlr.MethodInheritanceModifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new MethodInheritanceModifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitExplicitModifier(PreAdamantParser_Antlr.ExplicitModifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ExplicitModifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAsyncModifier(PreAdamantParser_Antlr.AsyncModifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AsyncModifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeParameters(PreAdamantParser_Antlr.TypeParametersContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TypeParametersSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeParameter(PreAdamantParser_Antlr.TypeParameterContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TypeParameterSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeArguments(PreAdamantParser_Antlr.TypeArgumentsContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TypeArgumentsSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIdentifierOrPredefinedType(PreAdamantParser_Antlr.IdentifierOrPredefinedTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new IdentifierOrPredefinedTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIdentifierName(PreAdamantParser_Antlr.IdentifierNameContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new IdentifierNameSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitGenericName(PreAdamantParser_Antlr.GenericNameContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new GenericNameSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnqualifiedName(PreAdamantParser_Antlr.UnqualifiedNameContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new UnqualifiedNameSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitQualifiedName(PreAdamantParser_Antlr.QualifiedNameContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new QualifiedNameSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamedType(PreAdamantParser_Antlr.NamedTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NamedTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMaybeType(PreAdamantParser_Antlr.MaybeTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new MaybeTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPointerType(PreAdamantParser_Antlr.PointerTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new PointerTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTupleType(PreAdamantParser_Antlr.TupleTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TupleTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFunctionType(PreAdamantParser_Antlr.FunctionTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new FunctionTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLifetimeType(PreAdamantParser_Antlr.LifetimeTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new LifetimeTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitRefType(PreAdamantParser_Antlr.RefTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new RefTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitType(PreAdamantParser_Antlr.TypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitReturnType(PreAdamantParser_Antlr.ReturnTypeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ReturnTypeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLifetime(PreAdamantParser_Antlr.LifetimeContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new LifetimeSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFuncTypeParameterList(PreAdamantParser_Antlr.FuncTypeParameterListContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new FuncTypeParameterListSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFuncTypeParameter(PreAdamantParser_Antlr.FuncTypeParameterContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new FuncTypeParameterSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstExpression(PreAdamantParser_Antlr.ConstExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ConstExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeParameterConstraintClause(PreAdamantParser_Antlr.TypeParameterConstraintClauseContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TypeParameterConstraintClauseSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstructorConstraint(PreAdamantParser_Antlr.ConstructorConstraintContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ConstructorConstraintSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeConstraint(PreAdamantParser_Antlr.TypeConstraintContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TypeConstraintSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeListParameterConstraint(PreAdamantParser_Antlr.TypeListParameterConstraintContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TypeListParameterConstraintSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstructor(PreAdamantParser_Antlr.ConstructorContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ConstructorSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCopyConstructor(PreAdamantParser_Antlr.CopyConstructorContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new CopyConstructorSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDestructor(PreAdamantParser_Antlr.DestructorContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new DestructorSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConversionMethod(PreAdamantParser_Antlr.ConversionMethodContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ConversionMethodSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitField(PreAdamantParser_Antlr.FieldContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new FieldSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAccessor(PreAdamantParser_Antlr.AccessorContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AccessorSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIndexer(PreAdamantParser_Antlr.IndexerContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new IndexerSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMethod(PreAdamantParser_Antlr.MethodContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new MethodSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitOperatorOverload(PreAdamantParser_Antlr.OperatorOverloadContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new OperatorOverloadSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNestedClassDeclaration(PreAdamantParser_Antlr.NestedClassDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NestedClassDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitParameterList(PreAdamantParser_Antlr.ParameterListContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ParameterListSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamedParameter(PreAdamantParser_Antlr.NamedParameterContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NamedParameterSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitSelfParameter(PreAdamantParser_Antlr.SelfParameterContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new SelfParameterSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitParameterModifier(PreAdamantParser_Antlr.ParameterModifierContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ParameterModifierSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitWhereClause(PreAdamantParser_Antlr.WhereClauseContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new WhereClauseSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitGenericConstraint(PreAdamantParser_Antlr.GenericConstraintContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new GenericConstraintSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstructorInitializer(PreAdamantParser_Antlr.ConstructorInitializerContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ConstructorInitializerSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitArgumentList(PreAdamantParser_Antlr.ArgumentListContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ArgumentListSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBlockMethodBody(PreAdamantParser_Antlr.BlockMethodBodyContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new BlockMethodBodySyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNoMethodBody(PreAdamantParser_Antlr.NoMethodBodyContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NoMethodBodySyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitOverloadableOperator(PreAdamantParser_Antlr.OverloadableOperatorContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new OverloadableOperatorSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitVariableDeclarationStatement(PreAdamantParser_Antlr.VariableDeclarationStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new VariableDeclarationStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnsafeBlockStatement(PreAdamantParser_Antlr.UnsafeBlockStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new UnsafeBlockStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBlockStatement(PreAdamantParser_Antlr.BlockStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new BlockStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitEmptyStatement(PreAdamantParser_Antlr.EmptyStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new EmptyStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitExpressionStatement(PreAdamantParser_Antlr.ExpressionStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ExpressionStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitReturnStatement(PreAdamantParser_Antlr.ReturnStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ReturnStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitThrowStatement(PreAdamantParser_Antlr.ThrowStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ThrowStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIfStatement(PreAdamantParser_Antlr.IfStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new IfStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLetIfStatement(PreAdamantParser_Antlr.LetIfStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new LetIfStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitForStatement(PreAdamantParser_Antlr.ForStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ForStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitWhileStatement(PreAdamantParser_Antlr.WhileStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new WhileStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDeleteStatement(PreAdamantParser_Antlr.DeleteStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new DeleteStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitContinueStatement(PreAdamantParser_Antlr.ContinueStatementContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ContinueStatementSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLocalVariableDeclaration(PreAdamantParser_Antlr.LocalVariableDeclarationContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new LocalVariableDeclarationSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitParenthesizedExpression(PreAdamantParser_Antlr.ParenthesizedExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ParenthesizedExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMagnitudeExpression(PreAdamantParser_Antlr.MagnitudeExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new MagnitudeExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMemberExpression(PreAdamantParser_Antlr.MemberExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new MemberExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPlacementDeleteExpression(PreAdamantParser_Antlr.PlacementDeleteExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new PlacementDeleteExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDotDotExpression(PreAdamantParser_Antlr.DotDotExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new DotDotExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitToExpression(PreAdamantParser_Antlr.ToExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ToExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCallExpression(PreAdamantParser_Antlr.CallExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new CallExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitArrayAccessExpression(PreAdamantParser_Antlr.ArrayAccessExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ArrayAccessExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAwaitExpression(PreAdamantParser_Antlr.AwaitExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AwaitExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNullCheckExpression(PreAdamantParser_Antlr.NullCheckExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NullCheckExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnaryExpression(PreAdamantParser_Antlr.UnaryExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new UnaryExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMultiplicativeExpression(PreAdamantParser_Antlr.MultiplicativeExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new MultiplicativeExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAdditiveExpression(PreAdamantParser_Antlr.AdditiveExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AdditiveExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitComparativeExpression(PreAdamantParser_Antlr.ComparativeExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new ComparativeExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitEqualityExpression(PreAdamantParser_Antlr.EqualityExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new EqualityExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAndExpression(PreAdamantParser_Antlr.AndExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AndExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitXorExpression(PreAdamantParser_Antlr.XorExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new XorExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitOrExpression(PreAdamantParser_Antlr.OrExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new OrExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCoalesceExpression(PreAdamantParser_Antlr.CoalesceExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new CoalesceExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitInExpression(PreAdamantParser_Antlr.InExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new InExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNewExpression(PreAdamantParser_Antlr.NewExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NewExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNewMemoryExpression(PreAdamantParser_Antlr.NewMemoryExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NewMemoryExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNewObjectExpression(PreAdamantParser_Antlr.NewObjectExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NewObjectExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDeleteMemoryExpression(PreAdamantParser_Antlr.DeleteMemoryExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new DeleteMemoryExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCastExpression(PreAdamantParser_Antlr.CastExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new CastExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTryExpression(PreAdamantParser_Antlr.TryExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new TryExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIfExpression(PreAdamantParser_Antlr.IfExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new IfExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAssignmentExpression(PreAdamantParser_Antlr.AssignmentExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new AssignmentExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLambdaExpression(PreAdamantParser_Antlr.LambdaExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new LambdaExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNameExpression(PreAdamantParser_Antlr.NameExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NameExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNullLiteralExpression(PreAdamantParser_Antlr.NullLiteralExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new NullLiteralExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitSelfExpression(PreAdamantParser_Antlr.SelfExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new SelfExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBooleanLiteralExpression(PreAdamantParser_Antlr.BooleanLiteralExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new BooleanLiteralExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIntLiteralExpression(PreAdamantParser_Antlr.IntLiteralExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new IntLiteralExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUninitializedExpression(PreAdamantParser_Antlr.UninitializedExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new UninitializedExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitStringLiteralExpression(PreAdamantParser_Antlr.StringLiteralExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new StringLiteralExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCharLiteralExpression(PreAdamantParser_Antlr.CharLiteralExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new CharLiteralExpressionSyntax(allChildren);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnsafeExpression(PreAdamantParser_Antlr.UnsafeExpressionContext context)
		{
			var children = context.children.Select(c => c.Accept(this)).ToList();
			var allChildren = InterleaveTriva(children);
			return new UnsafeExpressionSyntax(allChildren);
		}

	}
}
