Tools\Cmd\bin\Debug\gen.exe parser Parser\PreAdamantParser.parse

cd Parser\
CALL ..\Tools\ANTLR\antlr4.bat PreAdamantParser_Antlr.g4 -lib ..\Lexer\ -package PreAdamant.Compiler.Parser.Antlr
PAUSE