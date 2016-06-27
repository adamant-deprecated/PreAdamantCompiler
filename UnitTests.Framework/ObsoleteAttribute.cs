// Intentionally using non-project namespace to see the compiler behavior here
// ReSharper disable CheckNamespace
namespace System
{
	[AttributeUsage(AttributeTargets.All)]
	public class ObsoleteAttribute : Attribute
	{
		public string Message { get; } = "My own obsolete attribute";

		public ObsoleteAttribute(string message)
		{
		}
	}
}
