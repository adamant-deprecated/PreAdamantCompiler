parser grammar SpecParser;

options
{
	language=CSharp;
	tokenVocab=SpecLexer;
}

// Directives
spec: (directive | parseRule)*;

directive
	: '@parser' Identifier ';'										#NameDirective
	| '@namespace' Identifier ('.' Identifier)* ';'					#NamespaceDirective
	| '@import' (alias=Identifier '=')? lexerName=Identifier ';'	#ImportDirective
	| '@startRule' Identifier ';'									#StartRuleDirective
	;

parseRule: name=Identifier (':' base=Identifier)? ('=' pattern)? ';' ;

pattern
	: '(' pattern ')'						#GroupingPattern
	| lexerName=Identifier '::' ruleName=Identifier	#ImportedRulePattern
	| pattern '?'							#OptionalPattern
	| pattern '*'							#ZeroOrMorePattern
	| pattern '+'							#OneOrMorePattern
	| pattern '{' separator=Literal (min=Number (range=',' max=Number?)?)? '}'	#RepeatWithSeparatorPattern
	| pattern '{' min=Number (range=',' max=Number?)? '}'	#RepeatPattern
	| pattern pattern						#ConcatPattern
	| pattern '|' pattern					#AlternationPattern
	| ruleName=Identifier					#RulePattern
	| Literal								#LiteralPattern
	;
