using System.Collections.Generic;
using PreAdamant.Compiler.Parser;
using static PreAdamant.Compiler.Syntax.PreAdamantParser;

namespace PreAdamant.Compiler.Analyzer
{
	public static class PredefinedTypes
	{
		//static PredefinedTypes()
		//{
		//	var keywordTypes = new Dictionary<string, Symbol>();
		//	DefineInt(keywordTypes, "int", 32, true);
		//	DefineInt(keywordTypes, "uint", 32, false);

		//	// Really the size of these varies by platform
		//	DefineInt(keywordTypes, "size", 64, false);
		//	DefineInt(keywordTypes, "offset", 64, true);

		//	// void
		//	var structSymbol = Symbol.For(null, "void", default(StructDeclarationContext), true);
		//	keywordTypes.Add("void", structSymbol);

		//	// string
		//	var classSymbol = Symbol.For(null, "string", default(ClassDeclarationContext), true);
		//	keywordTypes.Add("string", classSymbol);

		//	Keyword = keywordTypes;
		//}

		//private static void DefineInt(Dictionary<string, Symbol> keywordTypes, string name, int bits, bool signed)
		//{
		//	var symbol = Symbol.For(null, name, default(StructDeclarationContext), true);
		//	keywordTypes.Add(name, symbol);
		//}

		//public static readonly IReadOnlyDictionary<string, Symbol> Keyword;
		//// TODO define predefined package types
	}
}
