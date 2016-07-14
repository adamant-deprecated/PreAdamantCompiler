namespace PreAdamant.Compiler.Tools.Lex
{
	public enum CommandType
	{
		SetMode = 1,
		PushMode,
		PopMode,
		Skip,
		More,
		Type,
		Channel,
		Error,
		Capture,
		Decode,
		Text,
		Action,
	}
}