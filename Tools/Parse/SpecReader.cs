using System.IO;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using static PreAdamant.Compiler.Tools.Parse.SpecParser;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class SpecReader
	{
		public Spec Read(string spec)
		{
			var lexer = new SpecLexer(new AntlrInputStream(new StringReader(spec)));
			var parser = new SpecParser(new CommonTokenStream(lexer));
			var specTree = parser.spec();

			if(parser.NumberOfSyntaxErrors > 0)
				return null;

			var treeWalker = new ParseTreeWalker();
			treeWalker.Walk(new SpecValidations(), specTree);

			var name = specTree.children.OfType<NameDirectiveContext>().SingleOrDefault()?.Identifier().GetText();
			var ns = string.Join(".", specTree.children.OfType<NamespaceDirectiveContext>().SingleOrDefault()?.GetTokens(Identifier).Select(n => n.GetText()) ?? Enumerable.Empty<string>());
			var startRule = specTree.children.OfType<StartRuleDirectiveContext>().SingleOrDefault()?.Identifier().GetText();
			var rules = specTree.children.OfType<ParseRuleContext>().Select(Build);

			return new Spec(name, ns, startRule, rules);
		}

		private static Rule Build(ParseRuleContext rule)
		{
			return new Rule(rule.name.Text, rule.@base?.Text, rule.pattern(), rule._attributes.Select(a => a.Text));
		}
	}
}
