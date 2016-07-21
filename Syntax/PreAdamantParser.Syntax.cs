using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	public partial class CompilationUnitSyntax : SyntaxNode
	{
	}

	public partial class UsingDirectiveSyntax : SyntaxNode
	{
	}

	public partial class IdentifierSyntax : SyntaxNode
	{
	}

	public partial class NamespaceNameSyntax : SyntaxNode
	{
	}

	public partial class NamespaceDeclarationSyntax : DeclarationSyntax
	{
	}

	public partial class ClassDeclarationSyntax : DeclarationSyntax
	{
	}

	public partial class StructDeclarationSyntax : DeclarationSyntax
	{
	}

	public partial class VariableDeclarationSyntax : DeclarationSyntax
	{
	}

	public partial class FunctionDeclarationSyntax : DeclarationSyntax
	{
	}

	public partial class ExternalBlockDeclarationSyntax : DeclarationSyntax
	{
	}

	public partial class PreconditionSyntax : ContractSyntax
	{
	}

	public partial class PostconditionSyntax : ContractSyntax
	{
	}

	public partial class AttributeSyntax : SyntaxNode
	{
	}

	public partial class BaseTypesSyntax : SyntaxNode
	{
	}

	public partial class AccessModifierSyntax : SyntaxNode
	{
	}

	public partial class SafetyModifierSyntax : SyntaxNode
	{
	}

	public partial class ClassInheritanceModifierSyntax : SyntaxNode
	{
	}

	public partial class MethodInheritanceModifierSyntax : SyntaxNode
	{
	}

	public partial class ExplicitModifierSyntax : SyntaxNode
	{
	}

	public partial class AsyncModifierSyntax : SyntaxNode
	{
	}

	public partial class TypeParametersSyntax : SyntaxNode
	{
	}

	public partial class TypeParameterSyntax : SyntaxNode
	{
	}

	public partial class TypeArgumentsSyntax : SyntaxNode
	{
	}

	public partial class IdentifierOrPredefinedTypeSyntax : SyntaxNode
	{
	}

	public partial class IdentifierNameSyntax : SimpleNameSyntax
	{
	}

	public partial class GenericNameSyntax : SimpleNameSyntax
	{
	}

	public partial class UnqualifiedNameSyntax : NameSyntax
	{
	}

	public partial class QualifiedNameSyntax : NameSyntax
	{
	}

	public partial class NamedTypeSyntax : TypeNameSyntax
	{
	}

	public partial class MaybeTypeSyntax : TypeNameSyntax
	{
	}

	public partial class PointerTypeSyntax : TypeNameSyntax
	{
	}

	public partial class TupleTypeSyntax : TypeNameSyntax
	{
	}

	public partial class FunctionTypeSyntax : TypeNameSyntax
	{
	}

	public partial class LifetimeTypeSyntax : ValueTypeSyntax
	{
	}

	public partial class RefTypeSyntax : ValueTypeSyntax
	{
	}

	public partial class TypeSyntax : SyntaxNode
	{
	}

	public partial class ReturnTypeSyntax : SyntaxNode
	{
	}

	public partial class LifetimeSyntax : SyntaxNode
	{
	}

	public partial class FuncTypeParameterListSyntax : SyntaxNode
	{
	}

	public partial class FuncTypeParameterSyntax : SyntaxNode
	{
	}

	public partial class ConstExpressionSyntax : SyntaxNode
	{
	}

	public partial class TypeParameterConstraintClauseSyntax : SyntaxNode
	{
	}

	public partial class ConstructorConstraintSyntax : TypeParameterConstraintSyntax
	{
	}

	public partial class TypeConstraintSyntax : TypeParameterConstraintSyntax
	{
	}

	public partial class TypeListParameterConstraintSyntax : TypeParameterConstraintSyntax
	{
	}

	public partial class ConstructorSyntax : MemberSyntax
	{
	}

	public partial class CopyConstructorSyntax : MemberSyntax
	{
	}

	public partial class DestructorSyntax : MemberSyntax
	{
	}

	public partial class ConversionMethodSyntax : MemberSyntax
	{
	}

	public partial class FieldSyntax : MemberSyntax
	{
	}

	public partial class AccessorSyntax : MemberSyntax
	{
	}

	public partial class IndexerSyntax : MemberSyntax
	{
	}

	public partial class MethodSyntax : MemberSyntax
	{
	}

	public partial class OperatorOverloadSyntax : MemberSyntax
	{
	}

	public partial class NestedClassDeclarationSyntax : MemberSyntax
	{
	}

	public partial class ParameterListSyntax : SyntaxNode
	{
	}

	public partial class NamedParameterSyntax : ParameterSyntax
	{
	}

	public partial class SelfParameterSyntax : ParameterSyntax
	{
	}

	public partial class ParameterModifierSyntax : SyntaxNode
	{
	}

	public partial class WhereClauseSyntax : SyntaxNode
	{
	}

	public partial class GenericConstraintSyntax : SyntaxNode
	{
	}

	public partial class ConstructorInitializerSyntax : SyntaxNode
	{
	}

	public partial class ArgumentListSyntax : SyntaxNode
	{
	}

	public partial class BlockMethodBodySyntax : MethodBodySyntax
	{
	}

	public partial class NoMethodBodySyntax : MethodBodySyntax
	{
	}

	public partial class OverloadableOperatorSyntax : SyntaxNode
	{
	}

	public partial class VariableDeclarationStatementSyntax : StatementSyntax
	{
	}

	public partial class UnsafeBlockStatementSyntax : StatementSyntax
	{
	}

	public partial class BlockStatementSyntax : StatementSyntax
	{
	}

	public partial class EmptyStatementSyntax : StatementSyntax
	{
	}

	public partial class ExpressionStatementSyntax : StatementSyntax
	{
	}

	public partial class ReturnStatementSyntax : StatementSyntax
	{
	}

	public partial class ThrowStatementSyntax : StatementSyntax
	{
	}

	public partial class IfStatementSyntax : StatementSyntax
	{
	}

	public partial class LetIfStatementSyntax : StatementSyntax
	{
	}

	public partial class ForStatementSyntax : StatementSyntax
	{
	}

	public partial class WhileStatementSyntax : StatementSyntax
	{
	}

	public partial class DeleteStatementSyntax : StatementSyntax
	{
	}

	public partial class ContinueStatementSyntax : StatementSyntax
	{
	}

	public partial class LocalVariableDeclarationSyntax : SyntaxNode
	{
	}

	public partial class ParenthesizedExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class MagnitudeExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class MemberExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class PlacementDeleteExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class DotDotExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class ToExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class CallExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class ArrayAccessExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class AwaitExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class NullCheckExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class UnaryExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class MultiplicativeExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class AdditiveExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class ComparativeExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class EqualityExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class AndExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class XorExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class OrExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class CoalesceExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class InExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class NewExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class NewMemoryExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class NewObjectExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class DeleteMemoryExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class CastExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class TryExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class IfExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class AssignmentExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class LambdaExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class NameExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class NullLiteralExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class SelfExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class BooleanLiteralExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class IntLiteralExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class UninitializedExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class StringLiteralExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class CharLiteralExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class UnsafeExpressionSyntax : ExpressionSyntax
	{
	}

	public partial class DeclarationSyntax : SyntaxNode
	{
	}

	public partial class ContractSyntax : SyntaxNode
	{
	}

	public partial class SimpleNameSyntax : SyntaxNode
	{
	}

	public partial class NameSyntax : SyntaxNode
	{
	}

	public partial class TypeNameSyntax : SyntaxNode
	{
	}

	public partial class ValueTypeSyntax : SyntaxNode
	{
	}

	public partial class TypeParameterConstraintSyntax : SyntaxNode
	{
	}

	public partial class MemberSyntax : SyntaxNode
	{
	}

	public partial class ParameterSyntax : SyntaxNode
	{
	}

	public partial class MethodBodySyntax : SyntaxNode
	{
	}

	public partial class StatementSyntax : SyntaxNode
	{
	}

	public partial class ExpressionSyntax : SyntaxNode
	{
	}

}
