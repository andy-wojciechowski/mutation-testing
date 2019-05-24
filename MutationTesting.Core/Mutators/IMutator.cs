using Mono.Cecil;

namespace MutationTesting.Core.Mutators
{
    public interface IMutator
    {
        void MutateType(TypeDefinition typeDefinition);
    }
}
