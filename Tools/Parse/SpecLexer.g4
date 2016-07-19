lexer grammar SpecLexer;

options
{
	language=CSharp;
}

// Common Fragments

fragment WhitespaceChar
	: ' '
	| '\u000B' // Vertical Tab Character (U+000B)
	| '\t'
	| '\f'
	| '\n'
	| '\r'
	;

fragment InputChar
	: ~[\u000D\u000A\u0085\u2028\u2029] // any char except a new line char
	;

Comment : ('//' InputChar* | '/*' .*? '*/') -> skip;

Whitespace: WhitespaceChar+ -> skip;

// Directives
Parser: '@parser';
Namespace: '@namespace';
Import: '@import';
StartRule: '@startRule';

// Operators
OfType: ':';
Scope: '::';
Dot: '.';
Definition: '=';
Alternation: '|';
Optional: '?';
Repetition: '*';
OneOrMore: '+';
BeginGroup: '(';
EndGroup: ')';
LeftBrace: '{';
RightBrace: '}';
Terminator: ';';
Comma: ',';

// Terminals
Number: '0' | [1-9][0-9]*;
Identifier: [a-zA-Z][a-zA-Z0-9_]*;
Literal: '"' ~["]+ '"';

// Errors
InvalidKeyword: '@' Identifier;
UnexpectedChar: [^];