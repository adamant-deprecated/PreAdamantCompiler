using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class SyntaxGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			builder.AppendLine("using System.Collections.Generic;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			var baseClasses = new HashSet<string>();

			foreach(var rule in spec.Rules.Values)
			{
				var baseClass = rule.Base == null ? "SyntaxNode" : Inflector.ToSyntaxClass(rule.Base);
				baseClasses.Add(baseClass);

				GenerateClass(builder, rule, Inflector.ToSyntaxClass(rule.Name), baseClass);
			}
			baseClasses.Remove("SyntaxNode");

			foreach(var baseClass in baseClasses)
			{
				GenerateClass(builder, null, baseClass, "SyntaxNode");
			}

			builder.AppendLine("}");
			return builder.ToString();
		}

		private static void GenerateClass(StringBuilder builder, Rule rule, string className, string baseClass)
		{
			builder.AppendLine($"	public partial class {className} : {baseClass}");
			builder.AppendLine("	{");

			if(rule != null)
			{
				foreach(var childRule in rule.Children)
				{
					var propertyType = Inflector.ToClass(childRule.Rule);
					if(childRule.Repeated)
						propertyType = $"IReadOnlyList<{propertyType}>";
					builder.AppendLine($"		public {propertyType} {childRule.Label} {{ get; }}");
				}
				if(rule.Children.Any())
					builder.AppendLine();
			}

			builder.AppendLine($"		public {className}(IEnumerable<ISyntax> allChildren)");
			builder.AppendLine("			: base(allChildren)");
			builder.AppendLine("		{");
			builder.AppendLine("		}");
			builder.AppendLine();
			builder.AppendLine($"		public {className}(int offset)");
			builder.AppendLine("			: base(offset)");
			builder.AppendLine("		{");
			builder.AppendLine("		}");

			builder.AppendLine("	}");
			builder.AppendLine();
		}
	}
}
