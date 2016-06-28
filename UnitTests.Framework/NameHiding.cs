namespace PreAdamant.Compiler.UnitTests.Framework
{
	public class NameHiding
	{
		public void MaybeAMethod()
		{
		}

		/// <summary>
		/// Test whether a a method reference will be found even though it is hidden by a local variable that is not a delegate
		/// </summary>
		public void Test()
		{
			int MaybeAMethod = 8;
			//MaybeAMethod(); // Does not compile becuase MaybeAMethod refers to the variable
		}
	}
}
