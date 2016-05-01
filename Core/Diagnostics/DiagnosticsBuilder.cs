using System.Collections.Generic;

namespace PreAdamant.Compiler.Core.Diagnostics
{
	public class DiagnosticsBuilder
	{
		private List<Diagnostic> diagnostics = new List<Diagnostic>();

		public DiagnosticsBuilder()
		{
		}

		public DiagnosticsBuilder(IEnumerable<Diagnostic> diagnostics)
		{
			this.diagnostics.AddRange(diagnostics);
		}

		public void Add(IEnumerable<Diagnostic> diagnostics)
		{
			this.diagnostics.AddRange(diagnostics);
		}

		public IReadOnlyList<Diagnostic> Complete()
		{
			var result = diagnostics;
			diagnostics = null;
			result.Sort();
			return result;
		}

		public void AddAnalysisError(ISourceText file, TextPosition position, string message)
		{
			diagnostics.Add(new Diagnostic(DiagnosticLevel.CompilationError, CompilerPhase.Analysis, file, position, message));
		}
	}
}
