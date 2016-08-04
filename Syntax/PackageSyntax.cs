using System.Collections.Generic;
using System.Linq;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Core.Diagnostics;

namespace PreAdamant.Compiler.Syntax
{
	/// <summary>
	/// A PackageSyntax is the combined set of data for a package, including the source and information in the package config
	/// </summary>
	public class PackageSyntax
	{
		public readonly string Name;
		public readonly bool IsApp;
		//	// If no children are added, the children collection is null
		//	public IEnumerable<CompilationUnitContext> CompilationUnits => children?.OfType<CompilationUnitContext>() ?? Enumerable.Empty<CompilationUnitContext>();
		public IReadOnlyList<PackageReferenceSyntax> Dependencies { get; }
		//	public Symbol<PackageContext> Symbol { get; set; }

		public readonly IList<Diagnostic> Diagnostics;
		// TODO Language version

		public PackageSyntax(string name, bool isApp, IEnumerable<PackageReferenceSyntax> dependencies)
		{
			Requires.NotNullOrEmpty(name, nameof(name));
			// TODO enforce this rule with the analyzer
			Dependencies = dependencies.ToList();
			Requires.That(Dependencies.Select(d => d.AliasName).Distinct().Count() == Dependencies.Count, nameof(dependencies), "Dependency names/alias must be unique");

			Name = name;
			IsApp = isApp;
			Diagnostics = new List<Diagnostic>();
		}
	}
}
