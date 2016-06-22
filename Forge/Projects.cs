using System.Collections.ObjectModel;

namespace PreAdamant.Compiler.Forge
{
	public class Projects : KeyedCollection<string, Project>
	{
		protected override string GetKeyForItem(Project item)
		{
			return item.Name;
		}
	}
}
