using System.Linq;
using PreAdamant.Compiler.Common;

namespace PreAdamant.Compiler.Syntax
{
	public partial class IdentifierSyntax
	{
		private string value;

		public string Value => value ?? (value = GetValue());

		private string GetValue()
		{

			var identifierToken = Children.First();
			return identifierToken.Match().Returning<string>()
				.With((IdentifierToken id) => id.Text)
				.With((EscapedIdentifierToken id) => id.Text.Substring(1))
				.Exhaustive();
		}
	}
}