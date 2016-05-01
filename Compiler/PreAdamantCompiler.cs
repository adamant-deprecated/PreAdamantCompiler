using System;
using System.Collections.Generic;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler
{
	public class PreAdamantCompiler
	{
		public PreAdamantParser.CompilationUnitContext Parse(PackageContext package, SourceText sourceText)
		{
			throw new NotImplementedException();
		}

		public void Compile(PackageContext package, IEnumerable<PackageContext> compiledPackages)
		{
			throw new NotImplementedException();
		}

		public string EmitCpp(PackageContext compiledPackage)
		{
			throw new NotImplementedException();
		}
	}
}
