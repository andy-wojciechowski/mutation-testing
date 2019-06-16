using System;
using System.Collections.Generic;
using System.Text;
using Mono.Cecil.Cil;

namespace MutationTesting.Core.Mutators
{
    /// <summary>
    /// This mutator will change a binary math operator will a different operator
    /// </summary>
    public class MathOperatorMutator : IMutator
    {
        public void MutateType(IList<Instruction> instructions)
        {
            throw new NotImplementedException();
        }
    }
}
