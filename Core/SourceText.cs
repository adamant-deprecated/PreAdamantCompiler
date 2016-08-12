using System;
using System.Collections.Generic;
using System.IO;

namespace PreAdamant.Compiler.Core
{
	public class SourceText : ISourceText
	{
		public SourceText(string package, string name, string text)
		{
			Package = package;
			Name = name;
			Text = text;
			lines = new Lazy<LineInfo>(() => new LineInfo(this, ParseLineStarts()));
		}

		public SourceText(string package, string name, FileInfo fileInfo)
			: this(package, name, File.ReadAllText(fileInfo.FullName))
		{
		}

		public SourceText(string package, string name, TextReader reader)
			: this(package, name, reader.ReadToEnd())
		{
		}

		public string Package { get; }
		public string Name { get; }
		public string Text { get; }
		public int Length => Text.Length;
		private readonly Lazy<LineInfo> lines;
		public ITextLines Lines => lines.Value;

		public int CompareTo(ISourceText other)
		{
			var result = string.Compare(Package, other.Package, StringComparison.InvariantCultureIgnoreCase);
			return result != 0 ? result : string.Compare(Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
		}

		public TextPosition PositionOfStart(TextSpan textSpan)
		{
			var offset = textSpan.Start;
			var lineNumber = Lines.LineNumber(offset);
			// TODO count tabs as more than one column
			return new TextPosition(offset, lineNumber, offset - Lines[lineNumber].Start);
		}

		private int[] ParseLineStarts()
		{
			var text = Text;
			var length = text.Length;
			if(0 == length) return new[] { 0 };

			var lineStarts = new List<int> { 0 }; // there is always the first line

			// performance critical 
			for(var position = 0; position < length; position++)
			{
				var c = text[position];

				// Common case - ASCII & not a line break
				if(c > '\r' && c <= 127)
					continue;

				switch(c)
				{
					// Assumes that the only 2-char line break sequence is CR+LF
					case '\r':
						if(position + 1 < length && text[position + 1] == '\n')
							position++;
						break;
					case '\n':
					case '\u000B':
					case '\f':
					case '\u0085':
					case '\u2028':
					case '\u2029':
						break;
					default:
						continue;
				}

				// next line starts after the position
				if(position + 1 < length)
					lineStarts.Add(position + 1);
			}

			return lineStarts.ToArray();
		}

		private class LineInfo : ITextLines
		{
			private readonly SourceText source;
			private readonly int[] lineStarts;

			public LineInfo(SourceText source, int[] lineStarts)
			{
				this.source = source;
				this.lineStarts = lineStarts;
			}

			public int Count => lineStarts.Length;

			public TextLine this[int index]
			{
				get
				{
					var start = lineStarts[index];
					if(index == lineStarts.Length - 1) // last line
						return TextLine.FromTo(source, start, source.Length);

					var end = lineStarts[index + 1];
					return TextLine.FromTo(source, start, end);
				}
			}

			public int LineNumber(int offset)
			{
				var lineNumber = Array.BinarySearch(lineStarts, offset);
				if(lineNumber < 0) // if not found, round down to line start
					lineNumber = (~lineNumber) - 1;
				return lineNumber;
			}
		}
	}
}
