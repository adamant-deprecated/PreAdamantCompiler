cd Lexer\
CALL ..\Tools\ANTLR\antlr4.bat PreAdamantLexer.g4 -package PreAdamant.Compiler.Lexer

cd Preprocessor\
CALL ..\..\Tools\ANTLR\antlr4.bat PreprocessorLineLexer.g4 -lib ..\ -package PreAdamant.Compiler.Lexer.Preprocessor
CALL ..\..\Tools\ANTLR\antlr4.bat PreprocessorLineParser.g4 -visitor -package PreAdamant.Compiler.Lexer.Preprocessor

PAUSE