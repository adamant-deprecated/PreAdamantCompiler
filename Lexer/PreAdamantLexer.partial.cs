using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using PreAdamant.Compiler.Core;
using PreAdamant.Compiler.Lexer.Antlr;
using PreAdamant.Compiler.Lexer.Preprocessor;

namespace PreAdamant.Compiler.Lexer
{
	public partial class PreAdamantLexer : IEnumerable<Token>
	{
		public readonly SourceText Source;

		public PreAdamantLexer(SourceText source)
		{
			Source = source;
		}

		public IEnumerator<Token> GetEnumerator()
		{
			using(var reader = new StringReader(Source.Text))
			{
				var antlrLexer = new PreAdamantLexer_Antlr(new AntlrInputStream(reader))
				{
					CurrentMode = StartMode
				};
				for(;;)
				{
					antlrLexer.NextToken();
					if(antlrLexer.HitEOF) yield break;
					yield return CreateToken(Source, antlrLexer.Token.StopIndex, antlrLexer.Token.StopIndex, antlrLexer.Type, (Channel)(antlrLexer.Channel - 1), antlrLexer.Text);
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public static IReadOnlyDictionary<int, string> ChannelNames { get; } = new Dictionary<int, string>()
		{
			{ 0, "Default" }, { 2, "DocComments" }
		};
		public static readonly Encoding Encoding = new UTF8Encoding(false, true);

		private readonly PreprocessorState preprocessorState = new PreprocessorState();
		private PreprocessorVisitor preprocessorVisitor;

		//public PreAdamantLexer(string fileName)
		//	: this(new AntlrFileStream(fileName, Encoding))
		//{
		//}

		public PreprocessorState PreprocessorState => preprocessorState;

		//private void Preprocess()
		//{
		//	if(TokenStartColumn != 0)
		//		NotifyErrorListeners("Preprocessor directives must be the first non-whitespace character on the line");

		//	var directive = Text;
		//	var stream = new AntlrInputStream(directive);
		//	var lexer = new PreprocessorLineLexer(stream);
		//	var tokens = new CommonTokenStream(lexer);
		//	var parser = new PreprocessorLineParser(tokens) { BuildParseTree = true };
		//	var tree = parser.preprocessorLine();
		//	if(preprocessorVisitor == null) preprocessorVisitor = new PreprocessorVisitor(preprocessorState); //annoyingly can't use constructor
		//	tree.Accept(preprocessorVisitor);
		//	CurrentMode = preprocessorState.InSkippedSection ? PREPROCESSOR_SKIP : DefaultMode;
		//}

		//public void NotifyErrorListeners(string msg)
		//{
		//	NotifyErrorListeners(msg, null);
		//}

		//public virtual void NotifyErrorListeners(string msg, RecognitionException e)
		//{
		//	int line = TokenStartLine;
		//	int charPositionInLine = TokenStartColumn;
		//	var antlrErrorListener = ErrorListenerDispatch;
		//	antlrErrorListener.SyntaxError(this, Type, line, charPositionInLine, msg, e);
		//}
	}

	public class KeywordToken : Token
	{
		protected KeywordToken(SourceText source, int startIndex, int stopIndex, int type, PreAdamantLexer.Channel channel, string text)
			: base(source, startIndex, stopIndex, type, channel, text)
		{
		}
	}
}
