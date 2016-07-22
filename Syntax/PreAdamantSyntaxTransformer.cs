using System;
using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Syntax.Antlr;

namespace PreAdamant.Compiler.Syntax
{
	internal partial class PreAdamantSyntaxTransformer : IPreAdamantParser_AntlrVisitor<ISyntax>
	{
		private readonly ISourceText source;

		public PreAdamantSyntaxTransformer(ISourceText source)
		{
			this.source = source;
		}

		internal CompilationUnitSyntax Transform(PreAdamantParser_Antlr.CompilationUnitContext compilationUnit)
		{
		}
	}
}
