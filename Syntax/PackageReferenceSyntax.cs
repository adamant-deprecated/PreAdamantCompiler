using PreAdamant.Compiler.Common;

namespace PreAdamant.Compiler.Syntax
{
	public class PackageReferenceSyntax
	{
		public readonly string Name;
		public readonly string Alias;
		public readonly bool Trusted;
		public string AliasName => Alias ?? Name;
		public PackageSyntax Package { get; set; }

		public PackageReferenceSyntax(string name, string alias, bool trusted)
		{
			Requires.NotNull(name, nameof(name));

			Name = name;
			Alias = alias;
			Trusted = trusted;
		}
	}
}
