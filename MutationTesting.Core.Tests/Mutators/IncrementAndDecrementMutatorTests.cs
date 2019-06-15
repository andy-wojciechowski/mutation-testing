using Mono.Cecil.Cil;
using MutationTesting.Core.Mutators;
using MutationTesting.Core.Tests.Infrastructure;
using Xunit;

namespace MutationTesting.Core.Tests.Mutators
{
	public class IncrementAndDecrementMutatorTests : MutatorUnitTest
	{
		public IncrementAndDecrementMutatorTests() : base("IncrementAndDecrementSampleType") { }

		[Fact]
		public void Test_IncrementInMethod_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.TypeDefinition);

			//Assert
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[5].OpCode);
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[9].OpCode);
		}

		[Fact]
		public void Test_IncrementInProperty_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.TypeDefinition);

			//Assert
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[17].OpCode);
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[21].OpCode);
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[33].OpCode);
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[37].OpCode);
		}

		[Fact]
		public void Test_DecrementInMethod_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.TypeDefinition);

			//Assert
			Assert.Equal(OpCodes.Add, this.InitialInstructions[45].OpCode);
			Assert.Equal(OpCodes.Add, this.InitialInstructions[49].OpCode);
		}

		[Fact]
		public void Test_DecrementInProperty_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.TypeDefinition);

			//Assert
			Assert.Equal(OpCodes.Add, this.InitialInstructions[57].OpCode);
			Assert.Equal(OpCodes.Add, this.InitialInstructions[61].OpCode);
			Assert.Equal(OpCodes.Add, this.InitialInstructions[73].OpCode);
			Assert.Equal(OpCodes.Add, this.InitialInstructions[77].OpCode);
		}

		[Fact]
		public void Test_PlusEqualsAndMinusEqualsOperators_WithOne_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.TypeDefinition);

			//Assert
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[85].OpCode);
			Assert.Equal(OpCodes.Add, this.InitialInstructions[89].OpCode);
		}

		[Fact]
		public void Test_AdditionAndSubtractionOperators_WithOne_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.TypeDefinition);

			//Assert
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[97].OpCode);
			Assert.Equal(OpCodes.Add, this.InitialInstructions[101].OpCode);
		}

		[Fact]
		public void Test_AddAndSub_NotAddingOrSubtractingOne_DoesntChangeOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.TypeDefinition);

			//Assert
			Assert.Equal(OpCodes.Add, this.InitialInstructions[109].OpCode);
			Assert.Equal(OpCodes.Add, this.InitialInstructions[113].OpCode);
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[117].OpCode);
			Assert.Equal(OpCodes.Sub, this.InitialInstructions[121].OpCode);
		}
	}
}
