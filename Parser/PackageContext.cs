using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
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
	public class PackageContext : ParserRuleContext
	{
		public readonly string Name;
		public readonly bool IsApp;
		// If no children are added, the children collection is null
		public IEnumerable<CompilationUnitContext> CompilationUnits => children?.OfType<CompilationUnitContext>() ?? Enumerable.Empty<CompilationUnitContext>();
		public IEnumerable<PackageReferenceContext> Dependencies => children?.OfType<PackageReferenceContext>() ?? Enumerable.Empty<PackageReferenceContext>();
		public Symbol<PackageContext> Symbol { get; set; }

		public readonly IList<Diagnostic> Diagnostics;
		// TODO Language version

		public PackageContext(string name, bool isApp, IEnumerable<PackageReferenceContext> dependencies)
		{
			Requires.NotNullOrEmpty(name, nameof(name));
			// TODO enforce this rule with the analyzer
			//Dependencies = dependencies.ToList();
			//Requires.That(Dependencies.Select(d => d.AliasName).Distinct().Count() == Dependencies.Count, nameof(dependencies), "Dependency names/alias must be unique");

			Name = name;
			IsApp = isApp;
			Diagnostics = new List<Diagnostic>();

			foreach(var dependency in dependencies)
				AddChild(dependency);
		}

		public override void AddChild(RuleContext context)
		{
			context.Parent = this;
			base.AddChild(context);
		}

		public void BindDependencies(IEnumerable<PackageContext> compiledPackages)
		{
			var packagesLookup = compiledPackages.ToLookup(p => p.Name);
			foreach(var dependency in Dependencies)
				dependency.Package = packagesLookup[dependency.Name].Single();
		}

		public override void EnterRule(IParseTreeListener listener)
		{
			var typedListener = listener as IContextListener;
			typedListener?.EnterPackage(this);
		}
		public override void ExitRule(IParseTreeListener listener)
		{
			var typedListener = listener as IContextListener;
			typedListener?.ExitPackage(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
		{
			var typedVisitor = visitor as IContextVisitor<TResult>;
			return typedVisitor != null ? typedVisitor.VisitPackage(this) : visitor.VisitChildren(this);
		}

		public IEnumerable<Symbol<FunctionDeclarationContext>> EntryPoints()
		{
			var symbols = new Stack<Symbol>();
			symbols.Push(Symbol);
			while(symbols.Count > 0)
			{
				var symbol = symbols.Pop();
				foreach(var child in symbol.Children)
					symbols.Push(child);

				Symbol<FunctionDeclarationContext>  funcSymbol;
				if(symbol.Name == "Main" && (funcSymbol = symbol as Symbol<FunctionDeclarationContext>) != null)
					yield return funcSymbol;
			}
		}
	}
}
