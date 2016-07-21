using System.Collections.Generic;
using System.Text;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class SyntaxGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			var baseClasses = new HashSet<string>();

			foreach(var rule in spec.Rules.Values)
			{
				var baseClass = rule.Base == null ? "SyntaxNode" : ToClassName(rule.Base) + "Syntax";
				baseClasses.Add(baseClass);

				builder.AppendLine($"	public partial class {ToClassName(rule.Name)}Syntax : {baseClass}");
				builder.AppendLine("	{");
				builder.AppendLine("	}");
				builder.AppendLine();
			}
			baseClasses.Remove("SyntaxNode");

			foreach(var baseClass in baseClasses)
			{
				builder.AppendLine($"	public partial class {baseClass} : SyntaxNode");
				builder.AppendLine("	{");
				builder.AppendLine("	}");
				builder.AppendLine();
			}

			builder.AppendLine("}");
			return builder.ToString();
		}

		public static string ToClassName(string name)
		{
			var firstChar = name[0];
			if(char.IsLower(firstChar))
				return char.ToUpper(firstChar) + name.Substring(1);

			return name;
		}
	}
}
