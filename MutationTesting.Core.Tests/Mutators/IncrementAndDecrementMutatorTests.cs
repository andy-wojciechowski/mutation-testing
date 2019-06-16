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
			mutator.MutateType(this.Instructions);

			//Assert
			Assert.Equal(OpCodes.Sub, this.Instructions[5].OpCode);
			Assert.Equal(OpCodes.Sub, this.Instructions[9].OpCode);
		}

		[Fact]
		public void Test_IncrementInProperty_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.Instructions);

			//Assert
			Assert.Equal(OpCodes.Sub, this.Instructions[17].OpCode);
			Assert.Equal(OpCodes.Sub, this.Instructions[21].OpCode);
			Assert.Equal(OpCodes.Sub, this.Instructions[33].OpCode);
			Assert.Equal(OpCodes.Sub, this.Instructions[37].OpCode);
		}

		[Fact]
		public void Test_DecrementInMethod_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.Instructions);

			//Assert
			Assert.Equal(OpCodes.Add, this.Instructions[45].OpCode);
			Assert.Equal(OpCodes.Add, this.Instructions[49].OpCode);
		}

		[Fact]
		public void Test_DecrementInProperty_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.Instructions);

			//Assert
			Assert.Equal(OpCodes.Add, this.Instructions[57].OpCode);
			Assert.Equal(OpCodes.Add, this.Instructions[61].OpCode);
			Assert.Equal(OpCodes.Add, this.Instructions[73].OpCode);
			Assert.Equal(OpCodes.Add, this.Instructions[77].OpCode);
		}

		[Fact]
		public void Test_PlusEqualsAndMinusEqualsOperators_WithOne_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.Instructions);

			//Assert
			Assert.Equal(OpCodes.Sub, this.Instructions[85].OpCode);
			Assert.Equal(OpCodes.Add, this.Instructions[89].OpCode);
		}

		[Fact]
		public void Test_AdditionAndSubtractionOperators_WithOne_ChangesOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.Instructions);

			//Assert
			Assert.Equal(OpCodes.Sub, this.Instructions[97].OpCode);
			Assert.Equal(OpCodes.Add, this.Instructions[101].OpCode);
		}

		[Fact]
		public void Test_AddAndSub_NotAddingOrSubtractingOne_DoesntChangeOpCode()
		{
			//Arrange
			var mutator = new IncrementAndDecrementMutator();

			//Act
			mutator.MutateType(this.Instructions);

			//Assert
			Assert.Equal(OpCodes.Add, this.Instructions[109].OpCode);
			Assert.Equal(OpCodes.Add, this.Instructions[113].OpCode);
			Assert.Equal(OpCodes.Sub, this.Instructions[117].OpCode);
			Assert.Equal(OpCodes.Sub, this.Instructions[121].OpCode);
		}
	}
}
