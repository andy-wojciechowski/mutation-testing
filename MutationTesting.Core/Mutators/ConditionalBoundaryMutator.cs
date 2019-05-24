using System;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace MutationTesting.Core.Mutators
{
    public class ConditionalBoundaryMutator : IMutator
    {
        public void MutateType(TypeDefinition typeDefinition)
        {
            foreach(var methodDefinition in typeDefinition.Methods)
            {
                foreach(var instruction in methodDefinition.Body.Instructions)
                {
                    if (instruction.OpCode == OpCodes.Blt) instruction.OpCode = OpCodes.Ble;
                }
            }
        }
    }
}
