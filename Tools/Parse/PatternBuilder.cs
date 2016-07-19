using System;
using System.Linq;
using System.Text;

namespace PreAdamant.Compiler.Tools.Parse
{
	/// <summary>
	/// Produces a pattern for ANTLR from our pattern.  Note that each
	/// operation should produce an indivisible unit in the target language, this means
	/// many patterns return something surrounded by parens.  This ensures that order of
	/// operations is correctly handled since ANTLR hasn't published their order of operations.
	/// There are two exceptions to this, alternation `|` and concatenation ` ` are assumed to
	/// have the same precendence and be safe.
	/// </summary>
	internal class PatternBuilder : SpecParserSafeBaseVisitor<string>
	{
		private readonly Spec spec;

		public PatternBuilder(Spec spec)
		{
			this.spec = spec;
		}

		public override string VisitGroupingPattern(SpecParser.GroupingPatternContext context)
		{
			return $"({Visit(context.pattern())})";
		}

		public override string VisitOptionalPattern(SpecParser.OptionalPatternContext context)
		{
			return $"({Visit(context.pattern())}?)";
		}

		public override string VisitZeroOrMorePattern(SpecParser.ZeroOrMorePatternContext context)
		{
			return $"({Visit(context.pattern())}*)";
		}

		public override string VisitOneOrMorePattern(SpecParser.OneOrMorePatternContext context)
		{
			return $"({Visit(context.pattern())}+)";
		}

		public override string VisitRepeatWithSeparatorPattern(SpecParser.RepeatWithSeparatorPatternContext context)
		{
			var pattern = Visit(context.pattern()); // The pattern is already indivisble i.e. has parens etc
			var minString = context.min.Text;
			var min = minString != null ? int.Parse(minString) : 0;
			var maxString = context.max?.Text;
			var max = maxString != null ? int.Parse(maxString) : default(int?);
			if(minString != null && context.range == null) // it is just `{n}` or `{"." n}`
				max = min;
			var separator = context.separator.Text;
			separator = $"'{separator.Substring(1, separator.Length - 2)}'";

			var builder = new StringBuilder("(");

			// Separator patterns require at least one copy, so a min==0 needs an extra `(...)?` around it
			if(min == 0)
				builder.Append("(");

			builder.Append(pattern); // Always have at least one copy
			var limit = (max ?? min); // make one extra copy becuse we are using *
			for(var i = 1; i <= limit; i++) // the rest of the required copies
			{
				var needsGrouped = max == null && i == limit;
				if(needsGrouped) // group them so we can put + on the last one
					builder.Append("(");
				builder.Append(separator);
				builder.Append(pattern);
				if(needsGrouped)
					builder.Append(")");
			}

			if(max == null)
				builder.Append("*");
			else
				for(var i = min; i < max; i++)
				{
					builder.Append("(");
					builder.Append(separator);
					builder.Append(pattern);
					builder.Append(")?");
				}
			if(min == 0)
				builder.Append(")?");
			builder.Append(")");
			return builder.ToString();
		}

		public override string VisitRepeatPattern(SpecParser.RepeatPatternContext context)
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
		public override string VisitConcatPattern(SpecParser.ConcatPatternContext context)
		{
			// One of the exception to indivisible units so no parens
			return string.Join(" ", context.pattern().Select(Visit));
		}

		public override string VisitAlternationPattern(SpecParser.AlternationPatternContext context)
		{
			// One of the exception to indivisible units so no parens
			return string.Join(" | ", context.pattern().Select(Visit));
		}

		public override string VisitRulePattern(SpecParser.RulePatternContext context)
		{
			var ruleName = context.ruleName.Text;
			return ruleName;
		}

		public override string VisitLiteralPattern(SpecParser.LiteralPatternContext context)
		{
			var value = context.GetText();
			return $"'{value.Substring(1, value.Length - 2)}'";
		}
	}
}