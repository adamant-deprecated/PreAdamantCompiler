using Humanizer;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class ChildRule
	{
		public readonly string Rule;
		public readonly string RawLabel;
		public readonly string Label;
		public readonly bool Repeated;

		public ChildRule(string rule, string label, bool repeated)
		{
			Rule = rule;
			var property = label ?? rule;
			RawLabel = property;
			property = property.Pascalize();
			if(repeated)
				property = property.Pluralize();
			Label = property;
			Repeated = repeated;
		}
	}
}
