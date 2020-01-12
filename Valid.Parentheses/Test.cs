using Xunit;

namespace Valid.Parentheses
{
	public class Test
	{
		[Fact]
		public void SampleTest1()
		{
			Assert.Equal(true, Parentheses.ValidParentheses("()"));
		}

		[Fact]
		public void SampleTest2()
		{
			Assert.Equal(false, Parentheses.ValidParentheses(")(((("));
		}
	}
}