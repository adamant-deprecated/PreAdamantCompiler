Tools\Cmd\bin\Debug\gen.exe lexer Syntax\PreAdamantLexer.lex

cd Syntax\
CALL ..\Tools\ANTLR\antlr4.bat PreAdamantLexer_Antlr.g4 -package PreAdamant.Compiler.Syntax.Antlr


REM CALL ..\Tools\ANTLR\antlr4.bat PreAdamantLexer.g4 -package PreAdamant.Compiler.Lexer

REM cd Preprocessor\
REM CALL ..\..\Tools\ANTLR\antlr4.bat PreprocessorLineLexer.g4 -lib ..\ -package PreAdamant.Compiler.Lexer.Preprocessor
REM CALL ..\..\Tools\ANTLR\antlr4.bat PreprocessorLineParser.g4 -visitor -package PreAdamant.Compiler.Lexer.Preprocessor

PAUSE