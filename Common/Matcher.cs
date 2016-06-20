using System;
using System.Diagnostics;

namespace PreAdamant.Compiler.Common
{
	public static class Matcher
	{
		[DebuggerHidden]
		public static Matcher<TValue> For<TValue>(TValue value)
			where TValue : class
		{
			return new Matcher<TValue>(value);
		}

		[DebuggerHidden]
		public static Matcher<TValue, TParam> For<TValue, TParam>(TValue value, TParam param)
			where TValue : class
		{
			return new Matcher<TValue, TParam>(value, param);
		}

		[DebuggerHidden]
		public static MatcherWithoutReturn<TValue> WithoutReturn<TValue>(TValue value)
			where TValue : class
		{
			return new MatcherWithoutReturn<TValue>(value, false);
		}

		// TODO create the rest of these
	}

	public struct Matcher<TValue>
			where TValue : class
	{
		private readonly TValue value;

		[DebuggerHidden]
		internal Matcher(TValue value)
		{
			this.value = value;
		}

		[DebuggerHidden]
		public MatcherWithoutReturn<TValue> With<T>(Action<T> @case)
			where T : class, TValue
		{
			return new MatcherWithoutReturn<TValue>(value, false).With(@case);
		}

		[DebuggerHidden]
		public MatcherWithReturn<TValue, TReturn> Returning<TReturn>()
		{
			return new MatcherWithReturn<TValue, TReturn>(value);
		}
	}

	public struct Matcher<TValue, TParam>
		where TValue : class
	{
		private readonly TValue value;
		private readonly TParam param;

		[DebuggerHidden]
		internal Matcher(TValue value, TParam param)
		{
			this.value = value;
			this.param = param;
		}

		[DebuggerHidden]
		public MatcherWithoutReturn<TValue, TParam> With<T>(Action<T, TParam> @case)
			where T : class, TValue
		{
			return new MatcherWithoutReturn<TValue, TParam>(value, param, false).With(@case);
		}

		[DebuggerHidden]
		public MatcherWithReturn<TValue, TParam, TReturn> Returning<TReturn>()
		{
			return new MatcherWithReturn<TValue, TParam, TReturn>(value, param);
		}
	}
}
