parser grammar PreAdamantParser;

options
{
	language=CSharp;
	tokenVocab=PreAdamantLexer;
}

compilationUnit
	: usingDirective*
	  // globalAttribute*
	  declaration*
	  EOF
	;

usingDirective
	: 'using' namespaceName ';' // TODO using names are allowed to be more complicated than this
	;

identifier
	: token=Identifier
	| token=EscapedIdentifier
	;

namespaceName
	: identifiers+=identifier ('.' identifiers+=identifier)*
	;

declaration
	: 'namespace' namespaceName '{' usingDirective* declaration* '}'  #NamespaceDeclaration
	| attribute* accessModifier safetyModifier? classInheritanceModifier? 'class' identifier typeParameters? baseTypes?
		typeParameterConstraintClause*
		'{' member* '}' #ClassDeclaration
	| attribute* accessModifier kind=('var'|'let') identifier (':' referenceType)? ('=' expression)? ';' #VariableDeclaration
	| attribute* accessModifier safetyModifier? identifier typeArguments? parameterList '->' returnType=referenceType typeParameterConstraintClause* contract* methodBody #FunctionDeclaration
	;

contract
	: 'requires' expression #Precondition
	| 'ensures' expression #Postcondition
	;

attribute
	: EscapedIdentifier ('(' ')')? // TODO needs fixed now that escaped identifiers use ` but attributes should still be @
	;

baseTypes
	: (':' baseType=name? (':' interfaces+=name (',' interfaces+=name)*)?)
	;

accessModifier
	: token='public'
	| token='private'
	| token='protected'
	| token='internal'
	;

safetyModifier
	: token='safe'
	| token='unsafe'
	;

classInheritanceModifier
	: token='abstract'
	| token='sealed'
	;

methodInheritanceModifier
	: token='abstract'
	| token='override'
	| token='sealed'
	| token='sealed' token='override'
	;

conversionModifier
	: token='implicit'
	| token='explicit'
	;

asyncModifier
	: token='async'
	;

typeParameters
	: '<' typeParameter (',' typeParameter)* '>'
	;

typeParameter
	: identifier isList='...'? (':' baseType=valueType)?
	| lifetime
	;

typeArguments
	: '<' referenceType (',' referenceType)* '>'
	;

identifierOrPredefinedType
	: identifier
	| token='void'
	| token='string'
	| token='byte'
	| token=IntType
	| token=UIntType
	| token=FloatType
	| token=SizeType
	| token=OffsetType
	| token=UnsafeArrayType
	;

simpleName
	: identifierOrPredefinedType				#IdentifierName
	| identifierOrPredefinedType typeArguments	#GenericName
	;

name
	: simpleName								#SimpleNameName
	| leftName=name '.' rightName=simpleName	#QualifiedName
	;

valueType
	: name																		#NamedType
	| valueType '?'																#MaybeType
	| valueType '*'																#PointerType
	| ('[' types+=valueType (',' types+=valueType)* ']' | '[' ']')				#TupleType
	| funcTypeParameterList '->' referenceType									#FunctionType
	;

referenceType // these are types with lifetimes
	: lifetime? valueType		#ImmutableReferenceType
	| lifetime? 'mut' valueType	#MutableReferenceType
	| 'own' valueType			#OwnedImmutableReferenceType
	| 'own' 'mut' valueType		#OwnedMutableReferenceType
	;

lifetime
	: '~' identifier
	| '~' 'self'
	;

funcTypeParameterList
	: '(' funcTypeParameter (',' funcTypeParameter)* ')'
	| '(' ')'
	;

funcTypeParameter
	: parameterModifier* referenceType
	;

constExpression
	: IntLiteral
	| StringLiteral
	| identifier
	;

typeParameterConstraintClause
	: 'where' typeParameter ':' typeParameterConstraint (',' typeParameterConstraint)*
	| 'where' typeParameter ('>='|'<='|'<'|'>') IntLiteral
	;

typeParameterConstraint
	: 'new' '(' ')'			#ConstructorConstraint
	| valueType				#TypeConstraint
	| typeParameter			#TypeListParameterConstraint // will only be hit for type lists (i.e. "foo...")
	;

