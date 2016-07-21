Tools\Cmd\bin\Debug\gen.exe parser Syntax\PreAdamantParser.parse

cd Syntax\
CALL ..\Tools\ANTLR\antlr4.bat PreAdamantParser_Antlr.g4 -lib ..\Lexer\ -package PreAdamant.Compiler.Syntax.Antlr
PAUSE