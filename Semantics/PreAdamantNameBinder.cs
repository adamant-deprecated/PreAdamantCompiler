using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Semantics
{
	public class PreAdamantNameBinder : NameBinder
	{
		public PreAdamantNameBinder()
		{
			var package = CreateNamespace("Package");
			var @namespace = CreateNamespace("Namespace");
			var entity = CreateNamespace("Entity");
			var member = CreateNamespace("Member");
			var constructor = CreateNamespace("Constructor");
			var variable = CreateNamespace("Variable");

			//For<PackageSyntax>()
			//	.Define(syntax =>
			//	{
			//		var name = syntax.Name;
			//		return package.Of(name);
			//	}, true);

			//For<UsingDirectiveSyntax>()
			//	.Import(syntax =>
			//	{
			//		//var ns = syntax.NamespaceName;
			//		//var n = ResolveReference(syntax, @namespace, ns);
			//		//return ResolveReference(n, entity);
			//		throw new NotImplementedException();
			//	});

			//For<ClassDeclarationSyntax>()
			//	.Define(syntax =>
			//	{
			//		var c = syntax.ClassName;
			//		//var p = syntax.TypeParameters;
			//		//var t = TypeOf(p);
			//		return entity.Of(c);
			//		//return entity.Of(c, t);
			//		throw new NotImplementedException();
			//	}, true)
			//	.Scope(entity, member, constructor);
		}

		public override Symbol BuildSymbols(PackageSyntax syntax)
		{
			var packageSymbol = new SymbolBuilder(null, syntax.Name, false); // TODO symbol type?
			foreach(var compilationUnit in syntax.CompilationUnits)
				BuildSymbols(compilationUnit.Root, packageSymbol);

			return packageSymbol.Build();
		}

		private void BuildSymbols(CompilationUnitSyntax compilationUnit, SymbolBuilder packageSymbol)
		{
			foreach(var declaration in compilationUnit.Declarations)
				BuildSymbols(declaration, packageSymbol);
		}

		private void BuildSymbols(DeclarationSyntax declaration, SymbolBuilder parentSymbol)
		{
			declaration.Match()
				.With<NamespaceDeclarationSyntax>(ns =>
				{
					var parent = parentSymbol;
					foreach(var identifier in ns.NamespaceName.Identifiers)
					{
						var nsName = identifier.Value;
						var existingNS = parent.FindChild(nsName);
						if(existingNS == null)
						{
							existingNS = new SymbolBuilder(parent, nsName, false);
							parent.AddChild(existingNS);
						}
						existingNS.AddDeclaration(declaration);
						parent = existingNS;
					}
					foreach(var childDeclaration in ns.Declarations)
						BuildSymbols(childDeclaration, parent);
				})
				.With<FunctionDeclarationSyntax>(func =>
				{
					var funcSymbol = new SymbolBuilder(parentSymbol,func.Identifier.Value,false);
					funcSymbol.AddDeclaration(func);
					parentSymbol.AddChild(funcSymbol);
				})
				.Exhaustive();
		}
	}
}
