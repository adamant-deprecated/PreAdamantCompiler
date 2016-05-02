using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using PreAdamant.Compiler.Core.Diagnostics;
using static PreAdamant.Compiler.Parser.PreAdamantParser;
using Requires = PreAdamant.Compiler.Common.Requires;

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
		private readonly List<CompilationUnitContext> compilationUnits;
		public IReadOnlyList<CompilationUnitContext> CompilationUnits => compilationUnits;
		public readonly IReadOnlyList<PackageReferenceContext> Dependencies;
		public readonly IList<Diagnostic> Diagnostics;
		// TODO Language version

		public PackageContext(string name, bool isApp, IEnumerable<PackageReferenceContext> dependencies)
		{
			Requires.NotNullOrEmpty(name, nameof(name));
			Dependencies = dependencies.ToList();
			Requires.That(Dependencies.Select(d => d.AliasName).Distinct().Count() == Dependencies.Count, nameof(dependencies), "Dependency names/alias must be unique");

			Name = name;
			compilationUnits = new List<CompilationUnitContext>();
			IsApp = isApp;
			Diagnostics = new List<Diagnostic>();
		}

		public void Add(CompilationUnitContext compilationUnit)
		{
			compilationUnit.Parent = this;
			compilationUnits.Add(compilationUnit);
		}

		public void BindDependencies(IEnumerable<PackageContext> compiledPackages)
		{
			var packagesLookup = compiledPackages.ToLookup(p => p.Name);
			foreach(var dependency in Dependencies)
				dependency.Package = packagesLookup[dependency.Name].Single();
		}
	}
}
