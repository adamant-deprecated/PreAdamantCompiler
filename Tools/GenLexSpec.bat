cd Lex\
CALL ..\ANTLR\antlr4.bat SpecLexer.g4 -package PreAdamant.Compiler.Tools.Lex
CALL ..\ANTLR\antlr4.bat SpecParser.g4 -visitor -package PreAdamant.Compiler.Tools.Lex
PAUSE