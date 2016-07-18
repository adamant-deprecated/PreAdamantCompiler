using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class Spec
	{
		public string Name { get; }
		public string Namespace { get; }
		public string StartMode { get; }
		public IReadOnlyDictionary<string, Spec> Imports { get; }
		public IReadOnlyCollection<string> Modes { get; }
		public IReadOnlyCollection<string> Channels { get; }
		public IReadOnlyDictionary<string, Fragment> Fragments { get; }
		public IReadOnlyList<ModeBlock> ModeBlocks { get; }

		public Spec(string name, string ns, string startMode, IDictionary<string, Spec> imports, IEnumerable<string> modes, IEnumerable<string> channels, IEnumerable<Fragment> fragments, IEnumerable<ModeBlock> modeBlocks)
		{
			Name = name;
			Namespace = ns;
			StartMode = startMode;
			ModeBlocks = modeBlocks.ToList();
			Imports = new Dictionary<string, Spec>(imports);
			Fragments = fragments.ToDictionary(f => f.Name, f => f);
			Modes = new HashSet<string>(modes);
			Channels = new HashSet<string>(channels);
		}
	}
}
