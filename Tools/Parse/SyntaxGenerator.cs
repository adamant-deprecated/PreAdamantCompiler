using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class SyntaxGenerator
	{
		public string Generate(Spec spec)
		{
			var antlrParser = $"{spec.Name}_Antlr";

			var builder = new StringBuilder();

			builder.AppendLine("using System.Collections.Generic;");
			builder.AppendLine("using System.Linq;");
			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			var baseClasses = new HashSet<string>();

			foreach(var rule in spec.Rules.Values)
			{
				var baseClass = rule.Base == null ? "SyntaxNode" : Inflector.ToSyntaxClass(rule.Base);
				baseClasses.Add(baseClass);

				GenerateClass(builder, antlrParser, rule, Inflector.ToSyntaxClass(rule.Name), baseClass);
			}
			baseClasses.Remove("SyntaxNode");

			foreach(var baseClass in baseClasses)
			{
				GenerateClass(builder, antlrParser, null, baseClass, "SyntaxNode");
			}

			builder.AppendLine("}");
			return builder.ToString();
		}

		private static void GenerateClass(StringBuilder builder, string antlrParser, Rule rule, string className, string baseClass)
		{
			builder.AppendLine($"	public partial class {className} : {baseClass}");
			builder.AppendLine("	{");

			if(rule != null)
			{
				foreach(var childRule in rule.Children)
				{
					var propertyType = childRule.Rule == null ? "bool" : Inflector.ToClass(childRule.Rule);
					if(childRule.Repeated)
						propertyType = $"IReadOnlyList<{propertyType}>";
					builder.AppendLine($"		public {propertyType} {childRule.Label} {{ get; }}");
				}
				if(rule.Children.Any())
					builder.AppendLine();

				var contextClass = Inflector.ToContextClass(rule.Name);
				builder.AppendLine($"		public {className}({antlrParser}.{contextClass} context, IEnumerable<ISyntaxNode> allChildren)");
			}
			else
				builder.AppendLine($"		public {className}(IEnumerable<ISyntaxNode> allChildren)");

			builder.AppendLine("			: base(allChildren)");
			builder.AppendLine("		{");
			if(rule != null)
			{
				foreach(var childRule in rule.Children)
				{
					string value;
					if(childRule.Rule == null)
					{
						value = $"context.{childRule.RawLabel} != null";
					}
					else
					{
						var propertyType = Inflector.ToClass(childRule.Rule);
						var action = childRule.Repeated ? "ToList" : "SingleOrDefault";
						value = $"Children.OfType<{propertyType}>().{action}()";
					}
					builder.AppendLine($"			{childRule.Label} = {value};");
				}
			}
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
