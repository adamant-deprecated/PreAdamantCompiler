using PreAdamant.Compiler.Parser;

namespace PreAdamant.Compiler.Forge
{
	public class Project
	{
		public readonly string ProjectDirectory;
		public readonly PackageContext Package;
		public string Name => Package.Name;

		public Project(string projectDirectory, PackageContext package)
		{
			ProjectDirectory = projectDirectory;
			Package = package;
		}
	}
}
