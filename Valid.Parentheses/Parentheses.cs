using System.Linq;

namespace Valid.Parentheses
{
	public class Parentheses
	{
		public static bool ValidParentheses(string input)
		{
			var parentheses = 0;

			foreach (var el in input.ToCharArray())
			{
				if (el == '(')
				{
					parentheses++;
				}

				if (el == ')')
				{
					parentheses--;

					if (parentheses < 0)
					{
						break;
					}
				}
			}

			return parentheses == 0;
		}
	}
}