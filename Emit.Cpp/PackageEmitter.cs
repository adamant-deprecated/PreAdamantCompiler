using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Parser;
using static PreAdamant.Compiler.Parser.PreAdamantParser;

namespace PreAdamant.Compiler.Emit.Cpp
{
	public class PackageEmitter
	{
		private readonly PackageContext package;

		public PackageEmitter(PackageContext package)
		{
			this.package = package;
		}

		public string Emit()
		{
			var source = new SourceFileBuilder();
			source.WriteIndentedLine("#pragma once");
			source.WriteLine();

			source.WriteIndentedLine("// Dependencies");
			source.WriteIndentedLine("#include <cstdint>");
			source.WriteIndentedLine($"#include \"{CppRuntime.FileName}\"");
			foreach(var dependency in package.Dependencies)
				source.WriteIndentedLine($"#include \"{dependency.Package.Name}.cpp\"");

			source.WriteLine();

			source.WriteIndentedLine("// Package");
			source.WriteIndentedLine($"namespace {PackageName(package.Symbol)}");
			source.BeginBlock();
			Emit(source, package.Symbol.Children);
			source.EndBlock();

			EmitEntryPoint(source);

			return source.ToString();
		}

		private static void Emit(SourceFileBuilder source, IEnumerable<Symbol> symbols)
		{
			foreach(var symbol in symbols)
				symbol.Match()
					.With<Symbol<NamespaceDeclarationContext>>(ns =>
					{
						source.WriteIndentedLine($"namespace {ns.Name}");
						source.BeginBlock();
						Emit(source, ns.Children);
						source.EndBlock();
					})
					.With<Symbol<FunctionDeclarationContext>>(funcSymbol =>
					{
						var func = funcSymbol.Declarations.Single();

						var @params = func.Parameters.Select(CodeFor);
						source.WriteIndentedLine($"{CodeFor(func.returnType)} {func.Name}({string.Join(", ", @params)})");
						source.BeginBlock();
						Emit(source, func.methodBody());
						source.EndBlock();
					})
					.Exhaustive();
		}

		private static object CodeFor(ParameterContext parameter)
		{
			return parameter.Match().Returning<string>()
				.With<NamedParameterContext>(param => $"{CodeFor(param.referenceType())} {param.identifier().GetText()}")
				.Exhaustive();
		}

		private static void Emit(SourceFileBuilder source, MethodBodyContext methodBody)
		{
			foreach(var statement in methodBody.Statements)
				Emit(source, statement);
		}

		private static void Emit(SourceFileBuilder source, StatementContext statement)
		{
			statement.Match()
				.With<ReturnStatementContext>(@return =>
				{
					var code = @return.expression() != null ? $"return {CodeFor(@return.expression())};" : "return;";
					source.WriteIndentedLine(code);
				})
				.With<ExpressionStatementContext>(expStatement =>
				{
					source.WriteIndentedLine(CodeFor(expStatement.expression()) + ";");
				})
				.Exhaustive();
		}

		private static string CodeFor(ExpressionContext expression)
		{
			return expression.Match().Returning<string>()
				.With<IntLiteralExpressionContext>(literal =>
				{
					// TODO use the correctly calculated type for this
					return $"new int32_t({literal.Value})";
				})
				.With<CastExpressionContext>(cast =>
				{
					var type = cast.kind.Text;
					switch(type)
					{
						case "as!":
							return $"new {CodeFor(cast.valueType())}(*({CodeFor(cast.expression())}))";
						default:
							throw new NotSupportedException($"Cast type '{type}' not supported");
					}
				})
				.With<MemberExpressionContext>(memberAccess => $"({CodeFor(memberAccess.expression())})->{memberAccess.identifier().GetText()}")
				.With<StringLiteralExpressionContext>(literal =>
				{
					var encodedValue = Encoding.UTF8.GetBytes(literal.Value);
					var bytes = string.Join(", ", encodedValue.Select(b => "0x" + b.ToString("X")));
					var unsafeArray = $"new uint8_t[{encodedValue.Length}]{{{bytes}}}";
					return $"new ::__Adamant::Runtime::string(new size_t({encodedValue.Length}), {unsafeArray})";
				})
				.With<CallExpressionContext>(call =>
				{
					var args = call.argumentList()._expressions.Select(CodeFor);
					return $"{CodeFor(call.expression())}({string.Join(", ", args)})";
				})
				.With<NameExpressionContext>(name =>
				{
					// TODO we really need name binding to look this name up
					return name.GetText();
				})
				.Exhaustive();
		}

		private static string QualifiedName(Symbol symbol)
		{
			return symbol.Match().Returning<string>()
				// Start with :: becuase we are fully qualified and don't want to ever accidently pick up the wrong thing
				.With<Symbol<PackageContext>>(package => "::" + PackageName(symbol))
				.Any(() => QualifiedName(symbol.Parent) + "::" + symbol.Name);
		}

		private static string PackageName(Symbol symbol)
		{
			return symbol.Name.Replace(".", "__");
		}

		private static string CodeFor(ReferenceTypeContext type)
		{
			var valueType = CodeFor(type.ValueType);
			if(valueType == "void") return valueType;
			return valueType + (type.IsMutable ? "*" : " const * const");
		}

		private static string CodeFor(ValueTypeContext type)
		{
			return type.Match().Returning<string>()
				.With<NamedTypeContext>(namedType => CodeFor(namedType.name()))
				.Exhaustive();
		}

		private static string CodeFor(NameContext name)
		{
			return name.Match().Returning<string>()
				.With<UnqualifiedNameContext>(unqualifiedName => CodeFor(unqualifiedName.simpleName()))
				.With<QualifiedNameContext>(qualifiedName => { throw new NotImplementedException(); })
				.Exhaustive();
		}

		private static string CodeFor(SimpleNameContext simpleName)
		{
			return simpleName.Match().Returning<string>()
				.With<IdentifierNameContext>(identifierName =>
				{
					var code = identifierName.GetText();
					switch(code)
					{
						case "void":
							break;
						case "int":
						case "uint":
							code += "32_t";
							break;
						default:
							throw new NotImplementedException($"CodeFor identifier name {code}");
					}
					return code;
				})
				.Exhaustive();
		}

		private void EmitEntryPoint(SourceFileBuilder source)
		{
			var entryPoint = package.EntryPoints().SingleOrDefault();
			if(entryPoint == null) return;

			source.WriteLine();
			source.WriteIndentedLine("int main(int argc, char *argv[])");
			source.BeginBlock();
			var entryPointName = QualifiedName(entryPoint);
			var entryFunction = entryPoint.Declarations.Single();
			var returnType = CodeFor(entryFunction.returnType);
			switch(returnType)
			{
				case "void":
					source.WriteIndentedLine($"{entryPointName}();");
					source.WriteIndentedLine("return 0;");
					break;
				case "int32_t*":
				case "int32_t const * const":
					source.WriteIndentedLine($"auto exitCodePtr = {entryPointName}();");
					source.WriteIndentedLine("auto exitCode = *exitCodePtr;");
					source.WriteIndentedLine("delete exitCodePtr;");
					source.WriteIndentedLine("return exitCode;");
					break;
				default:
					throw new NotSupportedException($"Entry point return type of `{returnType}` not supported");
			}
			source.EndBlock();
		}
	}
}
