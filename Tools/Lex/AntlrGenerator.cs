using System.Linq;
using System.Text;
using static PreAdamant.Compiler.Tools.Lex.SpecParser;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class AntlrGenerator
	{
		private readonly PatternBuilder patternBuilder = new PatternBuilder();
		private readonly CommandBuilder commadBuilder = new CommandBuilder();

		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

		
			builder.AppendLine($"lexer grammar Antlr{spec.Name};");
			builder.AppendLine();
			builder.AppendLine("options { language=CSharp; }");
			builder.AppendLine();

			builder.AppendLine("// Fragments");
			var fragments = spec.Fragments;
			foreach(var fragment in fragments.Values)
			{
				builder.AppendLine($"fragment {fragment.Name}: {Pattern(fragment.Pattern)};");
			}
			builder.AppendLine();

			builder.AppendLine("// Rules");
			builder.AppendLine("DummyRule__: ;");
			builder.AppendLine();
			foreach(var block in spec.ModeBlocks)
			{
				builder.AppendLine($"mode {string.Join(", ", block.Modes)};");
				builder.AppendLine();
				foreach(var rule in block.Rules.Values)
					Rule(builder, rule);
				builder.AppendLine();
			}

			return builder.ToString();
		}

		private void Rule(StringBuilder builder, Rule rule)
		{
			var ruleName = rule.Name;
			var patternContext = rule.Pattern;
			if(patternContext == null) return; // Not an actual pattern, just an inheritance statement
			var pattern = Pattern(patternContext);
			builder.Append($"{ruleName}: {pattern}");
			var commands = rule.Commands.Select(Command).ToList();
			if(commands.Any())
				builder.Append($" -> {string.Join(", ", commands)}");

			builder.AppendLine(";");
		}

		private string Pattern(PatternContext pattern)
		{
			return patternBuilder.Visit(pattern);
		}

		private string Command(CommandContext command)
		{
			return commadBuilder.Visit(command);
		}

		private class PatternBuilder : SpecParserSafeBaseVisitor<string>
		{
			public override string VisitGroupingPattern(GroupingPatternContext context)
			{
				return $"({Visit(context.pattern())})";
			}

			public override string VisitOptionalPattern(OptionalPatternContext context)
			{
				return Visit(context.pattern()) + "?";
			}

			public override string VisitZeroOrMorePattern(ZeroOrMorePatternContext context)
			{
				return Visit(context.pattern()) + "*";
			}

			public override string VisitOneOrMorePattern(OneOrMorePatternContext context)
			{
				return Visit(context.pattern()) + "+";
			}

			public override string VisitRepeatPattern(RepeatPatternContext context)
			{
				var pattern = $"({Visit(context.pattern())})";
				var min = int.Parse(context.min.Text);
				var maxString = context.max?.Text;
				var max = maxString != null ? int.Parse(maxString) : default(int?);
				if(context.range == null) // it is just `{n}`
					max = min;

				var builder = new StringBuilder("(");
				for(var i = 0; i < (max ?? min); i++)
					builder.Append(pattern);
				if(max == null)
					builder.Append("+");
				else
				{
					pattern += "?";
					for(var i = min; i < max; i++)
						builder.Append(pattern);
				}

				builder.Append(")");
				return builder.ToString();
			}

			public override string VisitNegatePattern(NegatePatternContext context)
			{
				return "~" + Visit(context.pattern());
			}

			public override string VisitUpToPattern(UpToPatternContext context)
			{
				return $"(.*?({Visit(context.pattern())}))";
			}

			public override string VisitConcatPattern(ConcatPatternContext context)
			{
				return string.Join(" ", context.pattern().Select(Visit));
			}

			public override string VisitAlternationPattern(AlternationPatternContext context)
			{
				return string.Join(" | ", context.pattern().Select(Visit));
			}

			public override string VisitRulePattern(RulePatternContext context)
			{
				return context.ruleName.Text;
			}

			public override string VisitAnyPattern(AnyPatternContext context)
			{
				return ".";
			}

			public override string VisitLiteralPattern(LiteralPatternContext context)
			{
				var value = context.GetText();
				return $"'{value.Substring(1, value.Length - 2)}'";
			}
		}

		private class CommandBuilder : SpecParserSafeBaseVisitor<string>
		{
			public override string VisitChannelCommand(ChannelCommandContext context)
			{
				return $"channel({context.channel.Text})";
			}
		}
	}
}
