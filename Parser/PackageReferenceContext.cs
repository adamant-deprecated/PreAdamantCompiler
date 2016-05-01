using Antlr4.Runtime;
using PreAdamant.Compiler.Common;

namespace PreAdamant.Compiler.Parser
{
	public class PackageReferenceContext : RuleContext
	{
		public readonly string Name;
		public readonly string Alias;
		public readonly bool Trusted;

		public PackageReferenceContext(string name, string alias, bool trusted)
		{
			Requires.NotNull(name, nameof(name));

			Name = name;
			Alias = alias;
			Trusted = trusted;
		}

		public string AliasName => Alias ?? Name;
	}
}
