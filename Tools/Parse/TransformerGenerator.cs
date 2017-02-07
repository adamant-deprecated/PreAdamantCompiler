using System.Text;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class TransformerGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			var transformerName = spec.Name.Replace("Parser", "") + "SyntaxTransformer";
			var antlrParser = $"{spec.Name}_Antlr";

			builder.AppendLine("using System.Collections.Generic;");
			builder.AppendLine("using System.Linq;");
			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			// Transformer Class
			builder.AppendLine($"	internal partial class {transformerName} : IPreAdamantParser_AntlrVisitor<ISyntaxNode>");
			builder.AppendLine("	{");

			foreach(var rule in spec.Rules.Values)
			{
				var caseName = Inflector.ToIdentifier(rule.Name);
				var syntaxClass = Inflector.ToSyntaxClass(rule.Name);
				var contextClass = Inflector.ToContextClass(rule.Name);
				builder.AppendLine($"		ISyntaxNode I{antlrParser}Visitor<ISyntaxNode>.Visit{caseName}({antlrParser}.{contextClass} context)");
				builder.AppendLine("		{");
				builder.AppendLine("			var children = context.children?.Select(c => c.Accept(this)).ToList() ?? NoChildren;");
				builder.AppendLine("			var allChildren = InterleaveTriva(children);");
				builder.AppendLine($"			return allChildren.Any() ? new {syntaxClass}(context, allChildren) : new {syntaxClass}(context.Start.StartIndex);");
				builder.AppendLine("		}");
				builder.AppendLine();
			}

			builder.AppendLine("	}");

			builder.AppendLine("}");
			return builder.ToString();
		}
	}
}
