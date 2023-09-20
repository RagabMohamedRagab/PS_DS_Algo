// Happy Code
// Time Complexity O(N)
// Space Complexity O(N)
using System;
namespace SortArray
{
	public class Program
	{
		private static void Main(string[] args)
		{
			int size = Int32.Parse(Console.ReadLine());
			string[] arr = Console.ReadLine().Split(' ');
			int max = 0, min = 0;
			for (int a = 0; a < size; a++)
			{
				int index = Int32.Parse(arr[a]);
				if (max < index)
				{
					max = index;
				}
				else
				{
					min = index;
				}
			}
			int[] Frq = new int[max + 1];
			for (int b = 0; b < size; b++)
			{
				int index = Int32.Parse(arr[b]);
				Frq[index]++;
			}
			for (int i = 1; i <= max; i++)
			{
				for (int j = 1; j < Frq[i]; j++)
				{
					Console.Write($"{i} ");
				}
			}

		}
	}
}