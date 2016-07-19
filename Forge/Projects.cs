using System;
using System.Collections.ObjectModel;

namespace PreAdamant.Compiler.Forge
{
	public class Projects : KeyedCollection<string, Project>
	{
		protected override string GetKeyForItem(Project item)
		{
			throw new NotImplementedException();
			//return item.Name;
		}
	}
}
