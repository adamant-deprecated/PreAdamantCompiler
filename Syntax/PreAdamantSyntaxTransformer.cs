using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	internal partial class PreAdamantSyntaxTransformer : IPreAdamantParser_AntlrVisitor<ISyntaxNode>
	{
		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitCompilationUnit(PreAdamantParser_Antlr.CompilationUnitContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CompilationUnitSyntax(context, allChildren) : new CompilationUnitSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitUsingDirective(PreAdamantParser_Antlr.UsingDirectiveContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UsingDirectiveSyntax(context, allChildren) : new UsingDirectiveSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitIdentifier(PreAdamantParser_Antlr.IdentifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IdentifierSyntax(context, allChildren) : new IdentifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNamespaceName(PreAdamantParser_Antlr.NamespaceNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamespaceNameSyntax(context, allChildren) : new NamespaceNameSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNamespaceDeclaration(PreAdamantParser_Antlr.NamespaceDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamespaceDeclarationSyntax(context, allChildren) : new NamespaceDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitClassDeclaration(PreAdamantParser_Antlr.ClassDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ClassDeclarationSyntax(context, allChildren) : new ClassDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitStructDeclaration(PreAdamantParser_Antlr.StructDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new StructDeclarationSyntax(context, allChildren) : new StructDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitVariableDeclaration(PreAdamantParser_Antlr.VariableDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new VariableDeclarationSyntax(context, allChildren) : new VariableDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitFunctionDeclaration(PreAdamantParser_Antlr.FunctionDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FunctionDeclarationSyntax(context, allChildren) : new FunctionDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitExternalBlockDeclaration(PreAdamantParser_Antlr.ExternalBlockDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ExternalBlockDeclarationSyntax(context, allChildren) : new ExternalBlockDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitPrecondition(PreAdamantParser_Antlr.PreconditionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PreconditionSyntax(context, allChildren) : new PreconditionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitPostcondition(PreAdamantParser_Antlr.PostconditionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PostconditionSyntax(context, allChildren) : new PostconditionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAttribute(PreAdamantParser_Antlr.AttributeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AttributeSyntax(context, allChildren) : new AttributeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitBaseTypes(PreAdamantParser_Antlr.BaseTypesContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BaseTypesSyntax(context, allChildren) : new BaseTypesSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAccessModifier(PreAdamantParser_Antlr.AccessModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AccessModifierSyntax(context, allChildren) : new AccessModifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitSafetyModifier(PreAdamantParser_Antlr.SafetyModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new SafetyModifierSyntax(context, allChildren) : new SafetyModifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitClassInheritanceModifier(PreAdamantParser_Antlr.ClassInheritanceModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ClassInheritanceModifierSyntax(context, allChildren) : new ClassInheritanceModifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitMethodInheritanceModifier(PreAdamantParser_Antlr.MethodInheritanceModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MethodInheritanceModifierSyntax(context, allChildren) : new MethodInheritanceModifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitExplicitModifier(PreAdamantParser_Antlr.ExplicitModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ExplicitModifierSyntax(context, allChildren) : new ExplicitModifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAsyncModifier(PreAdamantParser_Antlr.AsyncModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AsyncModifierSyntax(context, allChildren) : new AsyncModifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTypeParameters(PreAdamantParser_Antlr.TypeParametersContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeParametersSyntax(context, allChildren) : new TypeParametersSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTypeParameter(PreAdamantParser_Antlr.TypeParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeParameterSyntax(context, allChildren) : new TypeParameterSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTypeArguments(PreAdamantParser_Antlr.TypeArgumentsContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeArgumentsSyntax(context, allChildren) : new TypeArgumentsSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitIdentifierOrPredefinedType(PreAdamantParser_Antlr.IdentifierOrPredefinedTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IdentifierOrPredefinedTypeSyntax(context, allChildren) : new IdentifierOrPredefinedTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitIdentifierName(PreAdamantParser_Antlr.IdentifierNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IdentifierNameSyntax(context, allChildren) : new IdentifierNameSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitGenericName(PreAdamantParser_Antlr.GenericNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new GenericNameSyntax(context, allChildren) : new GenericNameSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitUnqualifiedName(PreAdamantParser_Antlr.UnqualifiedNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnqualifiedNameSyntax(context, allChildren) : new UnqualifiedNameSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitQualifiedName(PreAdamantParser_Antlr.QualifiedNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new QualifiedNameSyntax(context, allChildren) : new QualifiedNameSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNamedType(PreAdamantParser_Antlr.NamedTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamedTypeSyntax(context, allChildren) : new NamedTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitMaybeType(PreAdamantParser_Antlr.MaybeTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MaybeTypeSyntax(context, allChildren) : new MaybeTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitPointerType(PreAdamantParser_Antlr.PointerTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PointerTypeSyntax(context, allChildren) : new PointerTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTupleType(PreAdamantParser_Antlr.TupleTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TupleTypeSyntax(context, allChildren) : new TupleTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitFunctionType(PreAdamantParser_Antlr.FunctionTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FunctionTypeSyntax(context, allChildren) : new FunctionTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitLifetimeType(PreAdamantParser_Antlr.LifetimeTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LifetimeTypeSyntax(context, allChildren) : new LifetimeTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitRefType(PreAdamantParser_Antlr.RefTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new RefTypeSyntax(context, allChildren) : new RefTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitType(PreAdamantParser_Antlr.TypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeSyntax(context, allChildren) : new TypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitReturnType(PreAdamantParser_Antlr.ReturnTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ReturnTypeSyntax(context, allChildren) : new ReturnTypeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitLifetime(PreAdamantParser_Antlr.LifetimeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LifetimeSyntax(context, allChildren) : new LifetimeSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitFuncTypeParameterList(PreAdamantParser_Antlr.FuncTypeParameterListContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FuncTypeParameterListSyntax(context, allChildren) : new FuncTypeParameterListSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitFuncTypeParameter(PreAdamantParser_Antlr.FuncTypeParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FuncTypeParameterSyntax(context, allChildren) : new FuncTypeParameterSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitConstExpression(PreAdamantParser_Antlr.ConstExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstExpressionSyntax(context, allChildren) : new ConstExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTypeParameterBoundConstraintClause(PreAdamantParser_Antlr.TypeParameterBoundConstraintClauseContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeParameterBoundConstraintClauseSyntax(context, allChildren) : new TypeParameterBoundConstraintClauseSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTypeParameterRangeConstraintClause(PreAdamantParser_Antlr.TypeParameterRangeConstraintClauseContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeParameterRangeConstraintClauseSyntax(context, allChildren) : new TypeParameterRangeConstraintClauseSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitConstructorConstraint(PreAdamantParser_Antlr.ConstructorConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstructorConstraintSyntax(context, allChildren) : new ConstructorConstraintSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTypeConstraint(PreAdamantParser_Antlr.TypeConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeConstraintSyntax(context, allChildren) : new TypeConstraintSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTypeListParameterConstraint(PreAdamantParser_Antlr.TypeListParameterConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeListParameterConstraintSyntax(context, allChildren) : new TypeListParameterConstraintSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitConstructor(PreAdamantParser_Antlr.ConstructorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstructorSyntax(context, allChildren) : new ConstructorSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitCopyConstructor(PreAdamantParser_Antlr.CopyConstructorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CopyConstructorSyntax(context, allChildren) : new CopyConstructorSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitDestructor(PreAdamantParser_Antlr.DestructorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DestructorSyntax(context, allChildren) : new DestructorSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitConversionMethod(PreAdamantParser_Antlr.ConversionMethodContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConversionMethodSyntax(context, allChildren) : new ConversionMethodSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitField(PreAdamantParser_Antlr.FieldContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FieldSyntax(context, allChildren) : new FieldSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAccessor(PreAdamantParser_Antlr.AccessorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AccessorSyntax(context, allChildren) : new AccessorSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitIndexer(PreAdamantParser_Antlr.IndexerContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IndexerSyntax(context, allChildren) : new IndexerSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitMethod(PreAdamantParser_Antlr.MethodContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MethodSyntax(context, allChildren) : new MethodSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitOperatorOverload(PreAdamantParser_Antlr.OperatorOverloadContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new OperatorOverloadSyntax(context, allChildren) : new OperatorOverloadSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNestedClassDeclaration(PreAdamantParser_Antlr.NestedClassDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NestedClassDeclarationSyntax(context, allChildren) : new NestedClassDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitParameterList(PreAdamantParser_Antlr.ParameterListContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ParameterListSyntax(context, allChildren) : new ParameterListSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNamedParameter(PreAdamantParser_Antlr.NamedParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamedParameterSyntax(context, allChildren) : new NamedParameterSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitSelfParameter(PreAdamantParser_Antlr.SelfParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new SelfParameterSyntax(context, allChildren) : new SelfParameterSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitParameterModifier(PreAdamantParser_Antlr.ParameterModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ParameterModifierSyntax(context, allChildren) : new ParameterModifierSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitWhereClause(PreAdamantParser_Antlr.WhereClauseContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new WhereClauseSyntax(context, allChildren) : new WhereClauseSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitGenericConstraint(PreAdamantParser_Antlr.GenericConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new GenericConstraintSyntax(context, allChildren) : new GenericConstraintSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitConstructorInitializer(PreAdamantParser_Antlr.ConstructorInitializerContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstructorInitializerSyntax(context, allChildren) : new ConstructorInitializerSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitArgumentList(PreAdamantParser_Antlr.ArgumentListContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ArgumentListSyntax(context, allChildren) : new ArgumentListSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitBlockMethodBody(PreAdamantParser_Antlr.BlockMethodBodyContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BlockMethodBodySyntax(context, allChildren) : new BlockMethodBodySyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNoMethodBody(PreAdamantParser_Antlr.NoMethodBodyContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NoMethodBodySyntax(context, allChildren) : new NoMethodBodySyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitOverloadableOperator(PreAdamantParser_Antlr.OverloadableOperatorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new OverloadableOperatorSyntax(context, allChildren) : new OverloadableOperatorSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitBlock(PreAdamantParser_Antlr.BlockContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BlockSyntax(context, allChildren) : new BlockSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitVariableDeclarationStatement(PreAdamantParser_Antlr.VariableDeclarationStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new VariableDeclarationStatementSyntax(context, allChildren) : new VariableDeclarationStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitUnsafeBlockStatement(PreAdamantParser_Antlr.UnsafeBlockStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnsafeBlockStatementSyntax(context, allChildren) : new UnsafeBlockStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitBlockStatement(PreAdamantParser_Antlr.BlockStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BlockStatementSyntax(context, allChildren) : new BlockStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitEmptyStatement(PreAdamantParser_Antlr.EmptyStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new EmptyStatementSyntax(context, allChildren) : new EmptyStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitExpressionStatement(PreAdamantParser_Antlr.ExpressionStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ExpressionStatementSyntax(context, allChildren) : new ExpressionStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitReturnStatement(PreAdamantParser_Antlr.ReturnStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ReturnStatementSyntax(context, allChildren) : new ReturnStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitThrowStatement(PreAdamantParser_Antlr.ThrowStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ThrowStatementSyntax(context, allChildren) : new ThrowStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitIfStatement(PreAdamantParser_Antlr.IfStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IfStatementSyntax(context, allChildren) : new IfStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitLetIfStatement(PreAdamantParser_Antlr.LetIfStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LetIfStatementSyntax(context, allChildren) : new LetIfStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitForStatement(PreAdamantParser_Antlr.ForStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ForStatementSyntax(context, allChildren) : new ForStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitWhileStatement(PreAdamantParser_Antlr.WhileStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new WhileStatementSyntax(context, allChildren) : new WhileStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitDeleteStatement(PreAdamantParser_Antlr.DeleteStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DeleteStatementSyntax(context, allChildren) : new DeleteStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitContinueStatement(PreAdamantParser_Antlr.ContinueStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ContinueStatementSyntax(context, allChildren) : new ContinueStatementSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitSimpleLocalVariableDeclaration(PreAdamantParser_Antlr.SimpleLocalVariableDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new SimpleLocalVariableDeclarationSyntax(context, allChildren) : new SimpleLocalVariableDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitDestructureLocalVariableDeclaration(PreAdamantParser_Antlr.DestructureLocalVariableDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DestructureLocalVariableDeclarationSyntax(context, allChildren) : new DestructureLocalVariableDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitParenthesizedExpression(PreAdamantParser_Antlr.ParenthesizedExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ParenthesizedExpressionSyntax(context, allChildren) : new ParenthesizedExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitMagnitudeExpression(PreAdamantParser_Antlr.MagnitudeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MagnitudeExpressionSyntax(context, allChildren) : new MagnitudeExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitMemberExpression(PreAdamantParser_Antlr.MemberExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MemberExpressionSyntax(context, allChildren) : new MemberExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitPlacementDeleteExpression(PreAdamantParser_Antlr.PlacementDeleteExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PlacementDeleteExpressionSyntax(context, allChildren) : new PlacementDeleteExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitDotDotExpression(PreAdamantParser_Antlr.DotDotExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DotDotExpressionSyntax(context, allChildren) : new DotDotExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitToExpression(PreAdamantParser_Antlr.ToExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ToExpressionSyntax(context, allChildren) : new ToExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitCallExpression(PreAdamantParser_Antlr.CallExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CallExpressionSyntax(context, allChildren) : new CallExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitArrayAccessExpression(PreAdamantParser_Antlr.ArrayAccessExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ArrayAccessExpressionSyntax(context, allChildren) : new ArrayAccessExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAwaitExpression(PreAdamantParser_Antlr.AwaitExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AwaitExpressionSyntax(context, allChildren) : new AwaitExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNullCheckExpression(PreAdamantParser_Antlr.NullCheckExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NullCheckExpressionSyntax(context, allChildren) : new NullCheckExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitUnaryExpression(PreAdamantParser_Antlr.UnaryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnaryExpressionSyntax(context, allChildren) : new UnaryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitMultiplicativeExpression(PreAdamantParser_Antlr.MultiplicativeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MultiplicativeExpressionSyntax(context, allChildren) : new MultiplicativeExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAdditiveExpression(PreAdamantParser_Antlr.AdditiveExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AdditiveExpressionSyntax(context, allChildren) : new AdditiveExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitComparativeExpression(PreAdamantParser_Antlr.ComparativeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ComparativeExpressionSyntax(context, allChildren) : new ComparativeExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitEqualityExpression(PreAdamantParser_Antlr.EqualityExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new EqualityExpressionSyntax(context, allChildren) : new EqualityExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAndExpression(PreAdamantParser_Antlr.AndExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AndExpressionSyntax(context, allChildren) : new AndExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitXorExpression(PreAdamantParser_Antlr.XorExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new XorExpressionSyntax(context, allChildren) : new XorExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitOrExpression(PreAdamantParser_Antlr.OrExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new OrExpressionSyntax(context, allChildren) : new OrExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitCoalesceExpression(PreAdamantParser_Antlr.CoalesceExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CoalesceExpressionSyntax(context, allChildren) : new CoalesceExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitInExpression(PreAdamantParser_Antlr.InExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new InExpressionSyntax(context, allChildren) : new InExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNewExpression(PreAdamantParser_Antlr.NewExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NewExpressionSyntax(context, allChildren) : new NewExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNewMemoryExpression(PreAdamantParser_Antlr.NewMemoryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NewMemoryExpressionSyntax(context, allChildren) : new NewMemoryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNewObjectExpression(PreAdamantParser_Antlr.NewObjectExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NewObjectExpressionSyntax(context, allChildren) : new NewObjectExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitDeleteMemoryExpression(PreAdamantParser_Antlr.DeleteMemoryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DeleteMemoryExpressionSyntax(context, allChildren) : new DeleteMemoryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitCastExpression(PreAdamantParser_Antlr.CastExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CastExpressionSyntax(context, allChildren) : new CastExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitTryExpression(PreAdamantParser_Antlr.TryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TryExpressionSyntax(context, allChildren) : new TryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitIfExpression(PreAdamantParser_Antlr.IfExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IfExpressionSyntax(context, allChildren) : new IfExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitAssignmentExpression(PreAdamantParser_Antlr.AssignmentExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AssignmentExpressionSyntax(context, allChildren) : new AssignmentExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitLambdaExpression(PreAdamantParser_Antlr.LambdaExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LambdaExpressionSyntax(context, allChildren) : new LambdaExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNameExpression(PreAdamantParser_Antlr.NameExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NameExpressionSyntax(context, allChildren) : new NameExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitNullLiteralExpression(PreAdamantParser_Antlr.NullLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NullLiteralExpressionSyntax(context, allChildren) : new NullLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitSelfExpression(PreAdamantParser_Antlr.SelfExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new SelfExpressionSyntax(context, allChildren) : new SelfExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitBooleanLiteralExpression(PreAdamantParser_Antlr.BooleanLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BooleanLiteralExpressionSyntax(context, allChildren) : new BooleanLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitIntLiteralExpression(PreAdamantParser_Antlr.IntLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IntLiteralExpressionSyntax(context, allChildren) : new IntLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitUninitializedExpression(PreAdamantParser_Antlr.UninitializedExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UninitializedExpressionSyntax(context, allChildren) : new UninitializedExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitStringLiteralExpression(PreAdamantParser_Antlr.StringLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new StringLiteralExpressionSyntax(context, allChildren) : new StringLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitCharLiteralExpression(PreAdamantParser_Antlr.CharLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CharLiteralExpressionSyntax(context, allChildren) : new CharLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntaxNode IPreAdamantParser_AntlrVisitor<ISyntaxNode>.VisitUnsafeExpression(PreAdamantParser_Antlr.UnsafeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnsafeExpressionSyntax(context, allChildren) : new UnsafeExpressionSyntax(context.Start.StartIndex);
		}

	}
}
