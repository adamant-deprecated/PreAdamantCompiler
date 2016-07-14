using System.Collections.Generic;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class Spec
	{
		public string Name { get; }
		public string Namespace { get; }
		public IReadOnlyCollection<string> Modes { get; }
		public IReadOnlyCollection<string> Channels { get; } 
		// TODO maybe this should be string to some kind of expression
		public IReadOnlyDictionary<string, string> Fragments { get; } 
	}
}
