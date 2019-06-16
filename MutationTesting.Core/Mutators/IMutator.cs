using Mono.Cecil.Cil;
using System.Collections.Generic;

namespace MutationTesting.Core.Mutators
{
    /// <summary>
    /// The base type for all mutators
    /// </summary>
    public interface IMutator
    {
        /// <summary>
        /// Applies a given mutator given a list of IL instructions
        /// </summary>
        /// <param name="instructions">A list of IL instructions to mutate</param>
        void MutateType(IList<Instruction> instructions);
    }
}
