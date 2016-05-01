using System.IO;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler
{
	public class SourceFile : SourceText
	{
		private readonly FileInfo fileInfo;

		public SourceFile(string package, string name, FileInfo fileInfo)
		{
			Package = package;
			Name = name;
			this.fileInfo = fileInfo;
		}

		public override string Package { get; }
		public override string Name { get; }

		public string Path => fileInfo.FullName;

		internal override PreAdamantParser NewParser()
		{
			return new PreAdamantParser(Path);
		}
	}
}
