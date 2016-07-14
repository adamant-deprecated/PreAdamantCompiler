namespace PreAdamant.Compiler.Tools.Lex
{
	public class Command
	{
		public CommandType Type { get; }
		public string Argument { get; }

		public Command(CommandType type, string argument)
		{
			Type = type;
			Argument = argument;
		}
	}
}
