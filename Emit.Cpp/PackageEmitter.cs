using System.Collections.Generic;
using System.Linq;
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

						// TODO write correct return type
						// TODO write correct parameter types
						source.WriteIndentedLine($"{TypeOf(func.returnType)} {func.Name}()");
						source.BeginBlock();
						Emit(source, func.methodBody());
						source.EndBlock();
					})
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
				.Exhaustive();
		}

		private static string CodeFor(ExpressionContext expression)
		{
			return expression.Match().Returning<string>()
				.Exhaustive();
			//	return expression.Match().Returning<string>()
			//		.With<IntegerLiteral>(literal =>
			//		{
			//			// TODO use the correctly calculated type for this
			//			return $"new int32_t({literal.Value})";
			//		})
			//		.With<StringLiteral>(literal =>
			//		{
			//			var encodedValue = Encoding.UTF8.GetBytes(literal.Value);
			//			var bytes = string.Join(", ", encodedValue.Select(b => "0x" + b.ToString("X")));
			//			var unsafeArray = $"new uint8_t[{encodedValue.Length}]{{{bytes}}}";
			//			return $"new ::__Adamant::Runtime::string(new size_t({encodedValue.Length}), {unsafeArray})";
			//		})
			//		.With<MemberAccess>(memberAccess => $"({CodeFor(memberAccess.Expression)})->{memberAccess.Member}")
			//		.With<Cast>(cast =>
			//		{
			//			if(cast.CastType != CastType.Panic)
			//				throw new NotSupportedException($"Cast type '{cast.CastType}' not supported");
			//			return cast.Type.Match().Returning<string>()
			//				.With<IntType>(intType => $"new {TypeOf(intType)}(*({CodeFor(cast.Expression)}))")
			//				.Exhaustive();
			//		})
			//		.Exhaustive();
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

		private static string CodeFor(NameContext name)
		{
			return name.Match().Returning<string>()
				.With<UnqualifiedNameContext>(unqualifiedName => unqualifiedName.simpleName().Match().Returning<string>()
					.With<IdentifierNameContext>(identName => identName.identifierOrPredefinedType().token.Text)
					.Exhaustive())
				.Exhaustive();
		}

		private static string TypeOf(ReferenceTypeContext type)
		{
			return type.ValueType.Match().Returning<string>()
				.With<NamedTypeContext>(valueType => CodeFor(valueType.name()))
				.Exhaustive();
		}
		//private static string TypeOf(ReferenceType type)
		//{
		//	return type.Type.Match().Returning<string>()
		//		.With<VoidType>(voidType => "void")
		//		.With<IntType>(intType =>
		//		{
		//			var coreType = intType.IsSigned ? "int" : "uint";
		//			return $"{coreType}{intType.BitLength}_t*";
		//		})
		//		.Exhaustive();
		//}
		//private static string TypeOf(ValueType type)
		//{
		//	return type.Match().Returning<string>()
		//		.With<VoidType>(voidType => "void")
		//		.With<IntType>(intType =>
		//		{
		//			var coreType = intType.IsSigned ? "int" : "uint";
		//			return $"{coreType}{intType.BitLength}_t";
		//		})
		//		.Exhaustive();
		//}

		private void EmitEntryPoint(SourceFileBuilder source)
		{
			var entryPoint = package.EntryPoints().SingleOrDefault();
			if(entryPoint == null) return;

			source.WriteLine();
			source.WriteIndentedLine("int main(int argc, char *argv[])");
			source.BeginBlock();
			var entryPointName = QualifiedName(entryPoint);
			var entryFunction = entryPoint.Declarations.Single();
			if(entryFunction.IsVoidReturn)
			{
				source.WriteIndentedLine($"{entryPointName}();");
				source.WriteIndentedLine("return 0;");
			}
			else
			{
				source.WriteIndentedLine($"auto exitCodePtr = {entryPointName}();");
				source.WriteIndentedLine("auto exitCode = *exitCodePtr;");
				source.WriteIndentedLine("delete exitCodePtr;");
				source.WriteIndentedLine("return exitCode;");
			}
			source.EndBlock();
		}
	}
}
