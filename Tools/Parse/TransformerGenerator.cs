using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class TransformerGenerator
	{
		public string Generate(Spec spec)
		{
			var builder = new StringBuilder();

			var transformerName = spec.Name.Replace("Parser", "") + "SyntaxTransformer";
			var antlrParser = $"{spec.Name}_Antlr";
			//var tokenTypes = spec.ModeBlocks.SelectMany(b => b.Rules.Values).Where(r => r.IsTokenType).ToList();

			builder.AppendLine("using System;");
			builder.AppendLine("using Antlr4.Runtime;");
			builder.AppendLine("using PreAdamant.Compiler.Core;");
			builder.AppendLine($"using {spec.Namespace}.Antlr;");
			builder.AppendLine();
			builder.AppendLine($"namespace {spec.Namespace}");
			builder.AppendLine("{");

			// Lexer Class
			builder.AppendLine($"	internal partial class {transformerName} : IPreAdamantParser_AntlrVisitor<ISyntax>");
			builder.AppendLine("	{");
			builder.AppendLine("		private readonly ISourceText source;");
			builder.AppendLine();
			builder.AppendLine($"		public {transformerName}(ISourceText source)");
			builder.AppendLine("		{");
			builder.AppendLine("			this.source = source;");
			builder.AppendLine("		}");
			builder.AppendLine();
			builder.AppendLine($"		internal CompilationUnitSyntax Transform({antlrParser}.CompilationUnitContext compilationUnit)");
			builder.AppendLine("		{");
			////SourceText source, int startIndex, int stopIndex, int type, Channel channel, string text
			//builder.AppendLine("			var type = token.Type;");
			//builder.AppendLine("			var startIndex = token.StartIndex;");
			//builder.AppendLine("			var stopIndex = token.StopIndex;");
			//builder.AppendLine($"			var channel = ({spec.Name}.Channel)token.Channel;");
			//builder.AppendLine("			var text = token.Text;");
			//builder.AppendLine("			switch(type)");
			//builder.AppendLine("			{");
			//foreach(var rule in tokenTypes)
			//{
			//	builder.AppendLine($"				case {antlrLexer}.{rule.Name}:");
			//	builder.AppendLine($"					return new {rule.Name}Token(source, startIndex, stopIndex, channel, text);");
			//}
			//builder.AppendLine("				default:");
			//builder.AppendLine("					throw new Exception($\"Unknown token type {type}\");");
			//builder.AppendLine("			}");
			builder.AppendLine("		}");
			builder.AppendLine("	}");

			builder.AppendLine("}");
			return builder.ToString();
		}
	}
}
