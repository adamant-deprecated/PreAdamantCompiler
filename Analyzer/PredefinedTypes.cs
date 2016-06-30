using System.Collections.Generic;
using PreAdamant.Compiler.Parser;
using static PreAdamant.Compiler.Parser.PreAdamantParser;

namespace PreAdamant.Compiler.Analyzer
{
	public static class PredefinedTypes
	{
		static PredefinedTypes()
		{
			var keywordTypes = new Dictionary<string, Symbol>();
			DefineInt(keywordTypes, "int", 32, true);
			DefineInt(keywordTypes, "uint", 32, false);

			// void
			var symbol = Symbol.For(null, "void", default(ClassDeclarationContext), true);
			keywordTypes.Add("void", symbol);

			// string
			symbol = Symbol.For(null, "string", default(ClassDeclarationContext), true);
			keywordTypes.Add("string", symbol);

			Keyword = keywordTypes;
		}

		private static void DefineInt(Dictionary<string, Symbol> keywordTypes, string name, int bits, bool signed)
		{
			var symbol = Symbol.For(null, name, default(ClassDeclarationContext), true);
			keywordTypes.Add(name, symbol);
		}

		public static readonly IReadOnlyDictionary<string, Symbol> Keyword;
		// TODO define predefined package types
	}
}
