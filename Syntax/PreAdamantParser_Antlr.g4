parser grammar PreAdamantParser_Antlr;

options
{
	language = CSharp;
	tokenVocab = PreAdamantLexer_Antlr;
}

// Unlabeled Alternatives Rules
compilationUnit: (usingDirective*) (declaration*) EOF;
usingDirective: 'using' namespaceName ';';
identifier: Identifier | EscapedIdentifier;
namespaceName: (identifier('.'identifier)*);
attribute: '@' identifier (('(' argumentList ')')?);
baseTypes: ':' (baseType=name?) ((':' (interfaces+=name(','interfaces+=name)*))?);
accessModifier: 'public' | 'private' | 'protected' | 'internal';
safetyModifier: 'safe' | 'unsafe';
classInheritanceModifier: 'abstract' | 'sealed';
methodInheritanceModifier: 'abstract' | 'override' | 'sealed' | 'sealed' 'override';
explicitModifier: 'implicit' | 'explicit';
asyncModifier: 'async';
typeParameters: '<' (typeParameter(','typeParameter)*) '>';
typeParameter: identifier (isList='...'?) ((':' baseType=typeName)?) | lifetime;
typeArguments: '<' (type(','type)*) '>';
identifierOrPredefinedType: identifier | 'string' | 'byte' | IntType | UIntType | FloatType | SizeType | OffsetType | UnsafeArrayType;
type: valueType | 'void';
returnType: type | '!';
lifetime: '~' identifier | '~' 'self' | '~' 'own';
funcTypeParameterList: '(' ((funcTypeParameter(','funcTypeParameter)*)?) ')';
funcTypeParameter: (parameterModifier*) valueType;
constExpression: IntLiteral | StringLiteral | identifier;
parameterList: '(' ((parameter(','parameter)*)?) ')';
parameterModifier: 'params';
whereClause: 'where' typeName ':' (constraints+=genericConstraint(','constraints+=genericConstraint)*);
genericConstraint: typeName | 'class' | 'struct' | 'copy' '(' ')';
constructorInitializer: ':' ('base' | 'self') '(' argumentList ')';
argumentList: ((expressions+=expression(','expressions+=expression)*)?);
overloadableOperator: '*' | '&' | 'or' | 'and' | 'xor' | '?' | '??' | '.' | '[' ']' | '|' '|';
block: '{' (statement*) '}';

// Labeled Alternatives Rules
declaration
	: 'namespace' namespaceName '{' (usingDirective*) (declaration*) '}' #namespaceDeclaration
	| (attribute*) accessModifier (safetyModifier?) (classInheritanceModifier?) ('mut'?) 'class' className=identifier (typeParameters?) (baseTypes?) (typeParameterConstraintClause*) '{' (member*) '}' #classDeclaration
	| (attribute*) accessModifier (safetyModifier?) ('mut'?) 'struct' structName=identifier (typeParameters?) (baseTypes?) (typeParameterConstraintClause*) '{' (member*) '}' #structDeclaration
	| (attribute*) accessModifier kind=('var' | 'let') identifier ((':' valueType)?) (('=' expression)?) ';' #variableDeclaration
	| (attribute*) accessModifier (safetyModifier?) (asyncModifier?) identifier (typeArguments?) parameterList '->' returnType (typeParameterConstraintClause*) (contract*) methodBody #functionDeclaration
	| 'external' '{' (declaration*) '}' #externalBlockDeclaration
	;

contract
	: 'requires' expression #precondition
	| 'ensures' expression #postcondition
	;

simpleName
	: identifierOrPredefinedType #identifierName
	| identifierOrPredefinedType typeArguments #genericName
	;

name
	: simpleName #unqualifiedName
	| leftName=name '.' rightName=simpleName #qualifiedName
	;

typeName
	: name #namedType
	| typeName '?' #maybeType
	| '*' (isMutable='mut'?) typeName #pointerType
	| ('[' (types+=typeName(','types+=typeName)*) ']' | '[' ']') #tupleType
	| funcTypeParameterList '->' returnType #functionType
	;

valueType
	: (lifetime?) (isMutable='mut'?) typeName #LifetimeType
	| 'ref' ('var'?) (isMutable='mut'?) typeName #RefType
	;

typeParameterConstraintClause
	: 'where' typeParameter ':' (typeParameterConstraint(','typeParameterConstraint)*) #typeParameterBoundConstraintClause
	| 'where' typeParameter ('>=' | '<=' | '<' | '>') IntLiteral #typeParameterRangeConstraintClause
	;

typeParameterConstraint
	: 'new' '(' ')' #constructorConstraint
	| typeName #typeConstraint
	| typeParameter #typeListParameterConstraint
	;

