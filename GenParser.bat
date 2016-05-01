cd Parser\
CALL ..\tools\antlr4.bat AdamantParser.g4 -lib ..\Lexer\ -visitor -package PreAdamant.Compiler.Parser
PAUSE