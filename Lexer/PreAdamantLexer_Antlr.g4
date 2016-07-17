lexer grammar PreAdamantLexer_Antlr;

channels { Trivia }
options { language=CSharp; }

// Fragments

// Rules
fragment Lex__DummyFragment: '~~DummyFragment~~';

mode Code;

Whitespace: (Lex__Unicode__Whitespace+) -> channel(Trivia);
Newline: ('\r\n'|[\r\n\u000B\f\u0085\u2028\u2029]) -> channel(Trivia);
PreprocessorLine: (Lex__Unicode__Whitespace*) '#' ((~[\r\n\u000B\f\u0085\u2028\u2029])*) { Preprocess(); } -> channel(Trivia);
DocComment: '///' ((~[\r\n\u000B\f\u0085\u2028\u2029])*);
LineComment: '//' ((~[\r\n\u000B\f\u0085\u2028\u2029])*) -> channel(Trivia);
BlockComment: '/*' (.*? '*/') -> channel(Trivia);
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
IntType: 'int' (IntLiteral?);
UIntType: 'uint' (IntLiteral?);
FloatType: 'float' (IntLiteral?);
SizeType: 'size';
OffsetType: 'offset';
UnsafeArrayType: 'UnsafeArray';
Panic: '!';
ReservedWord: 'yield' | 'bit_and' | 'bit_or' | 'bit_xor' | 'bit_not' | 'bit_shift_left' | 'bit_shift_right' | 'partial' | 'fixed' IntLiteral '.' IntLiteral | 'decimal' (IntLiteral?);
BooleanLiteral: 'true' | 'false';
IntLiteral: '0' | [1-9] (('_' | [0-9])*);
NullLiteral: 'null';
StringLiteral: '\"' (((~[\r\n\u000B\f\u0085\u2028\u2029\\]) | '\\' '\"' | '\\')*) '\"';
CharLiteral: '\'' ((~[\'])*) '\'';

mode PreprocessorSkip;

PreprocessorLineInSkipped: (Lex__Unicode__Whitespace*) '#' ((~[\r\n\u000B\f\u0085\u2028\u2029])*) { Preprocess(); } -> type(PreprocessorLine), channel(Trivia);
PreprocessorSkippedSection: ((~[\r\n\u000B\f\u0085\u2028\u2029#])+) -> channel(Trivia);
PreprocessorSkippedNewline: ('\r\n'|[\r\n\u000B\f\u0085\u2028\u2029]) -> type(Newline), channel(Trivia);

// Unicode Fragments
fragment Lex__Unicode__Whitespace: [\u0009-\u000d\u0020\u0085\u00a0\u1680\u2000-\u200a\u2028-\u2029\u202f\u205f\u3000];