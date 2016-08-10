using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Analyzer
{
	/// <summary>
	/// A binder associates code references with their associated symbols.  Essentially, all the binders together form
	/// the symbol table.
	/// </summary>
	//public class SymbolBinder
	//{
	//	private readonly SymbolBinder containingBinder;
	//	private readonly List<Symbol> symbols;
	//	private readonly string scopeName;

	//	public SymbolBinder(SymbolBinder containingBinder, IEnumerable<Symbol> symbols, string scopeName)
	//	{
	//		this.containingBinder = containingBinder;
	//		this.symbols = symbols.ToList();
	//		this.scopeName = scopeName;
	//	}

	//	public Symbol LookupName(string variableName)
	//	{
	//		var symbol = symbols.SingleOrDefault(s => s.Name == variableName);
	//		if(symbol == null && containingBinder != null)
	//			symbol = containingBinder.LookupName(variableName);

	//		return symbol;
	//	}
	//}
}
