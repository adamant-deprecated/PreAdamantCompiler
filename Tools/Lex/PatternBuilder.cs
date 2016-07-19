using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime.Tree;

namespace PreAdamant.Compiler.Tools.Lex
{
	/// <summary>
	/// Produces a pattern for ANTLR from our regular expression pattern.  Note that each
	/// operation should produce an indivisible unit in the target language, this means
	/// many patterns return something surrounded by parens.  This ensures that order of
	/// operations is correctly handled since ANTLR hasn't published their order of operations.
	/// There are two exceptions to this, alternation `|` and concatenation ` ` are assumed to
	/// have the same precendence and be safe.
	/// </summary>
	internal class PatternBuilder : SpecParserSafeBaseVisitor<string>
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

		public override string VisitNegatePattern(SpecParser.NegatePatternContext context)
		{
			return $"(~{Visit(context.pattern())})";
		}

		public override string VisitUpToPattern(SpecParser.UpToPatternContext context)
		{
			return $"(.*? {Visit(context.pattern())})";
		}

		public override string VisitConcatPattern(SpecParser.ConcatPatternContext context)
		{
			// One of the exception to indivisible units so no parens
			return String.Join(" ", context.pattern().Select(Visit));
		}

		public override string VisitAlternationPattern(SpecParser.AlternationPatternContext context)
		{
			// One of the exception to indivisible units so no parens
			return String.Join(" | ", context.pattern().Select(Visit));
		}

		public override string VisitRulePattern(SpecParser.RulePatternContext context)
		{
			var ruleName = context.ruleName.Text;
			return isRoot ? ruleName : BuildRule(this, ruleName);
		}

		public override string VisitAnyPattern(SpecParser.AnyPatternContext context)
		{
			return $"(~[{NewLineChars}])";
		}

		public override string VisitLiteralPattern(SpecParser.LiteralPatternContext context)
		{
			var value = context.GetText();
			return value.StartsWith("\"") ? $"'{value.Substring(1, value.Length - 2)}'" : $"'{value}'";
		}

		public override string VisitImportedRulePattern(SpecParser.ImportedRulePatternContext context)
		{
			Spec lexerSpec;
			if(!spec.Imports.TryGetValue(context.lexerName.Text, out lexerSpec))
				throw new Exception($"Incorrect reference to imported lexer '{context.lexerName.Text}'");
			var ruleName = context.ruleName.Text;
			return BuildRule(new PatternBuilder(lexerSpec, false), ruleName);
		}

		public override string VisitCharClassPattern(SpecParser.CharClassPatternContext context)
		{
			var isNegated = context.negate != null;
			var alternatives = new StringBuilder();
			var classBlock = new StringBuilder();
			foreach(var charSet in context.charSet())
			{
				SpecParser.PredefinedClassCharContext predefinedClassCharContext;
				SpecParser.SingleCharContext singleCharContext;
				SpecParser.CharRangeContext charRangeContext;
				if((predefinedClassCharContext = charSet as SpecParser.PredefinedClassCharContext) != null)
					BuildCharClass(predefinedClassCharContext, alternatives, classBlock, isNegated);
				else if((singleCharContext = charSet as SpecParser.SingleCharContext) != null)
					classBlock.Append(BuildCharClass(singleCharContext.@char()));
				else if((charRangeContext = charSet as SpecParser.CharRangeContext) != null)
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

		public override string VisitPredefinedClassPattern(SpecParser.PredefinedClassPatternContext context)
		{
			var predefinedClass = context.GetText();
			switch(predefinedClass)
			{
				case @"\d":
					return "[0-9]";
				case @"\D":
					return "(~[0-9])";
				case @"\s":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeWhitespace);
					return AntlrGenerator.UnicodeWhitespace;
				case @"\S":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeNotWhitespace);
					return AntlrGenerator.UnicodeNotWhitespace;
				case @"\w":
				case @"\W":
					throw new NotImplementedException();
				case @"\R":
					return $"('\\r\\n'|[{NewLineChars}])";
				case @"\p{Letter}":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeLetter);
					return AntlrGenerator.UnicodeLetter;
				case @"\p{Digit}":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeDigit);
					return AntlrGenerator.UnicodeDigit;
				case @"\p{Connector_Punctuation}":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeConnectorPunctuation);
					return AntlrGenerator.UnicodeConnectorPunctuation;
				case @"\p{Non_Spacing_Mark}":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeNonSpacingMark);
					return AntlrGenerator.UnicodeNonSpacingMark;
				case @"\p{Spacing_Combining_Mark}":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeSpacingCombiningMark);
					return AntlrGenerator.UnicodeSpacingCombiningMark;
				case @"\p{Format}":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeFormat);
					return AntlrGenerator.UnicodeFormat;
				default:
					throw new NotImplementedException();
			}
		}

		private string BuildRule(PatternBuilder builder, string ruleName)
		{
			SpecParser.PatternContext pattern;
			Fragment fragment;
			if(builder.spec.Fragments.TryGetValue(ruleName, out fragment))
				pattern = fragment.Pattern;
			else
				pattern = builder.spec.ModeBlocks.Single(b => b.Rules.ContainsKey(ruleName)).Rules[ruleName].Pattern;
			var result = builder.Visit(pattern);
			PredefinedFragmentsUsed.UnionWith(builder.PredefinedFragmentsUsed); // Pull forward any predefined sets
			return result;
		}

		private void BuildCharClass(SpecParser.PredefinedClassCharContext context, StringBuilder alternatives, StringBuilder classBlock, bool isNegated)
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
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeWhitespace);
					alternatives.Append(AntlrGenerator.UnicodeWhitespace + "|");
					break;
				case @"\S":
					PredefinedFragmentsUsed.Add(AntlrGenerator.UnicodeNotWhitespace);
					alternatives.Append(AntlrGenerator.UnicodeNotWhitespace + "|");
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

		private static string BuildCharClass(SpecParser.CharContext context)
		{
			var token = ((ITerminalNode)context.children.Single()).Symbol;
			switch(token.Type)
			{
				case SpecParser.Char:
				case SpecParser.Caret:
				case SpecParser.EscapedChar:
				case SpecParser.EscapedDash:
					return token.Text;
				default:
					throw new NotSupportedException();
			}
		}

		private static string BuildCharClass(SpecParser.CharRangeContext context)
		{
			var left = context.@char(0);
			var right = context.@char(1);
			return $"{BuildCharClass(left)}-{BuildCharClass(right)}";
		}
	}
}