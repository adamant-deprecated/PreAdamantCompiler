using System.Text;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class LexerGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			var antlrLexer = $"{spec.Name}_Antlr";

			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			// Lexer Class
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
			builder.AppendLine("	}");

			builder.AppendLine("}");
			return builder.ToString();
		}
	}
}
