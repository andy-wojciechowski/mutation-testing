namespace MutationTesting.Core.TestRunners
{
    /// <summary>
    /// The base type for all test runners. Which will run .NET automated tests given a test project
    /// </summary>
    public interface ITestRunner
    {
        /// <summary>
        /// This method will run the automated tests given a test project
        /// </summary>
        /// <param name="testProject">A .NET test project</param>
        void RunTests(string testProject);
    }
}
