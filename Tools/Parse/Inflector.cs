namespace PreAdamant.Compiler.Tools.Parse
{
	public static class Inflector
	{
		public static string ToSyntaxClass(string name)
		{
			return ToIdentifier(name) + "Syntax";
		}

		public static string ToContextClass(string name)
		{
			return ToIdentifier(name) + "Context";
		}

		public static string ToIdentifier(string name)
		{
			var firstChar = name[0];
			if(char.IsLower(firstChar))
				name = char.ToUpper(firstChar) + name.Substring(1);
			return name;
		}
	}
}