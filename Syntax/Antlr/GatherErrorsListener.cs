using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Core.Diagnostics;

namespace PreAdamant.Compiler.Syntax.Antlr
{
	internal class GatherErrorsListener : IAntlrErrorListener<IToken>
	{
		private readonly ParseDiagnosticsBuilder diagnostics;

		public GatherErrorsListener(ParseDiagnosticsBuilder diagnostics)
		{
			this.diagnostics = diagnostics;
		}

		public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			// TODO we really should distinguish lexing and parsing errors
			// ANTLR StopIndex is inside the symbol where ours is after the symbol
			diagnostics.AntlrParseError(TextSpan.FromTo(offendingSymbol.StartIndex, offendingSymbol.StopIndex + 1), msg);
		}
	}
}
