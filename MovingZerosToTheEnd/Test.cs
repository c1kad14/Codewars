using Xunit;

namespace MovingZerosToTheEnd
{
	public class Test
	{
		[Fact]
		public void Sample_Test()
		{
			Assert.Equal(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0},
				MovingZerosToTheEnd.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
		}
	}
}