using System;
using PreAdamant.Compiler.Common;

namespace PreAdamant.Compiler.Core.Diagnostics
{
	public class Diagnostic : IComparable<Diagnostic>
	{
		public readonly DiagnosticLevel Level;
		public readonly CompilerPhase Phase;
		public readonly ISourceText Source;
		public readonly TextSpan SourceSpan;
		public readonly TextPosition Position;
		public readonly string Message;

		internal Diagnostic(DiagnosticLevel level, CompilerPhase phase, ISourceText source, TextSpan sourceSpan, string message)
		{
			Requires.EnumDefined(level, nameof(level));
			Requires.EnumDefined(phase, nameof(phase));
			Requires.NotNull(source, nameof(source));
			Requires.NotNullOrEmpty(message, nameof(message));

			Level = level;
			Phase = phase;
			Source = source;
			SourceSpan = sourceSpan;
			Position = Source.PositionOfStart(sourceSpan);
			Message = message;
		}

		public int CompareTo(Diagnostic other)
		{
			var compare = Source.CompareTo(other.Source);
			if(compare != 0) return compare;
			compare = SourceSpan.CompareTo(other.SourceSpan);
			if(compare != 0) return compare;
			compare = Level.CompareTo(other.Level);
			if(compare != 0) return compare;
			return string.Compare(Message, other.Message, StringComparison.InvariantCultureIgnoreCase);
		}
	}
}
