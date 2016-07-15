

unicodeEscape =  "\\u" ( HexDigit{4} | "(" HexDigit{1, 6} ")" );
hexDigit = [0-9a-fA-F];
decimalDigit = [0-9];