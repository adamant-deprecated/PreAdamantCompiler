using static PreAdamant.Compiler.Tools.Lex.SpecParser;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class Fragment
	{
		public string Name { get; }
		public PatternContext Pattern { get; }

		public Fragment(string name, PatternContext pattern)
		{
			Name = name;
			Pattern = pattern;
		}
	}
}
