using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Syntax
{
	public partial class CompilationUnitSyntax : SyntaxNode
	{
		public IReadOnlyList<UsingDirectiveSyntax> UsingDirectives { get; }
		public IReadOnlyList<DeclarationSyntax> Declarations { get; }

		public CompilationUnitSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			UsingDirectives = Children.OfType<UsingDirectiveSyntax>().ToList();
			Declarations = Children.OfType<DeclarationSyntax>().ToList();
		}

		public CompilationUnitSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UsingDirectiveSyntax : SyntaxNode
	{
		public NamespaceNameSyntax NamespaceName { get; }

		public UsingDirectiveSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			NamespaceName = Children.OfType<NamespaceNameSyntax>().SingleOrDefault();
		}

		public UsingDirectiveSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IdentifierSyntax : SyntaxNode
	{
		public IdentifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public NamespaceNameSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Identifiers = Children.OfType<IdentifierSyntax>().ToList();
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

		public NamespaceDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			NamespaceName = Children.OfType<NamespaceNameSyntax>().SingleOrDefault();
			UsingDirectives = Children.OfType<UsingDirectiveSyntax>().ToList();
			Declarations = Children.OfType<DeclarationSyntax>().ToList();
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

		public ClassDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			ClassInheritanceModifier = Children.OfType<ClassInheritanceModifierSyntax>().SingleOrDefault();
			ClassName = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			TypeParameters = Children.OfType<TypeParametersSyntax>().SingleOrDefault();
			BaseTypes = Children.OfType<BaseTypesSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Members = Children.OfType<MemberSyntax>().ToList();
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

		public StructDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			StructName = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			TypeParameters = Children.OfType<TypeParametersSyntax>().SingleOrDefault();
			BaseTypes = Children.OfType<BaseTypesSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Members = Children.OfType<MemberSyntax>().ToList();
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

		public VariableDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			ValueType = Children.OfType<ValueTypeSyntax>().SingleOrDefault();
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public FunctionDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			AsyncModifier = Children.OfType<AsyncModifierSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			TypeArguments = Children.OfType<TypeArgumentsSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
		}

		public FunctionDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ExternalBlockDeclarationSyntax : DeclarationSyntax
	{
		public IReadOnlyList<DeclarationSyntax> Declarations { get; }

		public ExternalBlockDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Declarations = Children.OfType<DeclarationSyntax>().ToList();
		}

		public ExternalBlockDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PreconditionSyntax : ContractSyntax
	{
		public ExpressionSyntax Expression { get; }

		public PreconditionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public PreconditionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PostconditionSyntax : ContractSyntax
	{
		public ExpressionSyntax Expression { get; }

		public PostconditionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public AttributeSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			ArgumentList = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
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

		public BaseTypesSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			BaseType = Children.OfType<NameSyntax>().SingleOrDefault();
			Interfaces = Children.OfType<NameSyntax>().ToList();
		}

		public BaseTypesSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AccessModifierSyntax : SyntaxNode
	{
		public AccessModifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public SafetyModifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ClassInheritanceModifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public MethodInheritanceModifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ExplicitModifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public AsyncModifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public TypeParametersSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeParameters = Children.OfType<TypeParameterSyntax>().ToList();
		}

		public TypeParametersSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeParameterSyntax : SyntaxNode
	{
		public TypeParameterSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public TypeArgumentsSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Types = Children.OfType<TypeSyntax>().ToList();
		}

		public TypeArgumentsSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IdentifierOrPredefinedTypeSyntax : SyntaxNode
	{
		public IdentifierOrPredefinedTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public IdentifierNameSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			IdentifierOrPredefinedType = Children.OfType<IdentifierOrPredefinedTypeSyntax>().SingleOrDefault();
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

		public GenericNameSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			IdentifierOrPredefinedType = Children.OfType<IdentifierOrPredefinedTypeSyntax>().SingleOrDefault();
			TypeArguments = Children.OfType<TypeArgumentsSyntax>().SingleOrDefault();
		}

		public GenericNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnqualifiedNameSyntax : NameSyntax
	{
		public SimpleNameSyntax SimpleName { get; }

		public UnqualifiedNameSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			SimpleName = Children.OfType<SimpleNameSyntax>().SingleOrDefault();
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

		public QualifiedNameSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			LeftName = Children.OfType<NameSyntax>().SingleOrDefault();
			RightName = Children.OfType<SimpleNameSyntax>().SingleOrDefault();
		}

		public QualifiedNameSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NamedTypeSyntax : TypeNameSyntax
	{
		public NameSyntax Name { get; }

		public NamedTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Name = Children.OfType<NameSyntax>().SingleOrDefault();
		}

		public NamedTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MaybeTypeSyntax : TypeNameSyntax
	{
		public TypeNameSyntax TypeName { get; }

		public MaybeTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeName = Children.OfType<TypeNameSyntax>().SingleOrDefault();
		}

		public MaybeTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PointerTypeSyntax : TypeNameSyntax
	{
		public TypeNameSyntax TypeName { get; }

		public PointerTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeName = Children.OfType<TypeNameSyntax>().SingleOrDefault();
		}

		public PointerTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TupleTypeSyntax : TypeNameSyntax
	{
		public TupleTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public FunctionTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			FuncTypeParameterList = Children.OfType<FuncTypeParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
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

		public LifetimeTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lifetime = Children.OfType<LifetimeSyntax>().SingleOrDefault();
			TypeName = Children.OfType<TypeNameSyntax>().SingleOrDefault();
		}

		public LifetimeTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class RefTypeSyntax : ValueTypeSyntax
	{
		public TypeNameSyntax TypeName { get; }

		public RefTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeName = Children.OfType<TypeNameSyntax>().SingleOrDefault();
		}

		public RefTypeSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeSyntax : SyntaxNode
	{
		public TypeSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ReturnTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public LifetimeSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public FuncTypeParameterListSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			FuncTypeParameters = Children.OfType<FuncTypeParameterSyntax>().ToList();
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

		public FuncTypeParameterSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			ParameterModifiers = Children.OfType<ParameterModifierSyntax>().ToList();
			ValueType = Children.OfType<ValueTypeSyntax>().SingleOrDefault();
		}

		public FuncTypeParameterSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ConstExpressionSyntax : SyntaxNode
	{
		public ConstExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public TypeParameterBoundConstraintClauseSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeParameter = Children.OfType<TypeParameterSyntax>().SingleOrDefault();
			TypeParameterConstraints = Children.OfType<TypeParameterConstraintSyntax>().ToList();
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

		public TypeParameterRangeConstraintClauseSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeParameter = Children.OfType<TypeParameterSyntax>().SingleOrDefault();
			IntLiteral = Children.OfType<IntLiteralToken>().SingleOrDefault();
		}

		public TypeParameterRangeConstraintClauseSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ConstructorConstraintSyntax : TypeParameterConstraintSyntax
	{
		public ConstructorConstraintSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public TypeConstraintSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeName = Children.OfType<TypeNameSyntax>().SingleOrDefault();
		}

		public TypeConstraintSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TypeListParameterConstraintSyntax : TypeParameterConstraintSyntax
	{
		public TypeParameterSyntax TypeParameter { get; }

		public TypeListParameterConstraintSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeParameter = Children.OfType<TypeParameterSyntax>().SingleOrDefault();
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

		public ConstructorSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			WhereClauses = Children.OfType<WhereClauseSyntax>().ToList();
			ConstructorInitializer = Children.OfType<ConstructorInitializerSyntax>().SingleOrDefault();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public CopyConstructorSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			ExplicitModifier = Children.OfType<ExplicitModifierSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			WhereClauses = Children.OfType<WhereClauseSyntax>().ToList();
			ConstructorInitializer = Children.OfType<ConstructorInitializerSyntax>().SingleOrDefault();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public DestructorSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public ConversionMethodSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			ExplicitModifier = Children.OfType<ExplicitModifierSyntax>().SingleOrDefault();
			TypeArguments = Children.OfType<TypeArgumentsSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public FieldSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			ValueType = Children.OfType<ValueTypeSyntax>().SingleOrDefault();
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public AccessorSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			MethodInheritanceModifier = Children.OfType<MethodInheritanceModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			AsyncModifier = Children.OfType<AsyncModifierSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			TypeArguments = Children.OfType<TypeArgumentsSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public IndexerSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			MethodInheritanceModifier = Children.OfType<MethodInheritanceModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			AsyncModifier = Children.OfType<AsyncModifierSyntax>().SingleOrDefault();
			TypeArguments = Children.OfType<TypeArgumentsSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public MethodSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			MethodInheritanceModifier = Children.OfType<MethodInheritanceModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			AsyncModifier = Children.OfType<AsyncModifierSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			TypeArguments = Children.OfType<TypeArgumentsSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public OperatorOverloadSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			MethodInheritanceModifier = Children.OfType<MethodInheritanceModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			AsyncModifier = Children.OfType<AsyncModifierSyntax>().SingleOrDefault();
			OverloadableOperator = Children.OfType<OverloadableOperatorSyntax>().SingleOrDefault();
			ParameterList = Children.OfType<ParameterListSyntax>().SingleOrDefault();
			ReturnType = Children.OfType<ReturnTypeSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Contracts = Children.OfType<ContractSyntax>().ToList();
			MethodBody = Children.OfType<MethodBodySyntax>().SingleOrDefault();
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

		public NestedClassDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Attributes = Children.OfType<AttributeSyntax>().ToList();
			AccessModifier = Children.OfType<AccessModifierSyntax>().SingleOrDefault();
			SafetyModifier = Children.OfType<SafetyModifierSyntax>().SingleOrDefault();
			ClassInheritanceModifier = Children.OfType<ClassInheritanceModifierSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			TypeParameters = Children.OfType<TypeParametersSyntax>().SingleOrDefault();
			BaseTypes = Children.OfType<BaseTypesSyntax>().SingleOrDefault();
			TypeParameterConstraintClauses = Children.OfType<TypeParameterConstraintClauseSyntax>().ToList();
			Members = Children.OfType<MemberSyntax>().ToList();
		}

		public NestedClassDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ParameterListSyntax : SyntaxNode
	{
		public IReadOnlyList<ParameterSyntax> Parameters { get; }

		public ParameterListSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Parameters = Children.OfType<ParameterSyntax>().ToList();
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

		public NamedParameterSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Modifiers = Children.OfType<ParameterModifierSyntax>().ToList();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			ValueType = Children.OfType<ValueTypeSyntax>().SingleOrDefault();
		}

		public NamedParameterSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class SelfParameterSyntax : ParameterSyntax
	{
		public SelfParameterSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ParameterModifierSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public WhereClauseSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeName = Children.OfType<TypeNameSyntax>().SingleOrDefault();
			Constraints = Children.OfType<GenericConstraintSyntax>().ToList();
		}

		public WhereClauseSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class GenericConstraintSyntax : SyntaxNode
	{
		public GenericConstraintSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public ConstructorInitializerSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			ArgumentList = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
		}

		public ConstructorInitializerSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ArgumentListSyntax : SyntaxNode
	{
		public IReadOnlyList<ExpressionSyntax> Expressions { get; }

		public ArgumentListSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expressions = Children.OfType<ExpressionSyntax>().ToList();
		}

		public ArgumentListSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class BlockMethodBodySyntax : MethodBodySyntax
	{
		public IReadOnlyList<StatementSyntax> Statements { get; }

		public BlockMethodBodySyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Statements = Children.OfType<StatementSyntax>().ToList();
		}

		public BlockMethodBodySyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NoMethodBodySyntax : MethodBodySyntax
	{
		public NoMethodBodySyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public OverloadableOperatorSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
		}

		public OverloadableOperatorSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class BlockSyntax : SyntaxNode
	{
		public IReadOnlyList<StatementSyntax> Statements { get; }

		public BlockSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Statements = Children.OfType<StatementSyntax>().ToList();
		}

		public BlockSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class VariableDeclarationStatementSyntax : StatementSyntax
	{
		public LocalVariableDeclarationSyntax LocalVariableDeclaration { get; }

		public VariableDeclarationStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			LocalVariableDeclaration = Children.OfType<LocalVariableDeclarationSyntax>().SingleOrDefault();
		}

		public VariableDeclarationStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnsafeBlockStatementSyntax : StatementSyntax
	{
		public IReadOnlyList<StatementSyntax> Statements { get; }

		public UnsafeBlockStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Statements = Children.OfType<StatementSyntax>().ToList();
		}

		public UnsafeBlockStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class BlockStatementSyntax : StatementSyntax
	{
		public BlockSyntax Block { get; }

		public BlockStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Block = Children.OfType<BlockSyntax>().SingleOrDefault();
		}

		public BlockStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class EmptyStatementSyntax : StatementSyntax
	{
		public EmptyStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public ExpressionStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public ExpressionStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ReturnStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }

		public ReturnStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public ReturnStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ThrowStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }

		public ThrowStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public ThrowStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IfStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Condition { get; }
		public BlockSyntax Then { get; }
		public BlockSyntax Else { get; }

		public IfStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Condition = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Then = Children.OfType<BlockSyntax>().SingleOrDefault();
			Else = Children.OfType<BlockSyntax>().SingleOrDefault();
		}

		public IfStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class LetIfStatementSyntax : StatementSyntax
	{
		public LocalVariableDeclarationSyntax LocalVariableDeclaration { get; }
		public BlockSyntax Then { get; }
		public BlockSyntax Else { get; }

		public LetIfStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			LocalVariableDeclaration = Children.OfType<LocalVariableDeclarationSyntax>().SingleOrDefault();
			Then = Children.OfType<BlockSyntax>().SingleOrDefault();
			Else = Children.OfType<BlockSyntax>().SingleOrDefault();
		}

		public LetIfStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ForStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }
		public BlockSyntax Block { get; }

		public ForStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Block = Children.OfType<BlockSyntax>().SingleOrDefault();
		}

		public ForStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class WhileStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }
		public BlockSyntax Block { get; }

		public WhileStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Block = Children.OfType<BlockSyntax>().SingleOrDefault();
		}

		public WhileStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DeleteStatementSyntax : StatementSyntax
	{
		public ExpressionSyntax Expression { get; }

		public DeleteStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public DeleteStatementSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ContinueStatementSyntax : StatementSyntax
	{
		public ContinueStatementSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public SimpleLocalVariableDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
			ValueType = Children.OfType<ValueTypeSyntax>().SingleOrDefault();
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public DestructureLocalVariableDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Identifiers = Children.OfType<IdentifierSyntax>().ToList();
			ValueType = Children.OfType<ValueTypeSyntax>().SingleOrDefault();
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public DestructureLocalVariableDeclarationSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class ParenthesizedExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public ParenthesizedExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public ParenthesizedExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class MagnitudeExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public MagnitudeExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public MemberExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Identifier = Children.OfType<IdentifierSyntax>().SingleOrDefault();
		}

		public MemberExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class PlacementDeleteExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public PlacementDeleteExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public DotDotExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public ToExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			From = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			To = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public CallExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			ArgumentList = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
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

		public ArrayAccessExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			ArgumentList = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
		}

		public ArrayAccessExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class AwaitExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public AwaitExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public AwaitExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NullCheckExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public NullCheckExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public NullCheckExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnaryExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public UnaryExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public MultiplicativeExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public AdditiveExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public ComparativeExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public EqualityExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public AndExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public XorExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public OrExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public CoalesceExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public InExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rhs = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public NewExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			PlacementArguments = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
			ConstructorArguments = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
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

		public NewMemoryExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			TypeArguments = Children.OfType<TypeArgumentsSyntax>().SingleOrDefault();
			ArgumentList = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
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

		public NewObjectExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			BaseTypes = Children.OfType<BaseTypesSyntax>().SingleOrDefault();
			ArgumentList = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
			Members = Children.OfType<MemberSyntax>().ToList();
		}

		public NewObjectExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DeleteMemoryExpressionSyntax : ExpressionSyntax
	{
		public ArgumentListSyntax ArgumentList { get; }

		public DeleteMemoryExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			ArgumentList = Children.OfType<ArgumentListSyntax>().SingleOrDefault();
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

		public CastExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			TypeName = Children.OfType<TypeNameSyntax>().SingleOrDefault();
		}

		public CastExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class TryExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public TryExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public IfExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Condition = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Then = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Else = Children.OfType<ExpressionSyntax>().SingleOrDefault();
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

		public AssignmentExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Lvalue = Children.OfType<ExpressionSyntax>().SingleOrDefault();
			Rvalue = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public AssignmentExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class LambdaExpressionSyntax : ExpressionSyntax
	{
		public LambdaExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public NameExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			SimpleName = Children.OfType<SimpleNameSyntax>().SingleOrDefault();
		}

		public NameExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class NullLiteralExpressionSyntax : ExpressionSyntax
	{
		public NullLiteralExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public SelfExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public BooleanLiteralExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			BooleanLiteral = Children.OfType<BooleanLiteralToken>().SingleOrDefault();
		}

		public BooleanLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class IntLiteralExpressionSyntax : ExpressionSyntax
	{
		public IntLiteralToken IntLiteral { get; }

		public IntLiteralExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			IntLiteral = Children.OfType<IntLiteralToken>().SingleOrDefault();
		}

		public IntLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UninitializedExpressionSyntax : ExpressionSyntax
	{
		public UninitializedExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
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

		public StringLiteralExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			StringLiteral = Children.OfType<StringLiteralToken>().SingleOrDefault();
		}

		public StringLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class CharLiteralExpressionSyntax : ExpressionSyntax
	{
		public CharLiteralToken CharLiteral { get; }

		public CharLiteralExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			CharLiteral = Children.OfType<CharLiteralToken>().SingleOrDefault();
		}

		public CharLiteralExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class UnsafeExpressionSyntax : ExpressionSyntax
	{
		public ExpressionSyntax Expression { get; }

		public UnsafeExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
			Expression = Children.OfType<ExpressionSyntax>().SingleOrDefault();
		}

		public UnsafeExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

	public partial class DeclarationSyntax : SyntaxNode
	{
		public DeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ContractSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public SimpleNameSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public NameSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public TypeNameSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ValueTypeSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public TypeParameterConstraintClauseSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public TypeParameterConstraintSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public MemberSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ParameterSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public MethodBodySyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public StatementSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public LocalVariableDeclarationSyntax(IEnumerable<ISyntaxNode> allChildren)
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
		public ExpressionSyntax(IEnumerable<ISyntaxNode> allChildren)
			: base(allChildren)
		{
		}

		public ExpressionSyntax(int offset)
			: base(offset)
		{
		}
	}

}
