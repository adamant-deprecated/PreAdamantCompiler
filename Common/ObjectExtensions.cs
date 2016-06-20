using System.Collections.Generic;
using System.Diagnostics;

namespace PreAdamant.Compiler.Common
{
	public static class ObjectExtensions
	{
		[DebuggerHidden]
		public static Matcher<TValue> Match<TValue>(this TValue value)
			where TValue : class
		{
			return new Matcher<TValue>(value);
		}

		[DebuggerHidden]
		public static Matcher<TValue, TParam> Match<TValue, TParam>(this TValue value, TParam param)
			where TValue : class
		{
			return new Matcher<TValue, TParam>(value, param);
		}

		[DebuggerHidden]
		public static IEnumerable<TValue> Yield<TValue>(this TValue value)
		{
			yield return value;
		}
	}
}
