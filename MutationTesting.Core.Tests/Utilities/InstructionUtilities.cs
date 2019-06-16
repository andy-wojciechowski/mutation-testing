using Mono.Cecil.Cil;
using System.Collections.Generic;
using System.Text;

namespace MutationTesting.Core.Tests.Utilities
{
    /// <summary>
    /// A collection of utilities related to IL instruction which may be helpful
    /// when writing unit tests for a mutator
    /// </summary>
    internal static class InstructionUtilities
    {
        /// <summary>
        /// Takes a list of IL instructions a builds a string containing those IL instructions
        /// </summary>
        /// <param name="instructions">a list of IL instructions</param>
        /// <returns>a string containing all IL instructions in the given list</returns>
        public static string ConvertInstructionsToString(IList<Instruction> instructions)
        {
            var sb = new StringBuilder();
            foreach (var instruction in instructions)
                sb.AppendLine(instruction.ToString());
            return sb.ToString();
        }
    }
}
