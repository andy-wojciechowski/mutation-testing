using System;
using System.Collections.Generic;
using System.Text;
using Mono.Cecil.Cil;

namespace MutationTesting.Core.Mutators
{
	/// <summary>
	/// This mutator will take a conditional operator and replace it with the negated version of the operator
	/// </summary>
	public class NegateConditionalMutator : IMutator
	{
		public void MutateType(IList<Instruction> instructions)
		{
			throw new NotImplementedException();
		}
	}
}
