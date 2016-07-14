using System;
using ManyConsole;

namespace PreAdamant.Compiler.Tools.Cmd
{
	public class Program
	{
		public static int Main(string[] args)
		{
			var commands = ConsoleCommandDispatcher.FindCommandsInSameAssemblyAs(typeof(Program));
			return ConsoleCommandDispatcher.DispatchCommand(commands, args, Console.Out);
		}
	}
}
