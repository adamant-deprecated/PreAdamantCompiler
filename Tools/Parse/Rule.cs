using static PreAdamant.Compiler.Tools.Parse.SpecParser;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class Rule
	{
		public string Name { get; }
		public string Base { get; }
		public PatternContext Pattern { get; }

		public Rule(string name, string @base, PatternContext pattern)
		{
			Name = name;
			Base = @base;
			Pattern = pattern;
		}
	}
}