member
	: (attribute*) accessModifier (safetyModifier?) 'new' (identifier?) parameterList (('->' returnType)?) (whereClause*) (constructorInitializer?) (contract*) methodBody #constructor
	| (attribute*) accessModifier (safetyModifier?) explicitModifier 'new' 'copy' parameterList (('->' returnType)?) (whereClause*) (constructorInitializer?) (contract*) methodBody #copyConstructor
	| (attribute*) accessModifier (safetyModifier?) 'delete' parameterList methodBody #destructor
	| (attribute*) accessModifier (safetyModifier?) explicitModifier 'conversion' (typeArguments?) parameterList '->' returnType (typeParameterConstraintClause*) (contract*) methodBody #conversionMethod
	| (attribute*) accessModifier kind=('var' | 'let') ('unsafe'?) identifier ((':' valueType)?) (('=' expression)?) ';' #field
	| (attribute*) accessModifier (methodInheritanceModifier?) (safetyModifier?) (asyncModifier?) kind=('get' | 'set') identifier (typeArguments?) parameterList '->' returnType (typeParameterConstraintClause*) (contract*) methodBody #accessor
	| (attribute*) accessModifier (methodInheritanceModifier?) (safetyModifier?) (asyncModifier?) kind=('get' | 'set') '[' ']' (typeArguments?) parameterList '->' returnType (typeParameterConstraintClause*) (contract*) methodBody #indexer
	| (attribute*) accessModifier (methodInheritanceModifier?) (safetyModifier?) (asyncModifier?) identifier (typeArguments?) parameterList '->' returnType (typeParameterConstraintClause*) (contract*) methodBody #method
	| (attribute*) accessModifier (methodInheritanceModifier?) (safetyModifier?) (asyncModifier?) 'operator' overloadableOperator parameterList '->' returnType (typeParameterConstraintClause*) (contract*) methodBody #operatorOverload
	| (attribute*) accessModifier (safetyModifier?) (classInheritanceModifier?) 'class' identifier (typeParameters?) (baseTypes?) (typeParameterConstraintClause*) '{' (member*) '}' #nestedClassDeclaration
	;

parameter
	: (isVar='var'?) (modifiers+=parameterModifier*) (identifier?) ':' valueType #namedParameter
	| (isRef='ref'?) (isMutable='mut'?) 'self' #selfParameter
	;

methodBody
	: '{' (statement*) '}' #blockMethodBody
	| ';' #noMethodBody
	;

statement
	: localVariableDeclaration ';' #variableDeclarationStatement
	| 'unsafe' '{' (statement*) '}' #unsafeBlockStatement
	| block #blockStatement
	| ';' #emptyStatement
	| expression ';' #expressionStatement
	| 'return' (expression?) ';' #returnStatement
	| 'throw' expression ';' #throwStatement
	| 'if' condition=expression then=block (('else' else=block)?) #ifStatement
	| 'if' localVariableDeclaration then=block (('else' else=block)?) #letIfStatement
	| 'for' (localVariableDeclaration | '_') 'in' expression block #forStatement
	| 'while' expression block #whileStatement
	| 'delete' expression ';' #deleteStatement
	| 'continue' ';' #continueStatement
	;

localVariableDeclaration
	: kind=('var' | 'let') identifier (('?')?) ':' valueType (('=' expression)?) #simpleLocalVariableDeclaration
	| kind=('var' | 'let') '[' (identifier(','identifier)*) ']' ':' valueType (('=' expression)?) #destructureLocalVariableDeclaration
	;

expression
	: '(' expression ')' #parenthesizedExpression
	| '|' expression '|' #magnitudeExpression
	| expression '.' identifier #memberExpression
	| expression '.' 'delete' #placementDeleteExpression
	| lhs=expression '..' rhs=expression #dotDotExpression
	| from=expression 'to' to=expression #toExpression
	| expression '(' argumentList ')' #callExpression
	| expression '[' argumentList ']' #arrayAccessExpression
	| 'await' expression #awaitExpression
	| expression '?' #nullCheckExpression
	| op=('+' | '-' | 'not' | '&' | '*') expression #unaryExpression
	| lhs=expression op=('*' | '/') rhs=expression #multiplicativeExpression
	| lhs=expression op=('+' | '-') rhs=expression #additiveExpression
	| lhs=expression op=('<' | '<=' | '>' | '>=') rhs=expression #comparativeExpression
	| lhs=expression op=('==' | '<>') rhs=expression #equalityExpression
	| lhs=expression 'and' rhs=expression #andExpression
	| lhs=expression 'xor' rhs=expression #xorExpression
	| lhs=expression 'or' rhs=expression #orExpression
	| lhs=expression '??' rhs=expression #coalesceExpression
	| lhs=expression 'in' rhs=expression #inExpression
	| 'new' (('(' placementArguments=argumentList ')')?) (name | 'copy') '(' constructorArguments=argumentList ')' #newExpression
	| 'new' (typeArguments?) '(' argumentList ')' #newMemoryExpression
	| 'new' (baseTypes?) '(' argumentList ')' '{' (member*) '}' #newObjectExpression
	| 'delete' '(' argumentList ')' #deleteMemoryExpression
	| expression kind=('as' | 'as!' | 'as?') typeName #castExpression
	| kind=('try' | 'try!' | 'try?') expression #tryExpression
	| <assoc=right>condition=expression '?' then=expression ':' else=expression #ifExpression
	| <assoc=right>lvalue=expression op=('=' | '*=' | '/=' | '+=' | '-=' | 'and=' | 'xor=' | 'or=') rvalue=expression #assignmentExpression
	| (identifier | parameterList) '->' (expression | '{' (statement*) '}') #lambdaExpression
	| simpleName #nameExpression
	| 'null' #nullLiteralExpression
	| 'self' #selfExpression
	| BooleanLiteral #booleanLiteralExpression
	| IntLiteral #intLiteralExpression
	| 'uninitialized' #uninitializedExpression
	| StringLiteral #stringLiteralExpression
	| CharLiteral #charLiteralExpression
	| 'unsafe' '(' expression ')' #unsafeExpression
	;

