using System.Collections.Generic;

namespace PreAdamant.Compiler.Syntax
{
	public partial class CompilationUnitSyntax : SyntaxNode
	{
		public IReadOnlyList<UsingDirectiveSyntax> UsingDirectives { get; }
		public IReadOnlyList<DeclarationSyntax> Declarations { get; }

		public CompilationUnitSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public CompilationUnitSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UsingDirectiveSyntax : SyntaxNode
	{
		public NamespaceNameSyntax NamespaceName { get; }

		public UsingDirectiveSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public UsingDirectiveSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IdentifierSyntax : SyntaxNode
	{
		public IdentifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public IdentifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NamespaceNameSyntax : SyntaxNode
	{
		public IReadOnlyList<IdentifierSyntax> Identifiers { get; }

		public NamespaceNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NamespaceNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NamespaceDeclarationSyntax : DeclarationSyntax
	{
		public NamespaceNameSyntax NamespaceName { get; }
		public IReadOnlyList<UsingDirectiveSyntax> UsingDirectives { get; }
		public IReadOnlyList<DeclarationSyntax> Declarations { get; }

		public NamespaceDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NamespaceDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ClassDeclarationSyntax : DeclarationSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public ClassInheritanceModifierSyntax ClassInheritanceModifier { get; }
		public IdentifierSyntax ClassName { get; }
		public TypeParametersSyntax TypeParameters { get; }
		public BaseTypesSyntax BaseTypes { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<MemberSyntax> Members { get; }

		public ClassDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ClassDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class StructDeclarationSyntax : DeclarationSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public IdentifierSyntax StructName { get; }
		public TypeParametersSyntax TypeParameters { get; }
		public BaseTypesSyntax BaseTypes { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<MemberSyntax> Members { get; }

		public StructDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public StructDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class VariableDeclarationSyntax : DeclarationSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public IdentifierSyntax Identifier { get; }
		public ValueTypeSyntax ValueType { get; }
		public ExpressionSyntax Expression { get; }

		public VariableDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public VariableDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class FunctionDeclarationSyntax : DeclarationSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public AsyncModifierSyntax AsyncModifier { get; }
		public IdentifierSyntax Identifier { get; }
		public TypeArgumentsSyntax TypeArguments { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public FunctionDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public FunctionDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ExternalBlockDeclarationSyntax : DeclarationSyntax
	{
		public IReadOnlyList<DeclarationSyntax> Declarations { get; }

		public ExternalBlockDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ExternalBlockDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PreconditionSyntax : ContractSyntax
	{
		public ExpressionSyntax Expression { get; }

		public PreconditionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public PreconditionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PostconditionSyntax : ContractSyntax
	{
		public ExpressionSyntax Expression { get; }

		public PostconditionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public PostconditionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AttributeSyntax : SyntaxNode
	{
		public IdentifierSyntax Identifier { get; }
		public ArgumentListSyntax ArgumentList { get; }

		public AttributeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AttributeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class BaseTypesSyntax : SyntaxNode
	{
		public NameSyntax BaseType { get; }
		public IReadOnlyList<NameSyntax> Interfaces { get; }

		public BaseTypesSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public BaseTypesSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AccessModifierSyntax : SyntaxNode
	{
		public AccessModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AccessModifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class SafetyModifierSyntax : SyntaxNode
	{
		public SafetyModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public SafetyModifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ClassInheritanceModifierSyntax : SyntaxNode
	{
		public ClassInheritanceModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ClassInheritanceModifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MethodInheritanceModifierSyntax : SyntaxNode
	{
		public MethodInheritanceModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MethodInheritanceModifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ExplicitModifierSyntax : SyntaxNode
	{
		public ExplicitModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ExplicitModifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AsyncModifierSyntax : SyntaxNode
	{
		public AsyncModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AsyncModifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeParametersSyntax : SyntaxNode
	{
		public IReadOnlyList<TypeParameterSyntax> TypeParameters { get; }

		public TypeParametersSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeParametersSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeParameterSyntax : SyntaxNode
	{
		public TypeParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeParameterSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeArgumentsSyntax : SyntaxNode
	{
		public IReadOnlyList<TypeSyntax> Types { get; }

		public TypeArgumentsSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeArgumentsSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IdentifierOrPredefinedTypeSyntax : SyntaxNode
	{
		public IdentifierOrPredefinedTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public IdentifierOrPredefinedTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IdentifierNameSyntax : SimpleNameSyntax
	{
		public IdentifierOrPredefinedTypeSyntax IdentifierOrPredefinedType { get; }

		public IdentifierNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public IdentifierNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class GenericNameSyntax : SimpleNameSyntax
	{
		public IdentifierOrPredefinedTypeSyntax IdentifierOrPredefinedType { get; }
		public TypeArgumentsSyntax TypeArguments { get; }

		public GenericNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public GenericNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnqualifiedNameSyntax : NameSyntax
	{
		public SimpleNameSyntax SimpleName { get; }

		public UnqualifiedNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public UnqualifiedNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class QualifiedNameSyntax : NameSyntax
	{
		public NameSyntax LeftName { get; }
		public SimpleNameSyntax RightName { get; }

		public QualifiedNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public QualifiedNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NamedTypeSyntax : TypeNameSyntax
	{
		public NameSyntax Name { get; }

		public NamedTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NamedTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MaybeTypeSyntax : TypeNameSyntax
	{
		public TypeNameSyntax TypeName { get; }

		public MaybeTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MaybeTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PointerTypeSyntax : TypeNameSyntax
	{
		public TypeNameSyntax TypeName { get; }

		public PointerTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public PointerTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TupleTypeSyntax : TypeNameSyntax
	{
		public TupleTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TupleTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class FunctionTypeSyntax : TypeNameSyntax
	{
		public FuncTypeParameterListSyntax FuncTypeParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }

		public FunctionTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public FunctionTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class LifetimeTypeSyntax : ValueTypeSyntax
	{
		public LifetimeSyntax Lifetime { get; }
		public TypeNameSyntax TypeName { get; }

		public LifetimeTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public LifetimeTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class RefTypeSyntax : ValueTypeSyntax
	{
		public TypeNameSyntax TypeName { get; }

		public RefTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public RefTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeSyntax : SyntaxNode
	{
		public TypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ReturnTypeSyntax : SyntaxNode
	{
		public ReturnTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ReturnTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class LifetimeSyntax : SyntaxNode
	{
		public LifetimeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public LifetimeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class FuncTypeParameterListSyntax : SyntaxNode
	{
		public IReadOnlyList<FuncTypeParameterSyntax> FuncTypeParameters { get; }

		public FuncTypeParameterListSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public FuncTypeParameterListSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class FuncTypeParameterSyntax : SyntaxNode
	{
		public IReadOnlyList<ParameterModifierSyntax> ParameterModifiers { get; }
		public ValueTypeSyntax ValueType { get; }

		public FuncTypeParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public FuncTypeParameterSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ConstExpressionSyntax : SyntaxNode
	{
		public ConstExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ConstExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeParameterBoundConstraintClauseSyntax : TypeParameterConstraintClauseSyntax
	{
		public TypeParameterSyntax TypeParameter { get; }
		public IReadOnlyList<TypeParameterConstraintSyntax> TypeParameterConstraints { get; }

		public TypeParameterBoundConstraintClauseSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeParameterBoundConstraintClauseSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeParameterRangeConstraintClauseSyntax : TypeParameterConstraintClauseSyntax
	{
		public TypeParameterSyntax TypeParameter { get; }
		public IntLiteralToken IntLiteral { get; }

		public TypeParameterRangeConstraintClauseSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeParameterRangeConstraintClauseSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ConstructorConstraintSyntax : TypeParameterConstraintSyntax
	{
		public ConstructorConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ConstructorConstraintSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeConstraintSyntax : TypeParameterConstraintSyntax
	{
		public TypeNameSyntax TypeName { get; }

		public TypeConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeConstraintSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeListParameterConstraintSyntax : TypeParameterConstraintSyntax
	{
		public TypeParameterSyntax TypeParameter { get; }

		public TypeListParameterConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeListParameterConstraintSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ConstructorSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public IdentifierSyntax Identifier { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<WhereClauseSyntax> WhereClauses { get; }
		public ConstructorInitializerSyntax ConstructorInitializer { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public ConstructorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ConstructorSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class CopyConstructorSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public ExplicitModifierSyntax ExplicitModifier { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<WhereClauseSyntax> WhereClauses { get; }
		public ConstructorInitializerSyntax ConstructorInitializer { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public CopyConstructorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public CopyConstructorSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DestructorSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public ParameterListSyntax ParameterList { get; }
		public MethodBodySyntax MethodBody { get; }

		public DestructorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public DestructorSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ConversionMethodSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public ExplicitModifierSyntax ExplicitModifier { get; }
		public TypeArgumentsSyntax TypeArguments { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public ConversionMethodSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ConversionMethodSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class FieldSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public IdentifierSyntax Identifier { get; }
		public ValueTypeSyntax ValueType { get; }
		public ExpressionSyntax Expression { get; }

		public FieldSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public FieldSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AccessorSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public MethodInheritanceModifierSyntax MethodInheritanceModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public AsyncModifierSyntax AsyncModifier { get; }
		public IdentifierSyntax Identifier { get; }
		public TypeArgumentsSyntax TypeArguments { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public AccessorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AccessorSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IndexerSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public MethodInheritanceModifierSyntax MethodInheritanceModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public AsyncModifierSyntax AsyncModifier { get; }
		public TypeArgumentsSyntax TypeArguments { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public IndexerSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public IndexerSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MethodSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public MethodInheritanceModifierSyntax MethodInheritanceModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public AsyncModifierSyntax AsyncModifier { get; }
		public IdentifierSyntax Identifier { get; }
		public TypeArgumentsSyntax TypeArguments { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public MethodSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MethodSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class OperatorOverloadSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public MethodInheritanceModifierSyntax MethodInheritanceModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public AsyncModifierSyntax AsyncModifier { get; }
		public OverloadableOperatorSyntax OverloadableOperator { get; }
		public ParameterListSyntax ParameterList { get; }
		public ReturnTypeSyntax ReturnType { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<ContractSyntax> Contracts { get; }
		public MethodBodySyntax MethodBody { get; }

		public OperatorOverloadSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public OperatorOverloadSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NestedClassDeclarationSyntax : MemberSyntax
	{
		public IReadOnlyList<AttributeSyntax> Attributes { get; }
		public AccessModifierSyntax AccessModifier { get; }
		public SafetyModifierSyntax SafetyModifier { get; }
		public ClassInheritanceModifierSyntax ClassInheritanceModifier { get; }
		public IdentifierSyntax Identifier { get; }
		public TypeParametersSyntax TypeParameters { get; }
		public BaseTypesSyntax BaseTypes { get; }
		public IReadOnlyList<TypeParameterConstraintClauseSyntax> TypeParameterConstraintClauses { get; }
		public IReadOnlyList<MemberSyntax> Members { get; }

		public NestedClassDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NestedClassDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ParameterListSyntax : SyntaxNode
	{
		public IReadOnlyList<ParameterSyntax> Parameters { get; }

		public ParameterListSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ParameterListSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NamedParameterSyntax : ParameterSyntax
	{
		public IReadOnlyList<ParameterModifierSyntax> Modifiers { get; }
		public IdentifierSyntax Identifier { get; }
		public ValueTypeSyntax ValueType { get; }

		public NamedParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NamedParameterSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class SelfParameterSyntax : ParameterSyntax
	{
		public SelfParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public SelfParameterSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ParameterModifierSyntax : SyntaxNode
	{
		public ParameterModifierSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ParameterModifierSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class WhereClauseSyntax : SyntaxNode
	{
		public TypeNameSyntax TypeName { get; }
		public IReadOnlyList<GenericConstraintSyntax> Constraints { get; }

		public WhereClauseSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public WhereClauseSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class GenericConstraintSyntax : SyntaxNode
	{
		public GenericConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public GenericConstraintSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ConstructorInitializerSyntax : SyntaxNode
	{
		public ArgumentListSyntax ArgumentList { get; }

		public ConstructorInitializerSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ConstructorInitializerSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ArgumentListSyntax : SyntaxNode
	{
		public IReadOnlyList<ExpressionSyntax> Expressions { get; }

		public ArgumentListSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ArgumentListSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class BlockMethodBodySyntax : MethodBodySyntax
	{
		public IReadOnlyList<StatementSyntax> Statements { get; }

		public BlockMethodBodySyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public BlockMethodBodySyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NoMethodBodySyntax : MethodBodySyntax
	{
		public NoMethodBodySyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NoMethodBodySyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class OverloadableOperatorSyntax : SyntaxNode
	{
		public OverloadableOperatorSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public OverloadableOperatorSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class VariableDeclarationStatementSyntax : StatementSyntax
	{
		public LocalVariableDeclarationSyntax LocalVariableDeclaration { get; }

		public VariableDeclarationStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public VariableDeclarationStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnsafeBlockStatementSyntax : StatementSyntax
	{
		public IReadOnlyList<StatementSyntax> Statements { get; }

		public UnsafeBlockStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public UnsafeBlockStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class BlockStatementSyntax : StatementSyntax
	{
		public IReadOnlyList<StatementSyntax> Statements { get; }

		public BlockStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public BlockStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class EmptyStatementSyntax : StatementSyntax
	{
		public EmptyStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public EmptyStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ExpressionStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }

		public ExpressionStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ExpressionStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ReturnStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }

		public ReturnStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ReturnStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ThrowStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }

		public ThrowStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ThrowStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IfStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Condition { get; }
		public StatementSyntax Then { get; }
		public StatementSyntax Else { get; }

		public IfStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public IfStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class LetIfStatementSyntax : StatementSyntax
	{
		public LocalVariableDeclarationSyntax LocalVariableDeclaration { get; }
		public StatementSyntax Then { get; }
		public StatementSyntax Else { get; }

		public LetIfStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public LetIfStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ForStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }
		public StatementSyntax Statement { get; }

		public ForStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ForStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class WhileStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }
		public StatementSyntax Statement { get; }

		public WhileStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public WhileStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DeleteStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }

		public DeleteStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public DeleteStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ContinueStatementSyntax : StatementSyntax
	{
		public ContinueStatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ContinueStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class SimpleLocalVariableDeclarationSyntax : LocalVariableDeclarationSyntax
	{
		public IdentifierSyntax Identifier { get; }
		public ValueTypeSyntax ValueType { get; }
		public ExpressionSyntax Expression { get; }

		public SimpleLocalVariableDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public SimpleLocalVariableDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DestructureLocalVariableDeclarationSyntax : LocalVariableDeclarationSyntax
	{
		public IReadOnlyList<IdentifierSyntax> Identifiers { get; }
		public ValueTypeSyntax ValueType { get; }
		public ExpressionSyntax Expression { get; }

		public DestructureLocalVariableDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public DestructureLocalVariableDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ParenthesizedExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public ParenthesizedExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ParenthesizedExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MagnitudeExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public MagnitudeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MagnitudeExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MemberExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }
		public IdentifierSyntax Identifier { get; }

		public MemberExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MemberExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PlacementDeleteExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public PlacementDeleteExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public PlacementDeleteExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DotDotExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public DotDotExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public DotDotExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ToExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax From { get; }
		public ExpressionSyntax To { get; }

		public ToExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ToExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class CallExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }
		public ArgumentListSyntax ArgumentList { get; }

		public CallExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public CallExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ArrayAccessExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }
		public ArgumentListSyntax ArgumentList { get; }

		public ArrayAccessExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ArrayAccessExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AwaitExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public AwaitExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AwaitExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NullCheckExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public NullCheckExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NullCheckExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnaryExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public UnaryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public UnaryExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MultiplicativeExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public MultiplicativeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MultiplicativeExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AdditiveExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public AdditiveExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AdditiveExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ComparativeExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public ComparativeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ComparativeExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class EqualityExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public EqualityExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public EqualityExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AndExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public AndExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AndExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class XorExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public XorExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public XorExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class OrExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public OrExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public OrExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class CoalesceExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public CoalesceExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public CoalesceExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class InExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lhs { get; }
		public ExpressionSyntax Rhs { get; }

		public InExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public InExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NewExpressionSyntax : ExpressionSyntax
	{
		public ArgumentListSyntax PlacementArguments { get; }
		public ArgumentListSyntax ConstructorArguments { get; }

		public NewExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NewExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NewMemoryExpressionSyntax : ExpressionSyntax
	{
		public TypeArgumentsSyntax TypeArguments { get; }
		public ArgumentListSyntax ArgumentList { get; }

		public NewMemoryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NewMemoryExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NewObjectExpressionSyntax : ExpressionSyntax
	{
		public BaseTypesSyntax BaseTypes { get; }
		public ArgumentListSyntax ArgumentList { get; }
		public IReadOnlyList<MemberSyntax> Members { get; }

		public NewObjectExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NewObjectExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DeleteMemoryExpressionSyntax : ExpressionSyntax
	{
		public ArgumentListSyntax ArgumentList { get; }

		public DeleteMemoryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public DeleteMemoryExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class CastExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }
		public TypeNameSyntax TypeName { get; }

		public CastExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public CastExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TryExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public TryExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TryExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IfExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Condition { get; }
		public ExpressionSyntax Then { get; }
		public ExpressionSyntax Else { get; }

		public IfExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public IfExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AssignmentExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Lvalue { get; }
		public ExpressionSyntax Rvalue { get; }

		public AssignmentExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public AssignmentExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class LambdaExpressionSyntax : ExpressionSyntax
	{
		public LambdaExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public LambdaExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NameExpressionSyntax : ExpressionSyntax
	{
		public SimpleNameSyntax SimpleName { get; }

		public NameExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NameExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NullLiteralExpressionSyntax : ExpressionSyntax
	{
		public NullLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NullLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class SelfExpressionSyntax : ExpressionSyntax
	{
		public SelfExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public SelfExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class BooleanLiteralExpressionSyntax : ExpressionSyntax
	{
		public BooleanLiteralToken BooleanLiteral { get; }

		public BooleanLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public BooleanLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IntLiteralExpressionSyntax : ExpressionSyntax
	{
		public IntLiteralToken IntLiteral { get; }

		public IntLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public IntLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UninitializedExpressionSyntax : ExpressionSyntax
	{
		public UninitializedExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public UninitializedExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class StringLiteralExpressionSyntax : ExpressionSyntax
	{
		public StringLiteralToken StringLiteral { get; }

		public StringLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public StringLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class CharLiteralExpressionSyntax : ExpressionSyntax
	{
		public CharLiteralToken CharLiteral { get; }

		public CharLiteralExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public CharLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnsafeExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public UnsafeExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public UnsafeExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DeclarationSyntax : SyntaxNode
	{
		public DeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public DeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ContractSyntax : SyntaxNode
	{
		public ContractSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ContractSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class SimpleNameSyntax : SyntaxNode
	{
		public SimpleNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public SimpleNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NameSyntax : SyntaxNode
	{
		public NameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public NameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeNameSyntax : SyntaxNode
	{
		public TypeNameSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ValueTypeSyntax : SyntaxNode
	{
		public ValueTypeSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ValueTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeParameterConstraintClauseSyntax : SyntaxNode
	{
		public TypeParameterConstraintClauseSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeParameterConstraintClauseSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeParameterConstraintSyntax : SyntaxNode
	{
		public TypeParameterConstraintSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public TypeParameterConstraintSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MemberSyntax : SyntaxNode
	{
		public MemberSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MemberSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ParameterSyntax : SyntaxNode
	{
		public ParameterSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ParameterSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MethodBodySyntax : SyntaxNode
	{
		public MethodBodySyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public MethodBodySyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class StatementSyntax : SyntaxNode
	{
		public StatementSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public StatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class LocalVariableDeclarationSyntax : SyntaxNode
	{
		public LocalVariableDeclarationSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public LocalVariableDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ExpressionSyntax : SyntaxNode
	{
		public ExpressionSyntax(IEnumerable<ISyntax> allChildren)
			: base(allChildren)
		{
		}

		public ExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

}
