using System;
using Microsoft.Extensions.CommandLineUtils;

namespace MutationTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineApplication = new CommandLineApplication();
            CommandArgument project = null;
            commandLineApplication.Command("project", (target) => project = target.Argument("project", "Enter the project to be mutation tested", multipleValues: false));
            commandLineApplication.OnExecute(() =>
            {
                return 0;
            });
        }
    }
}
