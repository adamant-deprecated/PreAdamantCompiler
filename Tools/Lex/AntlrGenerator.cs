using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
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
			var action = actionCommands.Select(command1 => CommadBuilder.Visit(command1)).SingleOrDefault();
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

		private const string Unicode = "Lex__Unicode__";
		private const string UnicodeNot = "Lex__UnicodeNot__";
		private const string UnicodeWhitespace = Unicode + "Whitespace";
		private const string UnicodeNotWhitespace = UnicodeNot + "Whitespace";
		private const string UnicodeLetter = Unicode + "Letter";
		private const string UnicodeDigit = Unicode + "Digit";
		private const string UnicodeConnectorPunctuation = Unicode + "Connector_Punctuation";
		private const string UnicodeNonSpacingMark = Unicode + "Non_Spacing_Mark";
		private const string UnicodeSpacingCombiningMark = Unicode + "Spacing_Combining_Mark";
		private const string UnicodeFormat = Unicode + "Format";

		/// <summary>
		/// Produces a pattern for ANTLR from our regular expression pattern.  Note that each
		/// operation should produce an indivisible unit in the target language, this means
		/// many patterns return something surrounded by parens.  This ensures that order of
		/// operations is correctly handled since ANTLR hasn't published their order of operations.
		/// There are two exceptions to this, alternation `|` and concatenation ` ` are assumed to
		/// have the same precendence and be safe.
		/// </summary>
		private class PatternBuilder : SpecParserSafeBaseVisitor<string>
		{
			public readonly ISet<string> PredefinedFragmentsUsed = new HashSet<string>();
			private readonly Spec spec;
			private readonly bool isRoot;

			// Matches all unicode newlines including:
			// * Carriage Return
			// * Line Feed
			// * Line Tabulation (U+000B) (i.e. vertical tab)
			// * Form Feed
			// * Next Line (U+0085)
			// * Line Separator (U+2028)
			// * Paragraph Separator (U+2029)
			private const string NewLineChars = @"\r\n\u000B\f\u0085\u2028\u2029";

			public PatternBuilder(Spec spec, bool isRoot)
			{
				this.spec = spec;
				this.isRoot = isRoot;
			}

			public override string VisitGroupingPattern(GroupingPatternContext context)
			{
				return $"({Visit(context.pattern())})";
			}

			public override string VisitOptionalPattern(OptionalPatternContext context)
			{
				return $"({Visit(context.pattern())}?)";
			}

			public override string VisitZeroOrMorePattern(ZeroOrMorePatternContext context)
			{
				return $"({Visit(context.pattern())}*)";
			}

			public override string VisitOneOrMorePattern(OneOrMorePatternContext context)
			{
				return $"({Visit(context.pattern())}+)";
			}

			public override string VisitRepeatPattern(RepeatPatternContext context)
			{
				var pattern = Visit(context.pattern()); // The pattern is already indivisble i.e. has parens etc
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
				return $"(~{Visit(context.pattern())})";
			}

			public override string VisitUpToPattern(UpToPatternContext context)
			{
				return $"(.*? {Visit(context.pattern())})";
			}

			public override string VisitConcatPattern(ConcatPatternContext context)
			{
				// One of the exception to indivisible units so no parens
				return string.Join(" ", context.pattern().Select(Visit));
			}

			public override string VisitAlternationPattern(AlternationPatternContext context)
			{
				// One of the exception to indivisible units so no parens
				return string.Join(" | ", context.pattern().Select(Visit));
			}

			public override string VisitRulePattern(RulePatternContext context)
			{
				var ruleName = context.ruleName.Text;
				return isRoot ? ruleName : BuildRule(this, ruleName);
			}

			public override string VisitAnyPattern(AnyPatternContext context)
			{
				return $"(~[{NewLineChars}])";
			}

			public override string VisitLiteralPattern(LiteralPatternContext context)
			{
				var value = context.GetText();
				return value.StartsWith("\"") ? $"'{value.Substring(1, value.Length - 2)}'" : $"'{value}'";
			}

			public override string VisitImportedRulePattern(ImportedRulePatternContext context)
			{
				Spec lexerSpec;
				if(!spec.Imports.TryGetValue(context.lexerName.Text, out lexerSpec))
					throw new Exception($"Incorrect reference to imported lexer '{context.lexerName.Text}'");
				var ruleName = context.ruleName.Text;
				return BuildRule(new PatternBuilder(lexerSpec, false), ruleName);
			}

			public override string VisitCharClassPattern(CharClassPatternContext context)
			{
				var isNegated = context.negate != null;
				var alternatives = new StringBuilder();
				var classBlock = new StringBuilder();
				foreach(var charSet in context.charSet())
				{
					PredefinedClassCharContext predefinedClassCharContext;
					SingleCharContext singleCharContext;
					CharRangeContext charRangeContext;
					if((predefinedClassCharContext = charSet as PredefinedClassCharContext) != null)
						BuildCharClass(predefinedClassCharContext, alternatives, classBlock, isNegated);
					else if((singleCharContext = charSet as SingleCharContext) != null)
						classBlock.Append(BuildCharClass(singleCharContext.@char()));
					else if((charRangeContext = charSet as CharRangeContext) != null)
						classBlock.Append(BuildCharClass(charRangeContext));
					else
						throw new NotImplementedException();
				}

				if(classBlock.Length > 0 || alternatives.Length == 0) // we need a class block, or we need an empty block
				{
					alternatives.Append("[");
					alternatives.Append(classBlock);
					alternatives.Append("]");
				}
				else
					alternatives.Length -= 1; // remove the last |

				var isBlockOnly = alternatives[0] == '[';
				if(isNegated)
					return isBlockOnly ? $"(~{alternatives})" : $"(~({alternatives}))";

				return isBlockOnly ? alternatives.ToString() : $"({alternatives})";
			}

			public override string VisitPredefinedClassPattern(PredefinedClassPatternContext context)
			{
				var predefinedClass = context.GetText();
				switch(predefinedClass)
				{
					case @"\d":
						return "[0-9]";
					case @"\D":
						return "(~[0-9])";
					case @"\s":
						PredefinedFragmentsUsed.Add(UnicodeWhitespace);
						return UnicodeWhitespace;
					case @"\S":
						PredefinedFragmentsUsed.Add(UnicodeNotWhitespace);
						return UnicodeNotWhitespace;
					case @"\w":
					case @"\W":
						throw new NotImplementedException();
					case @"\R":
						return $"('\\r\\n'|[{NewLineChars}])";
					case @"\p{Letter}":
						PredefinedFragmentsUsed.Add(UnicodeLetter);
						return UnicodeLetter;
					case @"\p{Digit}":
						PredefinedFragmentsUsed.Add(UnicodeDigit);
						return UnicodeDigit;
					case @"\p{Connector_Punctuation}":
						PredefinedFragmentsUsed.Add(UnicodeConnectorPunctuation);
						return UnicodeConnectorPunctuation;
					case @"\p{Non_Spacing_Mark}":
						PredefinedFragmentsUsed.Add(UnicodeNonSpacingMark);
						return UnicodeNonSpacingMark;
					case @"\p{Spacing_Combining_Mark}":
						PredefinedFragmentsUsed.Add(UnicodeSpacingCombiningMark);
						return UnicodeSpacingCombiningMark;
					case @"\p{Format}":
						PredefinedFragmentsUsed.Add(UnicodeFormat);
						return UnicodeFormat;
					default:
						throw new NotImplementedException();
				}
			}

			private string BuildRule(PatternBuilder builder, string ruleName)
			{
				PatternContext pattern;
				Fragment fragment;
				if(builder.spec.Fragments.TryGetValue(ruleName, out fragment))
					pattern = fragment.Pattern;
				else
					pattern = builder.spec.ModeBlocks.Single(b => b.Rules.ContainsKey(ruleName)).Rules[ruleName].Pattern;
				var result = builder.Visit(pattern);
				PredefinedFragmentsUsed.UnionWith(builder.PredefinedFragmentsUsed); // Pull forward any predefined sets
				return result;
			}

			private void BuildCharClass(PredefinedClassCharContext context, StringBuilder alternatives, StringBuilder classBlock, bool isNegated)
			{
				var predefinedClass = context.GetText();
				switch(predefinedClass)
				{
					case @"\d":
						alternatives.Append("[0-9]|");
						break;
					case @"\D":
						alternatives.Append("~[0-9]|");
						break;
					case @"\s":
						PredefinedFragmentsUsed.Add(UnicodeWhitespace);
						alternatives.Append(UnicodeWhitespace + "|");
						break;
					case @"\S":
						PredefinedFragmentsUsed.Add(UnicodeNotWhitespace);
						alternatives.Append(UnicodeNotWhitespace + "|");
						break;
					case @"\w":
					case @"\W":
						throw new NotImplementedException();
					case @"\R":
						classBlock.Append(NewLineChars);
						if(!isNegated) // If this is a positive class, we need to match CRLF
							alternatives.Append(@"'\r\n'|");
						break;
					default:
						throw new NotImplementedException();
				}
			}

			private static string BuildCharClass(CharContext context)
			{
				var token = ((ITerminalNode)context.children.Single()).Symbol;
				switch(token.Type)
				{
					case SpecParser.Char:
					case Caret:
					case EscapedChar:
					case EscapedDash:
						return token.Text;
					default:
						throw new NotSupportedException();
				}
			}

			private static string BuildCharClass(CharRangeContext context)
			{
				var left = context.@char(0);
				var right = context.@char(1);
				return $"{BuildCharClass(left)}-{BuildCharClass(right)}";
			}
		}

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
				var action = context.GetText();
				return $"{{{action.Substring(2, action.Length - 4)}}}";
			}
		}
	}
}
