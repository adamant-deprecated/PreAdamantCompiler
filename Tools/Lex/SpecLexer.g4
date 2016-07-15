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
Lexer: '@lexer';
Namespace: '@namespace';
Modes: '@modes';
Channels: '@channels';
Import: '@import';
StartMode: '@startMode';
Include: '@include';

// Commands
Mode: '@mode';
PushMode: '@pushMode';
PopMode: '@popMode';
Skip: '@skip';
More: '@more';
Type: '@type';
Channel: '@channel';
Error: '@error';
Capture: '@capture';
Decode: '@decode';
Text: '@text';
Action: '<%' .*? '%>';

// Operators
OfType: ':';
Scope: '::';
Definition: '=';
Alternation: '|';
BeginCharClass: '[' -> pushMode(CharacterClass);
AnyChar: '.';
Optional: '?';
Complement: '!';
Repetition: '*';
Intersection: '&';
Subtraction: '-';
Upto: '~';
BeginGroup: '(';
EndGroup: ')';
BeginningOfLine: '^';
EndOfLine: '$';
LeftBrace: '{';
RightBrace: '}';
BeginCommands: '->';
Terminator: ';';
Comma: ',';

// Terminals
Number: '0' | [1-9][0-9]*;
Identifier: [a-zA-Z][a-zA-Z0-9_]*;
Literal: '"' LiteralChar+ '"' | EscapeChar;

fragment LiteralChar
	: EscapeChar
	| [^\\"]
	;

fragment EscapeChar // These string escapes match Adamant
	: '\\t'
	| '\\n'
	| '\\r'
	| '\\b'
	| '\\f'
	| '\\0'
	| '\\a'
	| '\\v'
	| '\\"'
	| '\\{'
	| '\\\''
	| '\\\\'
	| '\\x' HexDigit HexDigit
	| '\\u' HexDigit HexDigit HexDigit HexDigit
	| '\\U' HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit
	| '\\u{' HexDigit HexDigit? HexDigit? HexDigit? HexDigit? HexDigit? '}'
	;

fragment HexDigit: [a-fA-F0-9];

// Errors
InvalidKeyword: '@' Identifier;
UnexpectedChar: [^];

// Character Classes
mode StartCharacterClass;
NegateCharClass: '^' -> mode(CharacterClass);

mode CharacterClass;
Char: (EscapeChar | [^\\\-\]]) -> mode(CharacterClass);
EscapeDash: '\\-' -> type(Char), mode(CharacterClass);
EscapeRightBracket: '\\]' -> type(Char), mode(CharacterClass);
CharRange: '-' -> mode(CharacterClass);
EndCharClass: ']' -> popMode;