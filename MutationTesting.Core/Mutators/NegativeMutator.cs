using System;
using System.Collections.Generic;
using System.Text;
using Mono.Cecil.Cil;

namespace MutationTesting.Core.Mutators
{
    /// <summary>
    /// This mutator will convert all positve numbers to be negative and all negative numbers to be positive
    /// </summary>
    public class NegativeMutator : IMutator
    {
        public void MutateType(IList<Instruction> instructions)
        {
            throw new NotImplementedException();
        }
    }
}
