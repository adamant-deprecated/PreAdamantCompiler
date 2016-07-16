parser grammar SpecParser;

options
{
	language=CSharp;
	tokenVocab=SpecLexer;
}


// Directives
spec: (directive | parseRule)*;

directive
	: '@lexer' Identifier ';'										#NameDirective
	| '@namespace' Identifier ('.' Identifier)* ';'					#NamespaceDirective
	| '@import' (alias=Identifier '=')? lexerName=Identifier ';'	#ImportDirective
	| '@startMode' Identifier ';'									#StartModeDirective
	| '@channels' channels+=Identifier (',' channels+=Identifier)* ';'	#ChannelsDirective
	| '@include' lexerName=Identifier '::' ruleName=Identifier ';'	#IncludeDirective
	| '@modes' modes+=Identifier (',' modes+=Identifier)*
		'{' (directive | parseRule)* '}'		#ModesDirective
	;

parseRule: name=Identifier (':' base=Identifier)? ('=' pattern ('->' commands+=command (',' commands+=command)*)?)? ';' ;

pattern
	: '[' negate=Caret? charSet* ']'		#CharClassPattern
	| '(' pattern ')'						#GroupingPattern
	| lexerName=Identifier '::' ruleName=Identifier	#ImportedRulePattern
	| pattern '?'							#OptionalPattern
	| pattern '*'							#ZeroOrMorePattern
	| pattern '+'							#OneOrMorePattern
	| pattern '{' min=Number (range=',' max=Number?)? '}'	#RepeatPattern
	| '!' pattern							#NegatePattern
	| '~' pattern							#UpToPattern
	| pattern pattern						#ConcatPattern
	| pattern '&' pattern					#IntersectionPattern
	| pattern Subtraction pattern			#DifferencePattern
	| pattern '|' pattern					#AlternationPattern
	| ruleName=Identifier					#RulePattern
	| '.'									#AnyPattern
	| Literal								#LiteralPattern
	;

charSet
	: char Dash char				#CharRange
	| char							#SingleChar
	| Dash							#DashChar
	;

char: Char | EscapedChar | EscapedDash | Caret;

command
	: '@mode' '(' modeName=Identifier ')'		#ModeCommand
	| '@pushMode' '(' modeName=Identifier  ')'	#PushModeCommand
	| '@popMode'								#PopModeCommand
	| '@skip'									#SkipCommand
	| '@more'									#ModeCommand
	| '@type' '(' Identifier ')'				#TypeCommand
	| '@channel' '(' channel=Identifier ')'		#ChannelCommand
	| '@error'									#ErrorCommand
	| '@capture'								#CaptureCommand
	| '@decode' '(' base=Number ')'				#DecodeCommand
	| '@text' '(' Literal ')'					#TextCommand
	| ActionCmd									#ActionCommand
	;
