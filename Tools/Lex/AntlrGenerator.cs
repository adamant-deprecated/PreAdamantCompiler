using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using static PreAdamant.Compiler.Tools.Lex.SpecParser;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class AntlrGenerator
	{
		private readonly static CommandBuilder CommadBuilder = new CommandBuilder();

		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			var patternBuilder = new PatternBuilder(spec, true);
			builder.AppendLine($"lexer grammar {spec.Name}_Antlr;");
			builder.AppendLine();
			if(spec.Channels.Any())
				builder.AppendLine($"channels {{ {string.Join(", ", spec.Channels)} }}");
			builder.AppendLine("options { language=CSharp; }");
			builder.AppendLine();

			builder.AppendLine("// Fragments");
			var fragments = spec.Fragments;
			foreach(var fragment in fragments.Values)
			{
				builder.AppendLine($"fragment {fragment.Name}: {patternBuilder.Visit(fragment.Pattern)};");
			}
			builder.AppendLine();

			builder.AppendLine("// Rules");
			builder.AppendLine("fragment Lex__DummyFragment: '~~DummyFragment~~';");
			builder.AppendLine();
			foreach(var block in spec.ModeBlocks)
			{
				builder.AppendLine($"mode {string.Join(", ", block.Modes)};");
				builder.AppendLine();
				foreach(var rule in block.Rules.Values)
					Rule(builder, rule, patternBuilder);
				builder.AppendLine();
			}

			builder.AppendLine("// Unicode Fragments");
			var unicodeNots = patternBuilder.PredefinedFragmentsUsed.Where(f => f.StartsWith(UnicodeNot)).ToList();
			foreach(var unicodeNot in unicodeNots)
			{
				var unicodeFragment = unicodeNot.Replace(UnicodeNot, Unicode);
				builder.Append($"fragment {unicodeNot}: ~{unicodeFragment};");
				patternBuilder.PredefinedFragmentsUsed.Add(unicodeFragment);
			}

			foreach(var unicodeFragment in patternBuilder.PredefinedFragmentsUsed.Where(f => f.StartsWith(Unicode)))
			{
				var unicodeProperty = unicodeFragment.Substring(Unicode.Length);
				string chars;
				switch(unicodeProperty)
				{
					case "Whitespace":
						chars = UnicodeCharsWithProperty(char.IsWhiteSpace);
						break;
					case "Letter":
						chars = UnicodeCharsWithProperty(char.IsLetter);
						break;
					case "Digit":
						chars = UnicodeCharsWithProperty(char.IsDigit);
						break;
					case "Connector_Punctuation":
						chars = UnicodeCharsWithProperty(c => char.GetUnicodeCategory(c) == UnicodeCategory.ConnectorPunctuation);
						break;
					case "Non_Spacing_Mark":
						chars = UnicodeCharsWithProperty(c => char.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark);
						break;
					case "Spacing_Combining_Mark":
						chars = UnicodeCharsWithProperty(c => char.GetUnicodeCategory(c) == UnicodeCategory.SpacingCombiningMark);
						break;
					case "Format":
						chars = UnicodeCharsWithProperty(c => char.GetUnicodeCategory(c) == UnicodeCategory.Format);
						break;
					default:
						throw new NotImplementedException($"Unicode property '{unicodeProperty}' not implemented");
				}
				builder.AppendLine($"fragment {unicodeFragment}: {chars};");
			}

			return builder.ToString();
		}

		private static void Rule(StringBuilder builder, Rule rule, PatternBuilder patternBuilder)
		{
			var ruleName = rule.Name;
			var patternContext = rule.Pattern;
			if(patternContext == null) return; // Not an actual pattern, just an inheritance statement
			var pattern = patternBuilder.Visit(patternContext);
			builder.Append($"{ruleName}: {pattern}");

			var actionCommands = rule.Commands.OfType<ActionCommandContext>().ToList();
			var action = actionCommands.Select(a => CommadBuilder.Visit(a)).SingleOrDefault();
			if(action != null)
				builder.Append(" " + action);

			var commands = rule.Commands.Except(actionCommands).Select(command2 => CommadBuilder.Visit(command2))
				.Where(c => c != null).ToList();
			if(commands.Any())
				builder.Append($" -> {string.Join(", ", commands)}");

			builder.AppendLine(";");
		}

		private static string UnicodeCharsWithProperty(Predicate<char> test)
		{
			var builder = new StringBuilder("[");
			for(var i = 0; i <= char.MaxValue; i++)
				if(test((char)i))
				{
					var lowEnd = i;
					builder.Append($"\\u{lowEnd.ToString("X4")}");
					while(i <= char.MaxValue && test((char)++i))
					{
						/* do nothing */
					}
					var highEnd = i - 1;
					if(lowEnd < highEnd)
						builder.Append($"-\\u{highEnd.ToString("X4")}");
				}
			builder.Append("]");
			return builder.ToString();
		}

		public const string Unicode = "Lex__Unicode__";
		public const string UnicodeNot = "Lex__UnicodeNot__";
		public const string UnicodeWhitespace = Unicode + "Whitespace";
		public const string UnicodeNotWhitespace = UnicodeNot + "Whitespace";
		public const string UnicodeLetter = Unicode + "Letter";
		public const string UnicodeDigit = Unicode + "Digit";
		public const string UnicodeConnectorPunctuation = Unicode + "Connector_Punctuation";
		public const string UnicodeNonSpacingMark = Unicode + "Non_Spacing_Mark";
		public const string UnicodeSpacingCombiningMark = Unicode + "Spacing_Combining_Mark";
		public const string UnicodeFormat = Unicode + "Format";

		private class CommandBuilder : SpecParserSafeBaseVisitor<string>
		{
			public override string VisitChannelCommand(ChannelCommandContext context)
			{
				return $"channel({context.channel.Text})";
			}

			public override string VisitTypeCommand(TypeCommandContext context)
			{
				return $"type({context.type.Text})";
			}

			public override string VisitErrorCommand(ErrorCommandContext context)
			{
				return null;
			}

			public override string VisitActionCommand(ActionCommandContext context)
			{
				var parseRule = (ParseRuleContext)context.Parent;
				var actionName = context.action?.Text ?? parseRule.name.Text;
				return $"{{{actionName}Action(_localctx);}}";
			}
		}
	}
}
