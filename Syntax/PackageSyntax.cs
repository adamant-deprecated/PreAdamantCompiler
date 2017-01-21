using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Core.Diagnostics;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// A PackageSyntax is the combined set of data for a package, including the source and information in the package config
	/// </summary>
	public class PackageSyntax : ISyntax
	{
		public readonly string Name;
		public readonly bool IsApp;
		public IReadOnlyList<SyntaxTree<CompilationUnitSyntax>> CompilationUnits { get; }
		private readonly IReadOnlyList<ISyntax> children;
		IReadOnlyList<ISyntax> ISyntax.Children => children;
		public IReadOnlyList<PackageReferenceSyntax> Dependencies { get; }
		public IReadOnlyList<Diagnostic> Diagnostics { get; }
		// TODO Language version

		public PackageSyntax(string name, bool isApp, IEnumerable<PackageReferenceSyntax> dependencies, IEnumerable<SyntaxTree<CompilationUnitSyntax>> compilationUnits)
		{
			Requires.NotNullOrEmpty(name, nameof(name));
			// TODO enforce this rule with the analyzer
			Dependencies = dependencies.ToList();
			Requires.That(Dependencies.Select(d => d.AliasName).Distinct().Count() == Dependencies.Count, nameof(dependencies), "Dependency names/alias must be unique");

			Name = name;
			IsApp = isApp;
			CompilationUnits = compilationUnits.ToList();
			children = CompilationUnits.Select(cu => cu.Root).ToList();
			Diagnostics = new List<Diagnostic>();
		}
	}
}
