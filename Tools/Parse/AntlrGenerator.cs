using System.Linq;
using System.Text;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class AntlrGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			var patternBuilder = new PatternBuilder(spec);
			builder.AppendLine($"parser grammar {spec.Name}_Antlr;");
			builder.AppendLine("");
			builder.AppendLine("options");
			builder.AppendLine("{");
			builder.AppendLine("	language = CSharp;");
			builder.AppendLine($"	tokenVocab = {spec.Name.Replace("Parser", "Lexer")+ "_Antlr"};"); // TODO better way?
			builder.AppendLine("}");
			builder.AppendLine("");

			var ruleLookup = spec.Rules.Values.ToLookup(r => r.Base == null);

			builder.AppendLine("// Unlabeled Alternatives Rules");
			foreach(var rule in ruleLookup[true])
			{
				var pattern = patternBuilder.Visit(rule.Pattern);
				builder.AppendLine($"{rule.Name}: {pattern};");
			}

			builder.AppendLine();
			builder.AppendLine("// Labeled Alternatives Rules");
			foreach(var ruleGroup in ruleLookup[false].GroupBy(r => r.Base))
			{
				var isFirst = true;
				foreach(var rule in ruleGroup)
				{
					var separator = "|";
					if(isFirst)
					{
						builder.AppendLine(rule.Base);
						separator = ":";
						isFirst = false;
					}
					var pattern = patternBuilder.Visit(rule.Pattern);
					builder.AppendLine($"	{separator} {pattern} #{rule.Name}");
				}
				builder.AppendLine("	;");
				builder.AppendLine();
			}

			return builder.ToString();
		}
	}
}
