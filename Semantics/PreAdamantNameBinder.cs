using System;
using PreAdamant.Compiler.Syntax;

namespace PreAdamant.Compiler.Semantics
{
	public class PreAdamantNameBinder : NameBinder
	{
		public PreAdamantNameBinder()
		{
			var @namespace = CreateNamespace("Namespace");
			var entity = CreateNamespace("Entity");
			var member = CreateNamespace("Member");
			var constructor = CreateNamespace("Constructor");
			var variable = CreateNamespace("Variable");

			For<UsingDirectiveSyntax>()
				.Import(syntax =>
				{
					//var ns = syntax.Name;
					//var n = ResolveReference(syntax, @namespace, ns);
					//return ResolveReference(n, entity);
					throw new NotImplementedException();
				});

			For<ClassDeclarationSyntax>()
				.Define(syntax =>
				{
					//var c = syntax.Name;
					//var p = syntax.TypeParameters;
					//var t = TypeOf(p);
					//return entity.Of(c, t);
					throw new NotImplementedException();
				}, true)
				.Scope(entity, member, constructor);
		}
	}
}
