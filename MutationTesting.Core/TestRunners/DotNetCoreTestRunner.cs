using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MutationTesting.Core.TestRunners
{
    /// <summary>
    /// This class executes automated tests in a .NET core project
    /// </summary>
    public class DotNetCoreTestRunner : ITestRunner
    {
        /// <summary>
        /// Runs test in a .NET core project by invoking dotnet test. The results then are saved
        /// in the executing assembly directory to be used when analyzing if a mutant survived or not
        /// </summary>
        /// <param name="testProject">A path to a .NET core test project</param>
        public void RunTests(string testProject)
        {
            var process = new Process()
            {
                StartInfo =
                {
                    FileName = "dotnet",
                    Arguments = $"test --logger \"trx;LogFileName={Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}/out.trx\"",
                    UseShellExecute = false,
                    WorkingDirectory = Path.GetDirectoryName(testProject)
                }
            };
            process.Start();
            process.WaitForExit();
        }
    }
}
