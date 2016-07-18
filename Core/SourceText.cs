using System;
using System.IO;

namespace PreAdamant.Compiler.Core
{
	public class SourceText : ISourceText
	{
		public SourceText(string package, string name, FileInfo fileInfo)
		{
			Package = package;
			Name = name;
			Text = File.ReadAllText(fileInfo.FullName);
		}

		public SourceText(string package, string name, TextReader reader)
		{
			Package = package;
			Name = name;
			Text = reader.ReadToEnd();
		}

		public string Package { get; }
		public string Name { get; }
		public string Text { get; }

		public int CompareTo(ISourceText other)
		{
			var result = string.Compare(Package, other.Package, StringComparison.InvariantCultureIgnoreCase);
			return result != 0 ? result : string.Compare(Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
		}
	}
}
