using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Core.Diagnostics;

namespace PreAdamant.Compiler.Parser
{
	public class GatherErrorsListener : IAntlrErrorListener<IToken>
	{
		private readonly ParseDiagnosticsBuilder diagnostics;

		public GatherErrorsListener(ParseDiagnosticsBuilder diagnostics)
		{
			this.diagnostics = diagnostics;
		}

		public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			// TODO we really should distinguish lexing and parsing errors
			diagnostics.AntlrParseError(new TextPosition(offendingSymbol.StartIndex, line - 1, charPositionInLine), msg);
		}
	}
}
