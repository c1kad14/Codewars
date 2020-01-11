using Xunit;

namespace Array.diff
{
	public class Test
	{
		[Fact]
		public void SampleTest()
		{
			Assert.Equal(new[] {2}, Kata.ArrayDiff(new[] {1, 2}, new[] {1}));
			Assert.Equal(new[] {2, 2}, Kata.ArrayDiff(new[] {1, 2, 2}, new[] {1}));
			Assert.Equal(new[] {1}, Kata.ArrayDiff(new[] {1, 2, 2}, new[] {2}));
			Assert.Equal(new[] {1, 2, 2}, Kata.ArrayDiff(new[] {1, 2, 2}, new int[] { }));
			Assert.Equal(new int[] { }, Kata.ArrayDiff(new int[] { }, new[] {1, 2}));
		}
	}
}