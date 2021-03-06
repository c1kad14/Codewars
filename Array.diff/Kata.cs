﻿using System.Linq;

namespace Array.diff
{
	// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
	//
	// It should remove all values from list a, which are present in list b.
	//
	// Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
	//
	// If a value is present in b, all of its occurrences must be removed from the other:
	//
	// Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
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

		//for big amounts of data array b can be made as a HashSet 
		public static int[] ArrayDiffBP(int[] a, int[] b) => a.Where(el => !b.Contains(el)).ToArray();
	}
}