using System.Linq;

namespace Valid.Parentheses
{
	public class Parentheses
	{
		public static bool ValidParentheses(string input)
		{
			var inputLength = input.Length;

			if (input.Count(i => i == '(' || i == ')') % 2 != 0 || inputLength < 0 || inputLength > 100 ||
			    input.StartsWith(')') || input.EndsWith('(') ||
			    input.Count(i => i == '(') != input.Count(i => i == ')'))
			{
				return false;
			}

			return true;
		}
	}
}