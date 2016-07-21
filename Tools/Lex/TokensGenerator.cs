using System.Linq;
using System.Text;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class TokensGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			var tokenTypes = spec.ModeBlocks.SelectMany(b => b.Rules.Values).Where(r => r.IsTokenType).ToList();

			builder.AppendLine("using System;");
			builder.AppendLine("using Antlr4.Runtime;");
			builder.AppendLine("using PreAdamant.Compiler.Core;");
			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			foreach(var rule in tokenTypes)
				GenerateTokenClass(builder, spec.Name, rule);

			builder.AppendLine("}");
			return builder.ToString();
		}

		private static void GenerateTokenClass(StringBuilder builder, string lexerName, Rule rule)
		{
			var baseClass = rule.Base == null ? "SyntaxToken" : rule.Base + "Token";

			builder.AppendLine();
			builder.AppendLine($"	public partial class {rule.Name}Token : {baseClass}");
			builder.AppendLine("	{");
			builder.AppendLine($"		public {rule.Name}Token(ISourceText source, int startIndex, int stopIndex, {lexerName}.Channel channel, string text)");
			builder.AppendLine("			: base(source, startIndex, stopIndex, channel, text)");
			builder.AppendLine("		{");
			builder.AppendLine("		}");
			builder.AppendLine("	}");
		}
	}
}
