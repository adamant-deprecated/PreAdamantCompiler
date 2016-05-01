using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
		public readonly IReadOnlyList<PreAdamantParser.CompilationUnitContext> CompilationUnits;
		public readonly IReadOnlyList<PackageReferenceContext> Dependencies;
		public readonly IReadOnlyList<Diagnostic> Diagnostics;
		// TODO Language version

		public PackageContext(string name, bool isApp, IEnumerable<PackageReferenceContext> dependencies)
			: this(name, isApp, new List<PreAdamantParser.CompilationUnitContext>(), dependencies.ToList())
		{
		}

		private PackageContext(string name, bool isApp, IReadOnlyList<PreAdamantParser.CompilationUnitContext> compilationUnits, IReadOnlyList<PackageReferenceContext> dependencies)
		{
			// TODO set compilationUnits  parent
			Requires.NotNullOrEmpty(name, nameof(name));
			Requires.That(dependencies.Select(d => d.AliasName).Distinct().Count() == dependencies.Count, nameof(dependencies), "Dependency names/alias must be unique");

			Name = name;
			CompilationUnits = compilationUnits;
			Dependencies = dependencies;
			IsApp = isApp;
			var diagnostics = new DiagnosticsBuilder();
			// TODO handle diagnostics correctly
			//foreach(var compilationUnit in CompilationUnits)
			//	diagnostics.Add(compilationUnit.Diagnostics);

			Diagnostics = diagnostics.Complete();
		}

		[Pure]
		public PackageContext With(IEnumerable<PreAdamantParser.CompilationUnitContext> compilationUnits)
		{
			// TODO set their parent
			return new PackageContext(Name, IsApp, compilationUnits.ToList(), Dependencies);
		}
	}
}
