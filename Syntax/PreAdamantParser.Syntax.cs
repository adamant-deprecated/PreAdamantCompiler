using System.Collections.Generic;

namespace PreAdamant.Compiler.Syntax
{
	public partial class CompilationUnitSyntax : SyntaxNode
	{
		public CompilationUnitSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class UsingDirectiveSyntax : SyntaxNode
	{
		public UsingDirectiveSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class IdentifierSyntax : SyntaxNode
	{
		public IdentifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NamespaceNameSyntax : SyntaxNode
	{
		public NamespaceNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NamespaceDeclarationSyntax : DeclarationSyntax
	{
		public NamespaceDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ClassDeclarationSyntax : DeclarationSyntax
	{
		public ClassDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class StructDeclarationSyntax : DeclarationSyntax
	{
		public StructDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class VariableDeclarationSyntax : DeclarationSyntax
	{
		public VariableDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class FunctionDeclarationSyntax : DeclarationSyntax
	{
		public FunctionDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ExternalBlockDeclarationSyntax : DeclarationSyntax
	{
		public ExternalBlockDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class PreconditionSyntax : ContractSyntax
	{
		public PreconditionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class PostconditionSyntax : ContractSyntax
	{
		public PostconditionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AttributeSyntax : SyntaxNode
	{
		public AttributeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class BaseTypesSyntax : SyntaxNode
	{
		public BaseTypesSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AccessModifierSyntax : SyntaxNode
	{
		public AccessModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class SafetyModifierSyntax : SyntaxNode
	{
		public SafetyModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ClassInheritanceModifierSyntax : SyntaxNode
	{
		public ClassInheritanceModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MethodInheritanceModifierSyntax : SyntaxNode
	{
		public MethodInheritanceModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ExplicitModifierSyntax : SyntaxNode
	{
		public ExplicitModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AsyncModifierSyntax : SyntaxNode
	{
		public AsyncModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeParametersSyntax : SyntaxNode
	{
		public TypeParametersSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeParameterSyntax : SyntaxNode
	{
		public TypeParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeArgumentsSyntax : SyntaxNode
	{
		public TypeArgumentsSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class IdentifierOrPredefinedTypeSyntax : SyntaxNode
	{
		public IdentifierOrPredefinedTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class IdentifierNameSyntax : SimpleNameSyntax
	{
		public IdentifierNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class GenericNameSyntax : SimpleNameSyntax
	{
		public GenericNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class UnqualifiedNameSyntax : NameSyntax
	{
		public UnqualifiedNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class QualifiedNameSyntax : NameSyntax
	{
		public QualifiedNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NamedTypeSyntax : TypeNameSyntax
	{
		public NamedTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MaybeTypeSyntax : TypeNameSyntax
	{
		public MaybeTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class PointerTypeSyntax : TypeNameSyntax
	{
		public PointerTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TupleTypeSyntax : TypeNameSyntax
	{
		public TupleTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class FunctionTypeSyntax : TypeNameSyntax
	{
		public FunctionTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class LifetimeTypeSyntax : ValueTypeSyntax
	{
		public LifetimeTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class RefTypeSyntax : ValueTypeSyntax
	{
		public RefTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeSyntax : SyntaxNode
	{
		public TypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ReturnTypeSyntax : SyntaxNode
	{
		public ReturnTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class LifetimeSyntax : SyntaxNode
	{
		public LifetimeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class FuncTypeParameterListSyntax : SyntaxNode
	{
		public FuncTypeParameterListSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class FuncTypeParameterSyntax : SyntaxNode
	{
		public FuncTypeParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ConstExpressionSyntax : SyntaxNode
	{
		public ConstExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeParameterConstraintClauseSyntax : SyntaxNode
	{
		public TypeParameterConstraintClauseSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ConstructorConstraintSyntax : TypeParameterConstraintSyntax
	{
		public ConstructorConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeConstraintSyntax : TypeParameterConstraintSyntax
	{
		public TypeConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeListParameterConstraintSyntax : TypeParameterConstraintSyntax
	{
		public TypeListParameterConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ConstructorSyntax : MemberSyntax
	{
		public ConstructorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class CopyConstructorSyntax : MemberSyntax
	{
		public CopyConstructorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class DestructorSyntax : MemberSyntax
	{
		public DestructorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ConversionMethodSyntax : MemberSyntax
	{
		public ConversionMethodSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class FieldSyntax : MemberSyntax
	{
		public FieldSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AccessorSyntax : MemberSyntax
	{
		public AccessorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class IndexerSyntax : MemberSyntax
	{
		public IndexerSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MethodSyntax : MemberSyntax
	{
		public MethodSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class OperatorOverloadSyntax : MemberSyntax
	{
		public OperatorOverloadSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NestedClassDeclarationSyntax : MemberSyntax
	{
		public NestedClassDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ParameterListSyntax : SyntaxNode
	{
		public ParameterListSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NamedParameterSyntax : ParameterSyntax
	{
		public NamedParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class SelfParameterSyntax : ParameterSyntax
	{
		public SelfParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ParameterModifierSyntax : SyntaxNode
	{
		public ParameterModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class WhereClauseSyntax : SyntaxNode
	{
		public WhereClauseSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class GenericConstraintSyntax : SyntaxNode
	{
		public GenericConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ConstructorInitializerSyntax : SyntaxNode
	{
		public ConstructorInitializerSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ArgumentListSyntax : SyntaxNode
	{
		public ArgumentListSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class BlockMethodBodySyntax : MethodBodySyntax
	{
		public BlockMethodBodySyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NoMethodBodySyntax : MethodBodySyntax
	{
		public NoMethodBodySyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class OverloadableOperatorSyntax : SyntaxNode
	{
		public OverloadableOperatorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class VariableDeclarationStatementSyntax : StatementSyntax
	{
		public VariableDeclarationStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class UnsafeBlockStatementSyntax : StatementSyntax
	{
		public UnsafeBlockStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class BlockStatementSyntax : StatementSyntax
	{
		public BlockStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class EmptyStatementSyntax : StatementSyntax
	{
		public EmptyStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ExpressionStatementSyntax : StatementSyntax
	{
		public ExpressionStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ReturnStatementSyntax : StatementSyntax
	{
		public ReturnStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ThrowStatementSyntax : StatementSyntax
	{
		public ThrowStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class IfStatementSyntax : StatementSyntax
	{
		public IfStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class LetIfStatementSyntax : StatementSyntax
	{
		public LetIfStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ForStatementSyntax : StatementSyntax
	{
		public ForStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class WhileStatementSyntax : StatementSyntax
	{
		public WhileStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class DeleteStatementSyntax : StatementSyntax
	{
		public DeleteStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ContinueStatementSyntax : StatementSyntax
	{
		public ContinueStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class LocalVariableDeclarationSyntax : SyntaxNode
	{
		public LocalVariableDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ParenthesizedExpressionSyntax : ExpressionSyntax
	{
		public ParenthesizedExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MagnitudeExpressionSyntax : ExpressionSyntax
	{
		public MagnitudeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MemberExpressionSyntax : ExpressionSyntax
	{
		public MemberExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class PlacementDeleteExpressionSyntax : ExpressionSyntax
	{
		public PlacementDeleteExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class DotDotExpressionSyntax : ExpressionSyntax
	{
		public DotDotExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ToExpressionSyntax : ExpressionSyntax
	{
		public ToExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class CallExpressionSyntax : ExpressionSyntax
	{
		public CallExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ArrayAccessExpressionSyntax : ExpressionSyntax
	{
		public ArrayAccessExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AwaitExpressionSyntax : ExpressionSyntax
	{
		public AwaitExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NullCheckExpressionSyntax : ExpressionSyntax
	{
		public NullCheckExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class UnaryExpressionSyntax : ExpressionSyntax
	{
		public UnaryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MultiplicativeExpressionSyntax : ExpressionSyntax
	{
		public MultiplicativeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AdditiveExpressionSyntax : ExpressionSyntax
	{
		public AdditiveExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ComparativeExpressionSyntax : ExpressionSyntax
	{
		public ComparativeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class EqualityExpressionSyntax : ExpressionSyntax
	{
		public EqualityExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AndExpressionSyntax : ExpressionSyntax
	{
		public AndExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class XorExpressionSyntax : ExpressionSyntax
	{
		public XorExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class OrExpressionSyntax : ExpressionSyntax
	{
		public OrExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class CoalesceExpressionSyntax : ExpressionSyntax
	{
		public CoalesceExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class InExpressionSyntax : ExpressionSyntax
	{
		public InExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NewExpressionSyntax : ExpressionSyntax
	{
		public NewExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NewMemoryExpressionSyntax : ExpressionSyntax
	{
		public NewMemoryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NewObjectExpressionSyntax : ExpressionSyntax
	{
		public NewObjectExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class DeleteMemoryExpressionSyntax : ExpressionSyntax
	{
		public DeleteMemoryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class CastExpressionSyntax : ExpressionSyntax
	{
		public CastExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TryExpressionSyntax : ExpressionSyntax
	{
		public TryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class IfExpressionSyntax : ExpressionSyntax
	{
		public IfExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class AssignmentExpressionSyntax : ExpressionSyntax
	{
		public AssignmentExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class LambdaExpressionSyntax : ExpressionSyntax
	{
		public LambdaExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NameExpressionSyntax : ExpressionSyntax
	{
		public NameExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NullLiteralExpressionSyntax : ExpressionSyntax
	{
		public NullLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class SelfExpressionSyntax : ExpressionSyntax
	{
		public SelfExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class BooleanLiteralExpressionSyntax : ExpressionSyntax
	{
		public BooleanLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class IntLiteralExpressionSyntax : ExpressionSyntax
	{
		public IntLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class UninitializedExpressionSyntax : ExpressionSyntax
	{
		public UninitializedExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class StringLiteralExpressionSyntax : ExpressionSyntax
	{
		public StringLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class CharLiteralExpressionSyntax : ExpressionSyntax
	{
		public CharLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class UnsafeExpressionSyntax : ExpressionSyntax
	{
		public UnsafeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class DeclarationSyntax : SyntaxNode
	{
		public DeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ContractSyntax : SyntaxNode
	{
		public ContractSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class SimpleNameSyntax : SyntaxNode
	{
		public SimpleNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class NameSyntax : SyntaxNode
	{
		public NameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeNameSyntax : SyntaxNode
	{
		public TypeNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ValueTypeSyntax : SyntaxNode
	{
		public ValueTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class TypeParameterConstraintSyntax : SyntaxNode
	{
		public TypeParameterConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MemberSyntax : SyntaxNode
	{
		public MemberSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ParameterSyntax : SyntaxNode
	{
		public ParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class MethodBodySyntax : SyntaxNode
	{
		public MethodBodySyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class StatementSyntax : SyntaxNode
	{
		public StatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

	public partial class ExpressionSyntax : SyntaxNode
	{
		public ExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}
	}

}
