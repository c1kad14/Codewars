using System.Linq;

namespace Valid.Parentheses
{
	public class Parentheses
	{
		public static bool ValidParentheses(string input)
		{
			var inputLength = input.Length;
			var invalid = false;

			if (input.Count(i => i == '(' || i == ')') % 2 != 0 || inputLength < 0 || inputLength > 100 ||
			    input.StartsWith(')') || input.EndsWith('(') ||
			    input.Count(i => i == '(') != input.Count(i => i == ')'))
			{
				return false;
			}

			var opened = 0;
			var closed = 0;

			foreach (var el in input.ToCharArray())
			{
				if (el == '(')
				{
					opened++;
				}

				if (el == ')')
				{
					closed++;
				}

				if (closed > opened)
				{
					invalid = true;
					break;
				}
			}

			return !invalid;
		}
	}
}