namespace MutationTesting.Core.Tests.TestTypes
{
	public class IncrementAndDecrementSampleType
	{
		public void SampleMethod()
		{
			var i = 1;
			i++;
			++i;
		}

		public int MyProperty
		{
			get
			{
				var i = 1;
				i++;
				++i;
				return i;
			}
			set
			{
				var i = value;
				i++;
				++i;
			}
		}

		public void SampleMethod2()
		{
			var i = 1;
			i--;
			--i;
		}

		public int MyProperty2
		{
			get
			{
				var i = 1;
				i--;
				--i;
				return i;
			}
			set
			{
				var i = value;
				i--;
				--i;
			}
		}

		public void SampleMethod3()
		{
			var i = 1;
			i += 1;
			i -= 1;
		}

		public void SampleMethod4()
		{
			var i = 1;
			i = i + 1;
			i = i - 1;
		}

		public void SampleMethod5()
		{
			var i = 1;
			i += 2;
			i = i + 5;
			i -= 3;
			i = i - 10;
		}
	}
}
