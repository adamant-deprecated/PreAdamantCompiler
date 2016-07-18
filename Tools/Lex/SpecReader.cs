using System;
using System.IO;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using static PreAdamant.Compiler.Tools.Lex.SpecParser;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class SpecReader
	{
		public Spec Read(string spec, Func<string, string> readImport)
		{
			var lexer = new SpecLexer(new AntlrInputStream(new StringReader(spec)));
			var parser = new SpecParser(new CommonTokenStream(lexer));
			var specTree = parser.spec();

			if(parser.NumberOfSyntaxErrors > 0)
				return null;

			var imports = specTree.children.OfType<ImportDirectiveContext>()
				.ToDictionary(i => i.alias?.Text ?? i.lexerName.Text, i => Read(readImport(i.lexerName.Text), readImport));

			if(imports.Values.Any(l => l == null))
				return null;

			var treeWalker = new ParseTreeWalker();
			treeWalker.Walk(new SpecValidations(imports), specTree);

			var name = specTree.children.OfType<NameDirectiveContext>().SingleOrDefault()?.Identifier().GetText();
			var ns = string.Join(".", specTree.children.OfType<NamespaceDirectiveContext>().SingleOrDefault()?.GetTokens(Identifier).Select(n => n.GetText()) ?? Enumerable.Empty<string>());
			var startMode = specTree.children.OfType<StartModeDirectiveContext>().SingleOrDefault()?.Identifier().GetText();
			var modes = specTree.children.OfType<ModesDirectiveContext>().SelectMany(m => m._modes).Select(m => m.Text).Distinct();
			var channels = (specTree.children.OfType<ChannelsDirectiveContext>().SingleOrDefault()?._channels.Select(c => c.Text) ?? Enumerable.Empty<string>()).ToList();
			var fragements = specTree.children.OfType<ParseRuleContext>().Select(BuildFragment);
			var blocks = specTree.children.OfType<ModesDirectiveContext>().Select(Build);

			return new Spec(name, ns, startMode, imports, modes, channels, fragements, blocks);
		}

		private static Fragment BuildFragment(ParseRuleContext rule)
		{
			return new Fragment(rule.name.Text, rule.pattern());
		}

		private static ModeBlock Build(ModesDirectiveContext block)
		{
			return new ModeBlock(block._modes.Select(m => m.Text), block.parseRule().Select(Build));
		}

		private static Rule Build(ParseRuleContext rule)
		{
			return new Rule(rule.name.Text, rule.@base?.Text, rule.pattern(), rule._commands);
		}
	}
}
