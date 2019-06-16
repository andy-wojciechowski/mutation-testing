using System;
using Microsoft.Extensions.CommandLineUtils;
using MutationTesting.Core.TestRunners;

namespace MutationTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineApplication = new CommandLineApplication();
            commandLineApplication.Command("project", (target) =>
			{
				var projectArgument = target.Argument("project", "Enter the project to be mutation tested", multipleValues: false);
				target.OnExecute(() =>
				{
					var testRunner = new DotNetCoreTestRunner();
					testRunner.RunTests(projectArgument.Value);
					return 0;
				});
			});
			commandLineApplication.Execute(args);
        }
    }
}
