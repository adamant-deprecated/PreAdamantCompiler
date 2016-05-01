﻿using System.Collections.Generic;

namespace PreAdamant.Compiler.Core.Diagnostics
{
	public class ParseDiagnosticsBuilder
	{
		public readonly ISourceText SourceFile;
		private List<Diagnostic> diagnostics = new List<Diagnostic>();

		public ParseDiagnosticsBuilder(ISourceText sourceFile)
		{
			SourceFile = sourceFile;
		}

		public IReadOnlyList<Diagnostic> Complete()
		{
			var result = diagnostics;
			diagnostics = null;
			result.Sort();
			return result;
		}

		public Diagnostic ParseError(TextPosition position, string message)
		{
			var diagnostic = new Diagnostic(DiagnosticLevel.CompilationError, CompilerPhase.Parsing, SourceFile, position, message);
			diagnostics.Add(diagnostic);
			return diagnostic;
		}
	}
}
