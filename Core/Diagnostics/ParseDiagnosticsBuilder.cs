using System.Collections.Generic;

namespace PreAdamant.Compiler.Core.Diagnostics
{
	public class ParseDiagnosticsBuilder
	{
		public readonly ISourceText SourceFile;
		private readonly IList<Diagnostic> diagnostics;
		public bool Any { get; private set; }

		public ParseDiagnosticsBuilder(ISourceText sourceFile, IList<Diagnostic> diagnostics)
		{
			SourceFile = sourceFile;
			this.diagnostics = diagnostics;
		}

		// TODO make methods for specific errors?
		public Diagnostic AntlrParseError(TextPosition position, string message)
		{
			Any = true;
			var diagnostic = new Diagnostic(DiagnosticLevel.FatalCompilationError, CompilerPhase.Parsing, SourceFile, position, message);
			diagnostics.Add(diagnostic);
			return diagnostic;
		}
	}
}
