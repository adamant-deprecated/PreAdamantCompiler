using System;
using System.Collections.Generic;
using Antlr4.Runtime.Atn;
using PreAdamant.Compiler.Core.Diagnostics;
using PreAdamant.Compiler.Emit.Cpp;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler
{
	public class PreAdamantCompiler
	{
		public PreAdamantParser.CompilationUnitContext Parse(PackageContext package, SourceText sourceText)
		{
			// TODO make use of the package.  We don't currently use the package, but we
			// are taking it as an argument becuase we should be for things like:
			//   * Language Version
			//   * Dependency Names
			//   * Defined Preprocessor Symbols
			var diagnostics = new ParseDiagnosticsBuilder(sourceText, package.Diagnostics);

			var parser = sourceText.NewParser();
			// Stupid ANTLR makes it difficult to do this in the constructor
			parser.RemoveErrorListeners();
			var errorsListener = new GatherErrorsListener(diagnostics);
			parser.AddErrorListener(errorsListener);
			parser.Interpreter.PredictionMode = PredictionMode.LlExactAmbigDetection;

			var compilationUnit = parser.compilationUnit();
			// TODO in the exploratory compiler, these lines checked method modifier restrictions
			//var syntaxCheck = new SyntaxCheckVisitor(builder);
			//tree.Accept(syntaxCheck);

			// TODO should really be about ones that prevent further processing?
			if(!diagnostics.Any)
				package.Add(compilationUnit);

			return compilationUnit;
		}

		public void Compile(PackageContext package, IEnumerable<PackageContext> compiledPackages)
		{
			package.BindDependencies(compiledPackages);
			// TODO run analysis
		}

		public string EmitCpp(PackageContext package)
		{
			var emitter = new PackageEmitter(package);
			return emitter.Emit();
		}
	}
}
