lexer grammar AntlrPreAdamantLexer;

options { language=CSharp; }

// Fragments

// Rules
DummyRule__: ;

mode Code;

DocComment: '///' InputChar*;
LineComment: '//' InputChar* -> channel(Trivia);
BlockComment: '/*' (.*?('*/')) -> channel(Trivia);
Using: 'using';
Namespace: 'namespace';
Class: 'class';
Struct: 'struct';
Enum: 'enum';
New: 'new';
NewPanic: 'new!';
NewResult: 'new?';
NewPointer: 'new*';
NewPointerPanic: 'new*!';
NewNullablePointer: 'new*?';
Delete: 'delete';
Self: 'self';
Uninitialized: 'uninitialized';
Where: 'where';
Base: 'base';
Operator: 'operator';
External: 'external';
Var: 'var';
Let: 'let';
Get: 'get';
Set: 'set';
Sealed: 'sealed';
Override: 'override';
Abstract: 'abstract';
Params: 'params';
Loop: 'loop';
While: 'while';
If: 'if';
Else: 'else';
For: 'for';
In: 'in';
Switch: 'switch';
Break: 'break';
Continue: 'continue';
Return: 'return';
Try: 'try';
TryPanic: 'try!';
TryResult: 'try?';
Catch: 'catch';
Finally: 'finally';
Throw: 'throw';
Implicit: 'implicit';
Explicit: 'explicit';
Conversion: 'conversion';
As: 'as';
AsPanic: 'as!';
AsResult: 'as?';
Public: 'public';
Private: 'private';
Protected: 'protected';
Internal: 'internal';
Safe: 'safe';
Unsafe: 'unsafe';
Own: 'own';
Mutable: 'mut';
Immutable: 'immut';
Copy: 'copy';
Move: 'move';
Ref: 'ref';
Async: 'async';
Await: 'await';
Requires: 'requires';
Ensures: 'ensures';
Void: 'void';
String: 'string';
ByteType: 'byte';
IntType: 'int' IntLiteral?;
UIntType: 'uint' IntLiteral?;
FloatType: 'float' IntLiteral?;
SizeType: 'size';
OffsetType: 'offset';
UnsafeArrayType: 'UnsafeArray';
Panic: '!';
ReservedWord: 'yield' | 'bit_and' | 'bit_or' | 'bit_xor' | 'bit_not' | 'bit_shift_left' | 'bit_shift_right' | 'partial' | 'fixed' IntLiteral '.' IntLiteral | 'decimal' IntLiteral?;

mode PreprocessorSkip;


