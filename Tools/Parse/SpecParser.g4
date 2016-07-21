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

parseRule: name=Identifier (':' base=Identifier)? ('=' pattern ('{' attributes+=Identifier (',' attributes+=Identifier)*'}')?)? ';' ;

pattern
	: '(' pattern ')'						#GroupingPattern
	| lexerName=Identifier '::' ruleName=Identifier	#ImportedRulePattern
	| pattern '?'							#OptionalPattern
	| pattern '*'							#ZeroOrMorePattern
	| pattern '+'							#OneOrMorePattern
	| pattern '{' separator=Literal (min=Number (range=',' max=Number?)?)? '}'	#RepeatWithSeparatorPattern
	| pattern '{' min=Number (range=',' max=Number?)? '}'	#RepeatPattern
	| label=Identifier ':' pattern			#LabelPattern
	| pattern pattern						#ConcatPattern
	| pattern '|' pattern					#AlternationPattern
	| ruleName=Identifier					#RulePattern
	| Literal								#LiteralPattern
	;

// TODO support templates with rule<a,b,c...> = x<a> | b ...;