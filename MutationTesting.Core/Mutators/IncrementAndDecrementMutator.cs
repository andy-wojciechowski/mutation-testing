﻿using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Linq;

namespace MutationTesting.Core.Mutators
{
	/// <summary>
	/// A type of mutator which will change all increment operators to be decrement operators
	/// and change all decrement operators to increment operators. Note this will also mutate
	/// uses of += 1, -= 1, + 1, and - 1 since those generate the same instructions
	/// </summary>
	public class IncrementAndDecrementMutator : IMutator
	{
		private readonly byte ONE_OP2_VALUE = 23;

		public void MutateType(TypeDefinition typeDefinition)
		{
			var methodInstrustions = typeDefinition.Methods.SelectMany(x => x.Body.Instructions).ToList();
			var addInstructions = methodInstrustions.Where(x => x.OpCode == OpCodes.Add && x.Previous.OpCode.Op2 == ONE_OP2_VALUE).ToList();
			var subInstructions = methodInstrustions.Where(x => x.OpCode == OpCodes.Sub && x.Previous.OpCode.Op2 == ONE_OP2_VALUE).ToList();
			addInstructions.ForEach(x => x.OpCode = OpCodes.Sub);
			subInstructions.ForEach(x => x.OpCode = OpCodes.Add);
		}
	}
}
