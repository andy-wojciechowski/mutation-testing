using System.Diagnostics;
using System.IO;

namespace MutationTesting.Core.TestRunners
{
	public class DotNetCoreTestRunner : ITestRunner
	{
		public void RunTests(string testAseembly)
		{
			var process = new Process()
			{
				StartInfo =
				{
					FileName = "dotnet",
					Arguments = "test",
					UseShellExecute = false,
					WorkingDirectory = Path.GetDirectoryName(testAseembly)
				}
			};
			process.Start();
			//TODO: Figure out how to get the results
		}
	}
}
