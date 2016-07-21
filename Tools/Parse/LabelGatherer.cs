using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Compiler.Tools.Parse
{
	internal class LabelGatherer : SpecParserSafeBaseVisitor<IReadOnlyDictionary<string, bool>>
	{
		#region Singleton
		public static readonly LabelGatherer Instance = new LabelGatherer();

		private LabelGatherer()
		{
		}
		#endregion

		private static readonly IReadOnlyDictionary<string, bool> EmptyLabels = new Dictionary<string, bool>();

		public override IReadOnlyDictionary<string, bool> VisitLabelPattern(SpecParser.LabelPatternContext context)
		{
			return new Dictionary<string, bool>() { { context.label.Text, false } };
		}

		public override IReadOnlyDictionary<string, bool> VisitZeroOrMorePattern(SpecParser.ZeroOrMorePatternContext context)
		{
			return MarkRepeated(Visit(context.pattern()));
		}

		public override IReadOnlyDictionary<string, bool> VisitOneOrMorePattern(SpecParser.OneOrMorePatternContext context)
		{
			return MarkRepeated(Visit(context.pattern()));
		}

		public override IReadOnlyDictionary<string, bool> VisitRepeatPattern(SpecParser.RepeatPatternContext context)
		{
			return MarkRepeated(Visit(context.pattern()));
		}

		public override IReadOnlyDictionary<string, bool> VisitRepeatWithSeparatorPattern(SpecParser.RepeatWithSeparatorPatternContext context)
		{
			return MarkRepeated(Visit(context.pattern()));
		}

		public override IReadOnlyDictionary<string, bool> VisitConcatPattern(SpecParser.ConcatPatternContext context)
		{
			return Combine(context.pattern().Select(Visit));
		}

		public override IReadOnlyDictionary<string, bool> VisitAlternationPattern(SpecParser.AlternationPatternContext context)
		{
			return Combine(context.pattern().Select(Visit));
		}

		public override IReadOnlyDictionary<string, bool> VisitOptionalPattern(SpecParser.OptionalPatternContext context)
		{
			return Visit(context.pattern());
		}

		public override IReadOnlyDictionary<string, bool> VisitGroupingPattern(SpecParser.GroupingPatternContext context)
		{
			return Visit(context.pattern());
		}

		public override IReadOnlyDictionary<string, bool> VisitRulePattern(SpecParser.RulePatternContext context)
		{
			return EmptyLabels;
		}

		public override IReadOnlyDictionary<string, bool> VisitLiteralPattern(SpecParser.LiteralPatternContext context)
		{
			return EmptyLabels;
		}

		private static IReadOnlyDictionary<string, bool> Combine(IEnumerable<IReadOnlyDictionary<string, bool>> labelSets)
		{
			var labels = new Dictionary<string, bool>();
			foreach(var label in labelSets.SelectMany(labelSet => labelSet))
				labels[label.Key] = labels.ContainsKey(label.Key) /* It is repeated across sets */ || label.Value;

			return labels;
		}

		private static IReadOnlyDictionary<string, bool> MarkRepeated(IReadOnlyDictionary<string, bool> labels)
		{
			return labels.ToDictionary(i => i.Key, i => true);
		}
	}
}
