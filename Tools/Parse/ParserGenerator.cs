using System.Text;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class ParserGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			// Parser Class
			builder.AppendLine($"	public partial class {spec.Name}");
			builder.AppendLine("	{");
			builder.AppendLine("	}");

			builder.AppendLine("}");
			return builder.ToString();
		}
	}
}
