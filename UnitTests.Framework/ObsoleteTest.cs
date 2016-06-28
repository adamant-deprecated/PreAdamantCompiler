using System;

namespace PreAdamant.Compiler.UnitTests.Framework
{
	public class ObsoleteTest
	{
		// The error message on this demonstrates that the compiler isn't really reading the attribute, but is just reading
		// the attribute declaration against an attribute named `System.ObsoleteAttribute`
		public void CallObsoleteMethod()
		{
			ObsoleteMethod();
		}

		[Obsolete("Ignore this")]
		public void ObsoleteMethod()
		{

		}
	}
}
