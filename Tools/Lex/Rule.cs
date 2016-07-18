using System.Collections.Generic;
using System.Linq;
using static PreAdamant.Compiler.Tools.Lex.SpecParser;

namespace PreAdamant.Compiler.Tools.Lex
{
	public class Rule
	{
		public string Name { get; }
		public string Base { get; }
		public PatternContext Pattern { get; }
		public IReadOnlyList<CommandContext> Commands { get; }

		public Rule(string name, string @base, PatternContext pattern, IEnumerable<CommandContext> commands)
		{
			Name = name;
			Base = @base;
			Pattern = pattern;
			Commands = commands.ToList();
		}

		/// <summary>
		/// Whether this rule will correspond to an actual token type output by the lexer
		/// </summary>
		public bool IsTokenType => !Commands.OfType<TypeCommandContext>().Any();
	}
}
