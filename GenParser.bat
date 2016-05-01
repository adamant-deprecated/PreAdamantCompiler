cd Parser\
CALL ..\tools\antlr4.bat PreAdamantParser.g4 -lib ..\Lexer\ -visitor -package PreAdamant.Compiler.Parser
PAUSE