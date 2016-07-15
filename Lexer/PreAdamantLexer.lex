@lexer PreAdamantLexer;
@namespace PreAdamant.Compiler.Lexer;
@import Common;
@channels Trivia;

@startMode Code;

@modes Code
{
	//*************
	// Comments
	//*************
	DocComment = "///" InputChar*;
	LineComment = "//" InputChar* -> @channel(Trivia);
	BlockComment = "/*" ~"*/" -> @channel(Trivia);

	//*************
	// Keywords
	//*************
	Using: Keyword = "using";
	Namespace: Keyword = "namespace";
	Class: Keyword = "class";
	Struct: Keyword = "struct";
	Enum: Keyword = "enum";
	New: Keyword = "new";
	NewPanic: Keyword = "new!";
	NewResult: Keyword = "new?";
	NewPointer: Keyword = "new*";
	NewPointerPanic: Keyword = "new*!";
	NewNullablePointer: Keyword = "new*?";
	Delete: Keyword = "delete";
	Self: Keyword = "self";
	Uninitialized: Keyword = "uninitialized";
	Where: Keyword = "where";
	Base: Keyword = "base";
	Operator: Keyword = "operator";
	External: Keyword = "external";

	// Properties
	Var: Keyword = "var";
	Let: Keyword = "let";
	Get: Keyword = "get";
	Set: Keyword = "set";

	// Modifiers
	Sealed: Keyword = "sealed";
	Override: Keyword = "override";
	Abstract: Keyword = "abstract";
	Params: Keyword = "params";

	// Control Flow
	Loop: Keyword = "loop";
	While: Keyword = "while";
	If: Keyword = "if";
	Else: Keyword = "else";
	For: Keyword = "for";
	In: Keyword = "in";
	Switch: Keyword = "switch";
	Break: Keyword = "break";
	Continue: Keyword = "continue";
	Return: Keyword = "return";

	// Exceptions
	Try: Keyword = "try";
	TryPanic: Keyword = "try!";
	TryResult: Keyword = "try?";
	Catch: Keyword = "catch";
	Finally: Keyword = "finally";
	Throw: Keyword = "throw";

	// Conversion
	Implicit: Keyword = "implicit";
	Explicit: Keyword = "explicit";
	Conversion: Keyword = "conversion";
	As: Keyword = "as";
	AsPanic: Keyword = "as!";
	AsResult: Keyword = "as?";

	// Access modifiers
	Public: Keyword = "public";
	Private: Keyword = "private";
	Protected: Keyword = "protected";
	Internal: Keyword = "internal";

	// Safety
	Safe: Keyword = "safe";
	Unsafe: Keyword = "unsafe";

	// Lifetime
	Own: Keyword = "own";
	Mutable: Keyword = "mut";
	Immutable: Keyword = "immut";
	Copy: Keyword = "copy";
	Move: Keyword = "move";
	Ref: Keyword = "ref";

	// Async
	Async: Keyword = "async";
	Await: Keyword = "await";

	// Contracts
	Requires: Keyword = "requires";
	Ensures: Keyword = "ensures";

	//*************
	// Predefined Types
	//*************
	Void: Keyword = "void";
	String: Keyword = "string";
	ByteType: Keyword = "byte";
	IntType: Keyword = "int" IntLiteral?;
	UIntType: Keyword = "uint" IntLiteral?;
	FloatType: Keyword = "float" IntLiteral?;
	SizeType: Keyword = "size";
	OffsetType: Keyword = "offset";
	UnsafeArrayType: Keyword = "UnsafeArray";
	Panic = "!";

	//*************
	// Reserved Words
	//*************
	ReservedWord =
		  "yield"
		| "bit_and"
		| "bit_or"
		| "bit_xor"
		| "bit_not"
		| "bit_shift_left"
		| "bit_shift_right"
		| "partial"
		| "fixed" IntLiteral "." IntLiteral // Fixed type
		| "decimal" IntLiteral? // Decimal Type
		; 
}

@modes PreprocessorSkip
{
	
}