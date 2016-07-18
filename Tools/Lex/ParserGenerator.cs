using System.Linq;
using System.Text;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class ParserGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			var antlrLexer = $"{spec.Name}_Antlr";
			var tokenTypes = spec.ModeBlocks.SelectMany(b => b.Rules.Values).Where(r => r.IsTokenType).ToList();

			builder.AppendLine("using System;");
			builder.AppendLine("using PreAdamant.Compiler.Core;");
			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			// Parser Class
			builder.AppendLine($"	public partial class {spec.Name}");
			builder.AppendLine("	{");
			builder.AppendLine($"		private const int StartMode = {antlrLexer}.{spec.StartMode};");
			builder.AppendLine("		public enum Channel");
			builder.AppendLine("		{");
			builder.AppendLine("			Main = 0,");
			foreach(var channel in spec.Channels)
			{
				builder.AppendLine($"			{channel},");
			}
			builder.AppendLine("		}");
			builder.AppendLine();
			builder.AppendLine("		private Token CreateToken(SourceText source, int startIndex, int stopIndex, int type, Channel channel, string text)");
			builder.AppendLine("		{");
			builder.AppendLine("			switch(type)");
			builder.AppendLine("			{");
			foreach(var rule in tokenTypes)
			{
				builder.AppendLine($"				case {antlrLexer}.{rule.Name}:");
				builder.AppendLine($"					return new {rule.Name}Token(source, startIndex, stopIndex, type, channel, text);");
			}
			builder.AppendLine("				default:");
			builder.AppendLine("					throw new Exception($\"Unknown token type {type}\");");
			builder.AppendLine("			}");
			builder.AppendLine("		}");
			builder.AppendLine("	}");

			// Token Classes
			foreach(var rule in tokenTypes)
			{
				var baseClass = rule.Base == null ? "Token" : rule.Base + "Token";

				builder.AppendLine();
				builder.AppendLine($"	public partial class {rule.Name}Token : {baseClass}");
				builder.AppendLine("	{");
				builder.AppendLine($"		public {rule.Name}Token(SourceText source, int startIndex, int stopIndex, int type, {spec.Name}.Channel channel, string text)");
				builder.AppendLine("			: base(source, startIndex, stopIndex, type, channel, text)");
				builder.AppendLine("		{");
				builder.AppendLine("		}");
				builder.AppendLine("	}");
			}

			builder.AppendLine("}");
			return builder.ToString();
		}
	}
}
