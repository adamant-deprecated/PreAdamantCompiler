using Antlr4.Runtime.Misc;

namespace PreAdamant.Compiler.Parser
{
	public interface IContextVisitor<TResult> : IPreAdamantParserVisitor<TResult>
	{
		TResult VisitPackage([NotNull] PackageContext context);
		TResult VisitPackageReference([NotNull] PackageReferenceContext context);
	}
}