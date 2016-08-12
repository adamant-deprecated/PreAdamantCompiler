using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	internal partial class PreAdamantSyntaxTransformer : IPreAdamantParser_AntlrVisitor<ISyntax>
	{
		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCompilationUnit(PreAdamantParser_Antlr.CompilationUnitContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CompilationUnitSyntax(allChildren) : new CompilationUnitSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUsingDirective(PreAdamantParser_Antlr.UsingDirectiveContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UsingDirectiveSyntax(allChildren) : new UsingDirectiveSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIdentifier(PreAdamantParser_Antlr.IdentifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IdentifierSyntax(allChildren) : new IdentifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamespaceName(PreAdamantParser_Antlr.NamespaceNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamespaceNameSyntax(allChildren) : new NamespaceNameSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamespaceDeclaration(PreAdamantParser_Antlr.NamespaceDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamespaceDeclarationSyntax(allChildren) : new NamespaceDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitClassDeclaration(PreAdamantParser_Antlr.ClassDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ClassDeclarationSyntax(allChildren) : new ClassDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitStructDeclaration(PreAdamantParser_Antlr.StructDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new StructDeclarationSyntax(allChildren) : new StructDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitVariableDeclaration(PreAdamantParser_Antlr.VariableDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new VariableDeclarationSyntax(allChildren) : new VariableDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFunctionDeclaration(PreAdamantParser_Antlr.FunctionDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FunctionDeclarationSyntax(allChildren) : new FunctionDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitExternalBlockDeclaration(PreAdamantParser_Antlr.ExternalBlockDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ExternalBlockDeclarationSyntax(allChildren) : new ExternalBlockDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPrecondition(PreAdamantParser_Antlr.PreconditionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PreconditionSyntax(allChildren) : new PreconditionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPostcondition(PreAdamantParser_Antlr.PostconditionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PostconditionSyntax(allChildren) : new PostconditionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAttribute(PreAdamantParser_Antlr.AttributeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AttributeSyntax(allChildren) : new AttributeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBaseTypes(PreAdamantParser_Antlr.BaseTypesContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BaseTypesSyntax(allChildren) : new BaseTypesSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAccessModifier(PreAdamantParser_Antlr.AccessModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AccessModifierSyntax(allChildren) : new AccessModifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitSafetyModifier(PreAdamantParser_Antlr.SafetyModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new SafetyModifierSyntax(allChildren) : new SafetyModifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitClassInheritanceModifier(PreAdamantParser_Antlr.ClassInheritanceModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ClassInheritanceModifierSyntax(allChildren) : new ClassInheritanceModifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMethodInheritanceModifier(PreAdamantParser_Antlr.MethodInheritanceModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MethodInheritanceModifierSyntax(allChildren) : new MethodInheritanceModifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitExplicitModifier(PreAdamantParser_Antlr.ExplicitModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ExplicitModifierSyntax(allChildren) : new ExplicitModifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAsyncModifier(PreAdamantParser_Antlr.AsyncModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AsyncModifierSyntax(allChildren) : new AsyncModifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeParameters(PreAdamantParser_Antlr.TypeParametersContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeParametersSyntax(allChildren) : new TypeParametersSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeParameter(PreAdamantParser_Antlr.TypeParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeParameterSyntax(allChildren) : new TypeParameterSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeArguments(PreAdamantParser_Antlr.TypeArgumentsContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeArgumentsSyntax(allChildren) : new TypeArgumentsSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIdentifierOrPredefinedType(PreAdamantParser_Antlr.IdentifierOrPredefinedTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IdentifierOrPredefinedTypeSyntax(allChildren) : new IdentifierOrPredefinedTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIdentifierName(PreAdamantParser_Antlr.IdentifierNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IdentifierNameSyntax(allChildren) : new IdentifierNameSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitGenericName(PreAdamantParser_Antlr.GenericNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new GenericNameSyntax(allChildren) : new GenericNameSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnqualifiedName(PreAdamantParser_Antlr.UnqualifiedNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnqualifiedNameSyntax(allChildren) : new UnqualifiedNameSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitQualifiedName(PreAdamantParser_Antlr.QualifiedNameContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new QualifiedNameSyntax(allChildren) : new QualifiedNameSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamedType(PreAdamantParser_Antlr.NamedTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamedTypeSyntax(allChildren) : new NamedTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMaybeType(PreAdamantParser_Antlr.MaybeTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MaybeTypeSyntax(allChildren) : new MaybeTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPointerType(PreAdamantParser_Antlr.PointerTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PointerTypeSyntax(allChildren) : new PointerTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTupleType(PreAdamantParser_Antlr.TupleTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TupleTypeSyntax(allChildren) : new TupleTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFunctionType(PreAdamantParser_Antlr.FunctionTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FunctionTypeSyntax(allChildren) : new FunctionTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLifetimeType(PreAdamantParser_Antlr.LifetimeTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LifetimeTypeSyntax(allChildren) : new LifetimeTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitRefType(PreAdamantParser_Antlr.RefTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new RefTypeSyntax(allChildren) : new RefTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitType(PreAdamantParser_Antlr.TypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeSyntax(allChildren) : new TypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitReturnType(PreAdamantParser_Antlr.ReturnTypeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ReturnTypeSyntax(allChildren) : new ReturnTypeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLifetime(PreAdamantParser_Antlr.LifetimeContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LifetimeSyntax(allChildren) : new LifetimeSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFuncTypeParameterList(PreAdamantParser_Antlr.FuncTypeParameterListContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FuncTypeParameterListSyntax(allChildren) : new FuncTypeParameterListSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitFuncTypeParameter(PreAdamantParser_Antlr.FuncTypeParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FuncTypeParameterSyntax(allChildren) : new FuncTypeParameterSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstExpression(PreAdamantParser_Antlr.ConstExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstExpressionSyntax(allChildren) : new ConstExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeParameterConstraintClause(PreAdamantParser_Antlr.TypeParameterConstraintClauseContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeParameterConstraintClauseSyntax(allChildren) : new TypeParameterConstraintClauseSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstructorConstraint(PreAdamantParser_Antlr.ConstructorConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstructorConstraintSyntax(allChildren) : new ConstructorConstraintSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeConstraint(PreAdamantParser_Antlr.TypeConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeConstraintSyntax(allChildren) : new TypeConstraintSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTypeListParameterConstraint(PreAdamantParser_Antlr.TypeListParameterConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TypeListParameterConstraintSyntax(allChildren) : new TypeListParameterConstraintSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstructor(PreAdamantParser_Antlr.ConstructorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstructorSyntax(allChildren) : new ConstructorSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCopyConstructor(PreAdamantParser_Antlr.CopyConstructorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CopyConstructorSyntax(allChildren) : new CopyConstructorSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDestructor(PreAdamantParser_Antlr.DestructorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DestructorSyntax(allChildren) : new DestructorSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConversionMethod(PreAdamantParser_Antlr.ConversionMethodContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConversionMethodSyntax(allChildren) : new ConversionMethodSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitField(PreAdamantParser_Antlr.FieldContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new FieldSyntax(allChildren) : new FieldSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAccessor(PreAdamantParser_Antlr.AccessorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AccessorSyntax(allChildren) : new AccessorSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIndexer(PreAdamantParser_Antlr.IndexerContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IndexerSyntax(allChildren) : new IndexerSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMethod(PreAdamantParser_Antlr.MethodContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MethodSyntax(allChildren) : new MethodSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitOperatorOverload(PreAdamantParser_Antlr.OperatorOverloadContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new OperatorOverloadSyntax(allChildren) : new OperatorOverloadSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNestedClassDeclaration(PreAdamantParser_Antlr.NestedClassDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NestedClassDeclarationSyntax(allChildren) : new NestedClassDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitParameterList(PreAdamantParser_Antlr.ParameterListContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ParameterListSyntax(allChildren) : new ParameterListSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNamedParameter(PreAdamantParser_Antlr.NamedParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NamedParameterSyntax(allChildren) : new NamedParameterSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitSelfParameter(PreAdamantParser_Antlr.SelfParameterContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new SelfParameterSyntax(allChildren) : new SelfParameterSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitParameterModifier(PreAdamantParser_Antlr.ParameterModifierContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ParameterModifierSyntax(allChildren) : new ParameterModifierSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitWhereClause(PreAdamantParser_Antlr.WhereClauseContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new WhereClauseSyntax(allChildren) : new WhereClauseSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitGenericConstraint(PreAdamantParser_Antlr.GenericConstraintContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new GenericConstraintSyntax(allChildren) : new GenericConstraintSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitConstructorInitializer(PreAdamantParser_Antlr.ConstructorInitializerContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ConstructorInitializerSyntax(allChildren) : new ConstructorInitializerSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitArgumentList(PreAdamantParser_Antlr.ArgumentListContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ArgumentListSyntax(allChildren) : new ArgumentListSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBlockMethodBody(PreAdamantParser_Antlr.BlockMethodBodyContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BlockMethodBodySyntax(allChildren) : new BlockMethodBodySyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNoMethodBody(PreAdamantParser_Antlr.NoMethodBodyContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NoMethodBodySyntax(allChildren) : new NoMethodBodySyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitOverloadableOperator(PreAdamantParser_Antlr.OverloadableOperatorContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new OverloadableOperatorSyntax(allChildren) : new OverloadableOperatorSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitVariableDeclarationStatement(PreAdamantParser_Antlr.VariableDeclarationStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new VariableDeclarationStatementSyntax(allChildren) : new VariableDeclarationStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnsafeBlockStatement(PreAdamantParser_Antlr.UnsafeBlockStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnsafeBlockStatementSyntax(allChildren) : new UnsafeBlockStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBlockStatement(PreAdamantParser_Antlr.BlockStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BlockStatementSyntax(allChildren) : new BlockStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitEmptyStatement(PreAdamantParser_Antlr.EmptyStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new EmptyStatementSyntax(allChildren) : new EmptyStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitExpressionStatement(PreAdamantParser_Antlr.ExpressionStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ExpressionStatementSyntax(allChildren) : new ExpressionStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitReturnStatement(PreAdamantParser_Antlr.ReturnStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ReturnStatementSyntax(allChildren) : new ReturnStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitThrowStatement(PreAdamantParser_Antlr.ThrowStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ThrowStatementSyntax(allChildren) : new ThrowStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIfStatement(PreAdamantParser_Antlr.IfStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IfStatementSyntax(allChildren) : new IfStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLetIfStatement(PreAdamantParser_Antlr.LetIfStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LetIfStatementSyntax(allChildren) : new LetIfStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitForStatement(PreAdamantParser_Antlr.ForStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ForStatementSyntax(allChildren) : new ForStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitWhileStatement(PreAdamantParser_Antlr.WhileStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new WhileStatementSyntax(allChildren) : new WhileStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDeleteStatement(PreAdamantParser_Antlr.DeleteStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DeleteStatementSyntax(allChildren) : new DeleteStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitContinueStatement(PreAdamantParser_Antlr.ContinueStatementContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ContinueStatementSyntax(allChildren) : new ContinueStatementSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLocalVariableDeclaration(PreAdamantParser_Antlr.LocalVariableDeclarationContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LocalVariableDeclarationSyntax(allChildren) : new LocalVariableDeclarationSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitParenthesizedExpression(PreAdamantParser_Antlr.ParenthesizedExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ParenthesizedExpressionSyntax(allChildren) : new ParenthesizedExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMagnitudeExpression(PreAdamantParser_Antlr.MagnitudeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MagnitudeExpressionSyntax(allChildren) : new MagnitudeExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMemberExpression(PreAdamantParser_Antlr.MemberExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MemberExpressionSyntax(allChildren) : new MemberExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitPlacementDeleteExpression(PreAdamantParser_Antlr.PlacementDeleteExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new PlacementDeleteExpressionSyntax(allChildren) : new PlacementDeleteExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDotDotExpression(PreAdamantParser_Antlr.DotDotExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DotDotExpressionSyntax(allChildren) : new DotDotExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitToExpression(PreAdamantParser_Antlr.ToExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ToExpressionSyntax(allChildren) : new ToExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCallExpression(PreAdamantParser_Antlr.CallExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CallExpressionSyntax(allChildren) : new CallExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitArrayAccessExpression(PreAdamantParser_Antlr.ArrayAccessExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ArrayAccessExpressionSyntax(allChildren) : new ArrayAccessExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAwaitExpression(PreAdamantParser_Antlr.AwaitExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AwaitExpressionSyntax(allChildren) : new AwaitExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNullCheckExpression(PreAdamantParser_Antlr.NullCheckExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NullCheckExpressionSyntax(allChildren) : new NullCheckExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnaryExpression(PreAdamantParser_Antlr.UnaryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnaryExpressionSyntax(allChildren) : new UnaryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitMultiplicativeExpression(PreAdamantParser_Antlr.MultiplicativeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new MultiplicativeExpressionSyntax(allChildren) : new MultiplicativeExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAdditiveExpression(PreAdamantParser_Antlr.AdditiveExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AdditiveExpressionSyntax(allChildren) : new AdditiveExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitComparativeExpression(PreAdamantParser_Antlr.ComparativeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new ComparativeExpressionSyntax(allChildren) : new ComparativeExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitEqualityExpression(PreAdamantParser_Antlr.EqualityExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new EqualityExpressionSyntax(allChildren) : new EqualityExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAndExpression(PreAdamantParser_Antlr.AndExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AndExpressionSyntax(allChildren) : new AndExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitXorExpression(PreAdamantParser_Antlr.XorExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new XorExpressionSyntax(allChildren) : new XorExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitOrExpression(PreAdamantParser_Antlr.OrExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new OrExpressionSyntax(allChildren) : new OrExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCoalesceExpression(PreAdamantParser_Antlr.CoalesceExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CoalesceExpressionSyntax(allChildren) : new CoalesceExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitInExpression(PreAdamantParser_Antlr.InExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new InExpressionSyntax(allChildren) : new InExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNewExpression(PreAdamantParser_Antlr.NewExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NewExpressionSyntax(allChildren) : new NewExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNewMemoryExpression(PreAdamantParser_Antlr.NewMemoryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NewMemoryExpressionSyntax(allChildren) : new NewMemoryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNewObjectExpression(PreAdamantParser_Antlr.NewObjectExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NewObjectExpressionSyntax(allChildren) : new NewObjectExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitDeleteMemoryExpression(PreAdamantParser_Antlr.DeleteMemoryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new DeleteMemoryExpressionSyntax(allChildren) : new DeleteMemoryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCastExpression(PreAdamantParser_Antlr.CastExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CastExpressionSyntax(allChildren) : new CastExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitTryExpression(PreAdamantParser_Antlr.TryExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new TryExpressionSyntax(allChildren) : new TryExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIfExpression(PreAdamantParser_Antlr.IfExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IfExpressionSyntax(allChildren) : new IfExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitAssignmentExpression(PreAdamantParser_Antlr.AssignmentExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new AssignmentExpressionSyntax(allChildren) : new AssignmentExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitLambdaExpression(PreAdamantParser_Antlr.LambdaExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new LambdaExpressionSyntax(allChildren) : new LambdaExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNameExpression(PreAdamantParser_Antlr.NameExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NameExpressionSyntax(allChildren) : new NameExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitNullLiteralExpression(PreAdamantParser_Antlr.NullLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new NullLiteralExpressionSyntax(allChildren) : new NullLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitSelfExpression(PreAdamantParser_Antlr.SelfExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new SelfExpressionSyntax(allChildren) : new SelfExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitBooleanLiteralExpression(PreAdamantParser_Antlr.BooleanLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new BooleanLiteralExpressionSyntax(allChildren) : new BooleanLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitIntLiteralExpression(PreAdamantParser_Antlr.IntLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new IntLiteralExpressionSyntax(allChildren) : new IntLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUninitializedExpression(PreAdamantParser_Antlr.UninitializedExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UninitializedExpressionSyntax(allChildren) : new UninitializedExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitStringLiteralExpression(PreAdamantParser_Antlr.StringLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new StringLiteralExpressionSyntax(allChildren) : new StringLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitCharLiteralExpression(PreAdamantParser_Antlr.CharLiteralExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new CharLiteralExpressionSyntax(allChildren) : new CharLiteralExpressionSyntax(context.Start.StartIndex);
		}

		ISyntax IPreAdamantParser_AntlrVisitor<ISyntax>.VisitUnsafeExpression(PreAdamantParser_Antlr.UnsafeExpressionContext context)
		{
			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;
			var allChildren = InterleaveTriva(children);
			return allChildren.Any() ? new UnsafeExpressionSyntax(allChildren) : new UnsafeExpressionSyntax(context.Start.StartIndex);
		}

	}
}
