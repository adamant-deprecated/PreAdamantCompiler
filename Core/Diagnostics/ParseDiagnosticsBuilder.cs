using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Core.Diagnostics
{
	public class ParseDiagnosticsBuilder
	{
		public readonly ISourceText SourceText;
		private IList<Diagnostic> diagnostics;
		public bool Any => diagnostics.Any();

		public ParseDiagnosticsBuilder(ISourceText sourceText)
		{
			SourceText = sourceText;
			diagnostics = new List<Diagnostic>();
		}

		// TODO make methods for specific errors?
		public Diagnostic AntlrParseError(TextSpan sourceSpan, string message)
		{
			var diagnostic = new Diagnostic(DiagnosticLevel.FatalCompilationError, CompilerPhase.Parsing, SourceText, sourceSpan, message);
			diagnostics.Add(diagnostic);
			return diagnostic;
		}

		public IList<Diagnostic> Build()
		{
			var result = diagnostics;
			diagnostics = new List<Diagnostic>();
			return result;
		}
	}
}
