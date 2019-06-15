using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MutationTesting.Core.Tests.Infrastructure
{
	public abstract class MutatorUnitTest
	{
		protected TypeDefinition TypeDefinition { get; set; }
		protected IList<Instruction> InitialInstructions { get; set; }

		public MutatorUnitTest(string testType)
		{
			var assemblyDefinition = AssemblyDefinition.ReadAssembly(Assembly.GetExecutingAssembly().Location);
			this.TypeDefinition = assemblyDefinition.MainModule.Types.Single(x => x.Name.Equals(testType));
			this.InitialInstructions = this.TypeDefinition.Methods.SelectMany(x => x.Body.Instructions).ToList();
		}
	}
}
