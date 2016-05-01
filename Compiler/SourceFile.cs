using System.IO;
using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler
{
	public class SourceFile : SourceText
	{
		private readonly FileInfo fileInfo;

		public SourceFile(FileInfo fileInfo)
		{
			this.fileInfo = fileInfo;
		}

		public override string Name => fileInfo.FullName;

		public string Path => fileInfo.FullName;

		internal override PreAdamantParser NewParser()
		{
			return new PreAdamantParser(Path);
		}
	}
}
