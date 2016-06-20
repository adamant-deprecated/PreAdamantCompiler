using System.Collections.Generic;
using Antlr4.Runtime;
using static PreAdamant.Compiler.Parser.PreAdamantParser;

namespace PreAdamant.Compiler.Parser
{
	public interface IFunctionContext<T>
		where T : ParserRuleContext, IFunctionContext<T>
	{
		Symbol<T> Symbol { get; set; }
		string Name { get; }
		IEnumerable<ParameterContext> Parameters { get; }
		MethodBodyContext methodBody();
	}
}