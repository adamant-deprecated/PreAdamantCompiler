using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class ModeBlock
	{
		public IReadOnlyCollection<string> Modes { get; }
		public IDictionary<string, Rule> Rules { get; }

		public ModeBlock(IEnumerable<string> modes, IEnumerable<Rule> rules)
		{
			Rules = rules.ToDictionary(r => r.Name, r => r);
			Modes = new HashSet<string>(modes);
		}
	}
}
