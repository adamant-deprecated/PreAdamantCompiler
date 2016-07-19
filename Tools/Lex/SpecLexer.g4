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
ModeCmd: '@mode';
PushModeCmd: '@pushMode';
PopModeCmd: '@popMode';
SkipCmd: '@skip';
MoreCmd: '@more';
TypeCmd: '@type';
ChannelCmd: '@channel';
ErrorCmd: '@error';
CaptureCmd: '@capture';
DecodeCmd: '@decode';
TextCmd: '@text';
ActionCmd: '@action';

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
OneOrMore: '+';
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

// Predefined Character Classes (needs to be before Literal which includes invalid escape chars)
PredefinedClass
	: '\\d' | '\\D'
	| '\\s' | '\\S'
	| '\\w' | '\\W'
	| '\\p{' Identifier '}' |'\\P{' Identifier '}'
	| '\\R'
	;

// Terminals
Number: '0' | [1-9][0-9]*;
Identifier: [a-zA-Z][a-zA-Z0-9_]*;
Literal: '"' LiteralChar+ '"' | EscapedChar | InvalidEscapedChar;

fragment LiteralChar : EscapedChar | InvalidEscapedChar | ~[\\"];
fragment HexDigit: [a-fA-F0-9];

// Errors
InvalidKeyword: '@' Identifier;
UnexpectedChar: [^];


// Character Classes
mode CharacterClass;
Char: ~[\\\-\]^];
Caret: '^';
PredefinedClass_CharClass: PredefinedClass -> type(PredefinedClass);
EscapedChar // These string escapes match Adamant
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
	| '\\u{' HexDigit HexDigit? HexDigit? HexDigit? HexDigit? HexDigit? '}' // for consistency with other regular expressions we use {} instead of () like Adamant
	;
InvalidEscapedChar: '\\' InputChar;
EscapedDash: '\\-';
EscapedRightBracket: '\\]';
Dash: '-';
EndCharClass: ']' -> popMode;