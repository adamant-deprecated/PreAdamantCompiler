using PreAdamant.Compiler.Emit.Cpp.Properties;

namespace PreAdamant.Compiler.Emit.Cpp
{
	public static class CppRuntime
	{
		public static string Source => Resources.Runtime;

		public static string FileName => "compiler_runtime.cpp";
	}
}
