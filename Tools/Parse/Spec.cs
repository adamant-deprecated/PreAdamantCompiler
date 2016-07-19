using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class Spec
	{
		public string Name { get; }
		public string Namespace { get; }
		public string StartRule { get; }
		public IDictionary<string, Rule> Rules { get; }

		public Spec(string name, string ns, string startRule, IEnumerable<Rule> rules)
		{
			Name = name;
			Namespace = ns;
			StartRule = startRule;
			Rules = rules.ToDictionary(r => r.Name, r => r);
		}
	}
}
