using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using NUnit.Framework;

namespace PreAdamant.Compiler.Tests
{
	public class TestCaseConfig
	{
		// These come from the name of the test file
		public string TestName;
		public string FileName;

		// These settings are read from the json header
		public string Description;
		public int Result;
		public string[] Dependencies;

		// These settings are read from the output section after a line of "---"
		public bool VerifyConsoleOutput;
		public string ExpectedConsoleOutput;

		public static TestCaseConfig Read(TextReader reader)
		{
			var line = reader.ReadLine().Trim();
			Assert.AreEqual("/*---", line);
			var lines = new List<string>();
			string rawLine;
			while((line = (rawLine = reader.ReadLine()).Trim()) != "---" && line != "*/")
				lines.Add(rawLine);

			var vson = string.Join("\r\n", lines);
			var config = JsonConvert.DeserializeObject<TestCaseConfig>(vson);

			if(line == "---")
			{
				// read in expected console output
				lines.Clear();
				while((rawLine = reader.ReadLine()).Trim() != "*/")
					lines.Add(rawLine);

				config.VerifyConsoleOutput = true;
				// an extra blank line is always output
				config.ExpectedConsoleOutput = string.Concat(lines.Select(l => l + Environment.NewLine)) + Environment.NewLine;
			}

			if(config.Dependencies == null)
				config.Dependencies = new string[0];

			return config;
		}
	}
}