member
	: attribute* accessModifier safetyModifier? 'new' identifier? parameterList ('->' returnType=referenceType)? constructorInitializer? contract* methodBody																	#Constructor
	| attribute* accessModifier safetyModifier? 'delete' parameterList methodBody																																				#Destructor
	| attribute* accessModifier safetyModifier? conversionModifier 'conversion' typeArguments? parameterList '->' referenceType typeParameterConstraintClause* contract* methodBody												#ConversionMethod
	| attribute* accessModifier kind=('var'|'let') identifier (':' referenceType)? ('=' expression)? ';'																														#Field
	| attribute* accessModifier methodInheritanceModifier? safetyModifier? asyncModifier? kind=('get'|'set') identifier typeArguments? parameterList '->' referenceType typeParameterConstraintClause* contract* methodBody		#Accessor
	| attribute* accessModifier methodInheritanceModifier? safetyModifier? asyncModifier? kind=('get'|'set') '[' ']' typeArguments? parameterList '->' referenceType typeParameterConstraintClause* contract* methodBody		#Indexer
	| attribute* accessModifier methodInheritanceModifier? safetyModifier? asyncModifier? identifier typeArguments? parameterList '->' returnType=referenceType typeParameterConstraintClause* contract* methodBody				#Method
	| attribute* accessModifier methodInheritanceModifier? safetyModifier? asyncModifier? 'operator' overloadableOperator parameterList '->' returnType=referenceType typeParameterConstraintClause* contract* methodBody		#OperatorOverload
	| attribute* accessModifier safetyModifier? classInheritanceModifier? 'class' identifier typeParameters? baseTypes?
		typeParameterConstraintClause*
		'{' member* '}' #NestedClassDeclaration
	;

parameterList
	: '(' parameters+=parameter (',' parameters+=parameter)* ')'
	| '(' ')'
	;

parameter
	: modifiers+=parameterModifier* identifier? ':' referenceType	#namedParameter
	| modifiers+=parameterModifier* 'own'? 'mut'? token='self'		#selfParameter
	;

parameterModifier
	: 'params'
	;

constructorInitializer
	: ':' 'base' '(' argumentList ')'
	| ':' 'self' '(' argumentList ')'
	;

argumentList
	:  expressions+=expression (',' expressions+=expression)*
	|
	;

methodBody
	: '{' statement* '}'
	| ';'
	;

overloadableOperator
	: '*'
	| '&'
	| 'or'
	| 'and'
	| 'xor'
	| '?'
	| '??'
	| '.'
	| '[' ']'
	| '|' '|'
	;

statement
	: localVariableDeclaration ';'							#VariableDeclarationStatement
	| 'unsafe' '{' statement* '}'							#UnsafeBlockStatement
	| '{' statement* '}'									#BlockStatement
	| ';'													#EmptyStatement
	| expression ';'										#ExpressionStatement
	| 'return' expression? ';'								#ReturnStatement
	| 'throw' expression ';'								#ThrowStatement
	| 'if' '(' condition=expression ')' then=statement ('else' else=statement)?			#IfStatement
	| 'if' '(' localVariableDeclaration ')' then=statement ('else' else=statement)?		#LetIfStatement
	| 'for' '(' (localVariableDeclaration|'_') 'in' expression ')' statement					#ForStatement
	| 'delete' expression ';'								#DeleteStatement
	| 'continue' ';'										#ContinueStatement
	;

localVariableDeclaration
	: kind=('var'|'let') identifier('?')? (':' referenceType)? ('=' expression)?
	;

expression
	: '(' expression ')'									#ParenthesizedExpression
	| '|' expression '|'									#MagnitudeExpression
	| expression '.' identifier								#MemberExpression
	| expression '..' expression							#DotDotExpression
	| expression '->' identifier							#PointerMemberExpression
	| expression '(' argumentList ')'						#CallExpression
	| expression '[' argumentList ']'						#ArrayAccessExpression
	| expression '?'										#NullCheckExpression
	| op=('+'|'-'|'not'|'&'|'*') expression					#UnaryExpression
	| expression op=('*'|'/') expression					#MultiplicativeExpression
	| expression op=('+'|'-') expression					#AdditiveExpression
	| expression op=('<'|'<='|'>'|'>=') expression			#ComparativeExpression
	| lhs=expression op=('=='|'<>') rhs=expression			#EqualityExpression
	| expression 'and' expression							#AndExpression
	| expression 'xor' expression							#XorExpression
	| expression 'or' expression							#OrExpression
	| expression '??' expression							#CoalesceExpression
	| expression 'in' expression							#InExpression
	| 'new' name '(' argumentList ')'						#NewExpression
	| 'new' baseTypes? '(' argumentList ')' '{' member* '}'	#NewObjectExpression
	| expression as=('as'|'as!'|'as?') valueType			#CastExpression
	| try=('try'|'try!'|'try?') expression					#TryExpression
	| <assoc=right> condition=expression '?' then=expression ':' else=expression #IfExpression
	| <assoc=right> lvalue=expression op=('='|'*='|'/='|'+='|'-='|'and='|'xor='|'or=') rvalue=expression #AssignmentExpression
	| simpleName											#NameExpression
	// Since new Class.Constructor() is indistiguishable from new Namespace.Class() we can't parse for named constructor calls here
	| 'null'												#NullLiteralExpression
	| 'self'												#SelfExpression
	| BooleanLiteral										#BooleanLiteralExpression
	| IntLiteral											#IntLiteralExpression
	| 'uninitialized'										#UninitializedExpression
	| StringLiteral											#StringLiteralExpression
	| CharLiteral											#CharLiteralExpression
	;