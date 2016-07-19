using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using PreAdamant.Compiler.Common;

namespace PreAdamant.Compiler.Parser
{
	//public class PackageReferenceContext : ParserRuleContext
	//{
	//	public readonly string Name;
	//	public readonly string Alias;
	//	public readonly bool Trusted;
	//	public string AliasName => Alias ?? Name;
	//	public PackageContext Package { get; set; }

	//	public PackageReferenceContext(string name, string alias, bool trusted)
	//	{
	//		Requires.NotNull(name, nameof(name));

	//		Name = name;
	//		Alias = alias;
	//		Trusted = trusted;
	//	}

	//	public override void EnterRule(IParseTreeListener listener)
	//	{
	//		var typedListener = listener as IContextListener;
	//		typedListener?.EnterPackageReference(this);
	//	}
	//	public override void ExitRule(IParseTreeListener listener)
	//	{
	//		var typedListener = listener as IContextListener;
	//		typedListener?.ExitPackageReference(this);
	//	}
	//	public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
	//	{
	//		var typedVisitor = visitor as IContextVisitor<TResult>;
	//		return typedVisitor != null ? typedVisitor.VisitPackageReference(this) : visitor.VisitChildren(this);
	//	}
	//}
}
