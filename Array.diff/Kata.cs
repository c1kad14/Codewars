using System.Linq;

namespace Array.diff
{
	public class Kata
	{
		public static int[] ArrayDiff(int[] a, int[] b)
		{
			var result = a.ToList();

			foreach (var el in b)
			{
				result.RemoveAll(i => i == el);
			}

			return result.ToArray();
		}
	}
}