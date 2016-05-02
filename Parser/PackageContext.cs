using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Core.Diagnostics;

namespace PreAdamant.Compiler.Parser
{
	/// <summary>
	/// A package is what a forge project produces.  The difference is that a project contains
	/// information about different configurations and targets as well as the build pipeline. A
	/// package is for a specific configuration, target etc.
	/// </summary>
	public class PackageContext : RuleContext
	{
		public readonly string Name;
		public readonly bool IsApp;
		private readonly List<PreAdamantParser.CompilationUnitContext> compilationUnits;
		public IReadOnlyList<PreAdamantParser.CompilationUnitContext> CompilationUnits => compilationUnits;
		public readonly IReadOnlyList<PackageReferenceContext> Dependencies;
		public readonly IList<Diagnostic> Diagnostics;
		// TODO Language version

		public PackageContext(string name, bool isApp, IEnumerable<PackageReferenceContext> dependencies)
		{
			// TODO set compilationUnits  parent
			Requires.NotNullOrEmpty(name, nameof(name));
			Dependencies = dependencies.ToList();
			Requires.That(Dependencies.Select(d => d.AliasName).Distinct().Count() == Dependencies.Count, nameof(dependencies), "Dependency names/alias must be unique");

			Name = name;
			compilationUnits = new List<PreAdamantParser.CompilationUnitContext>();
			IsApp = isApp;
			Diagnostics = new List<Diagnostic>();
		}

		public void Add(PreAdamantParser.CompilationUnitContext compilationUnit)
		{
			compilationUnit.Parent = this;
			compilationUnits.Add(compilationUnit);
		}

		public void BindDependencies(IEnumerable<PackageContext> compiledPackages)
		{
			throw new System.NotImplementedException();
		}
	}
}
