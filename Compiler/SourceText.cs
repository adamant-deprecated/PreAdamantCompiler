using System;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler
{
	public abstract class SourceText : ISourceText
	{
		public abstract string Name { get; }
		internal abstract PreAdamantParser NewParser();

		public int CompareTo(ISourceText other)
		{
			return string.Compare(Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
		}
	}
}
