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
declaration: identifier;

// Labeled Alternatives Rules
