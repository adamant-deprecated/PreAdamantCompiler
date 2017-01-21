using System.Collections.Generic;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Emit.Cpp;
using PreAdamant.Compiler.Semantics;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler
{
	public class PreAdamantCompiler
	{
		public SyntaxTree<CompilationUnitSyntax> Parse(SourceText sourceText)
		{
			// TODO need parse settings for things like
			//   * Language Version
			//   * Dependency Names
			//   * Defined Preprocessor Symbols

			var parser = new PreAdamantParser(sourceText);
			var syntaxTree = parser.Parse();
			return syntaxTree;
		}

		public PackageSemantics Compile(PackageSyntax packageSyntax, IEnumerable<PackageSemantics> packages)
		{
			var nameBinder = new PreAdamantNameBinder();
			//var packageSymbol = nameBinder.BuildSymbols(packageSyntax);

			//package.BindDependencies(packages);

			//var treeWalker = new ParseTreeWalker();
			//treeWalker.Walk(new SymbolsBuilder(), package);
			//treeWalker.Walk(new BindSymbols(), package);

			// TODO rest of analysis

			return new PackageSemantics(packageSyntax, null);
		}

		public string EmitCpp(PackageSemantics package)
		{
			var emitter = new PackageEmitter(package);
			return emitter.Emit();
		}
	}
}
