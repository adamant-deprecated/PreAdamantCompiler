
unicodeEscape =  "\\u" ( hexDigit{4} | "(" hexDigit{1, 6} ")" );
hexDigit = [0-9a-fA-F];

identifierStartChar = \p{Letter} | "_" | unicodeEscape;
identifierPartChar =
	  \p{Letter}
	| \p{Digit}
	| \p{Connector_Punctuation}
	| \p{Non_Spacing_Mark}
	| \p{Spacing_Combining_Mark}
	| \p{Format}
	| unicodeEscape
	;