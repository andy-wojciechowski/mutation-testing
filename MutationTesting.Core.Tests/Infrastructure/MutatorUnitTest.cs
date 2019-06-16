using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MutationTesting.Core.Tests.Infrastructure
{
	public abstract class MutatorUnitTest
	{
		protected IList<Instruction> Instructions { get; set; }

		public MutatorUnitTest(string testType)
		{
			var assemblyDefinition = AssemblyDefinition.ReadAssembly(Assembly.GetExecutingAssembly().Location);
			var typeDefinition = assemblyDefinition.MainModule.Types.Single(x => x.Name.Equals(testType));
			this.Instructions = typeDefinition.Methods.SelectMany(x => x.Body.Instructions).ToList();
		}
	}
}
