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
			source.WriteIndentedLine("// Package Declaration");
			source.WriteIndentedLine($"namespace {PackageName(package.Symbol)}");
			source.BeginBlock();
			EmitDeclaration(source, package.Symbol.Children);
			source.EndBlock();

			source.WriteLine();
			source.WriteIndentedLine("// Package Definition");
			source.WriteIndentedLine($"namespace {PackageName(package.Symbol)}");
			source.BeginBlock();
			EmitDefinition(source, package.Symbol.Children);
			source.EndBlock();

			EmitEntryPoint(source);

			return source.ToString();
		}

		#region EmitDeclaration
		private static void EmitDeclaration(SourceFileBuilder source, IEnumerable<Symbol> symbols)
		{
			foreach(var symbol in symbols)
				symbol.Match()
					.With<Symbol<NamespaceDeclarationContext>>(ns =>
					{
						source.WriteIndentedLine($"namespace {ns.Name}");
						source.BeginBlock();
						EmitDeclaration(source, ns.Children);
						source.EndBlock();
					})
					.With<Symbol<FunctionDeclarationContext>>(funcSymbol =>
					{
						var func = funcSymbol.Declarations.Single();
						source.WriteIndentedLine(FunctionSignature(func) + ";");
					})
					.Exhaustive();
		}
		#endregion

		#region EmitDefinition
		private static void EmitDefinition(SourceFileBuilder source, IEnumerable<Symbol> symbols)
		{
			foreach(var symbol in symbols)
				symbol.Match()
					.With<Symbol<NamespaceDeclarationContext>>(ns =>
					{
						source.WriteIndentedLine($"namespace {ns.Name}");
						source.BeginBlock();
						EmitDefinition(source, ns.Children);
						source.EndBlock();
					})
					.With<Symbol<FunctionDeclarationContext>>(funcSymbol =>
					{
						var func = funcSymbol.Declarations.Single();

						source.WriteIndentedLine(FunctionSignature(func));
						source.BeginBlock();
						EmitDefinition(source, func.methodBody());
						source.EndBlock();
					})
					.Exhaustive();
		}

		private static void EmitDefinition(SourceFileBuilder source, MethodBodyContext methodBody)
		{
			foreach(var statement in methodBody.Statements)
				EmitDefinition(source, statement);
		}

		private static void EmitDefinition(SourceFileBuilder source, StatementContext statement)
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
		#endregion

		#region CodeFor Expressions
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
							return $"new {TypeName(cast.valueType())}(*({CodeFor(cast.expression())}))";
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
				.With<NameExpressionContext>(name => QualifiedName(name.ReferencedSymbol))
				.Exhaustive();
		}
		#endregion

		#region Names
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
		#endregion

		#region Signatures
		private static string FunctionSignature(FunctionDeclarationContext func)
		{
			var @params = func.Parameters.Select(ParameterSignature);
			return $"{TypeName(func.returnType)} {func.Name}({string.Join(", ", @params)})";
		}

		private static string ParameterSignature(ParameterContext parameter)
		{
			return parameter.Match().Returning<string>()
				.With<NamedParameterContext>(param => $"{TypeName(param.referenceType())} {param.identifier().GetText()}")
				.Exhaustive();
		}
		#endregion

		#region TypeNames

		private static string TypeName(ReferenceTypeContext type)
		{
			var valueType = TypeName(type.ValueType);
			if(valueType == "void") return valueType;
			return valueType + (type.IsMutable ? "*" : " const * const");
		}

		private static string TypeName(ValueTypeContext type)
		{
			return type.Match().Returning<string>()
				.With<NamedTypeContext>(namedType => TypeName(namedType.name()))
				.Exhaustive();
		}

		private static string TypeName(NameContext name)
		{
			return name.Match().Returning<string>()
				.With<UnqualifiedNameContext>(unqualifiedName => TypeName(unqualifiedName.simpleName()))
				.With<QualifiedNameContext>(qualifiedName => { throw new NotImplementedException(); })
				.Exhaustive();
		}

		private static string TypeName(SimpleNameContext simpleName)
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
		#endregion

		private void EmitEntryPoint(SourceFileBuilder source)
		{
			var entryPoint = package.EntryPoints().SingleOrDefault();
			if(entryPoint == null) return;

			source.WriteLine();
			source.WriteIndentedLine("// Entry Point");
			source.WriteIndentedLine("int main(int argc, char *argv[])");
			source.BeginBlock();
			var entryPointName = QualifiedName(entryPoint);
			var entryFunction = entryPoint.Declarations.Single();
			var returnType = TypeName(entryFunction.returnType);
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
