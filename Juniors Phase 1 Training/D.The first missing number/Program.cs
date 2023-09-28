/* // Happy Code
// Time Complexity O(N)
// Space Complexity O(N)
using System;
namespace TheMissingNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] Quries = Console.ReadLine().Split(' ');
            long N = Int64.Parse(Quries[0]);
            long Q = Int64.Parse(Quries[1]);
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string[] Arr = Console.ReadLine().Split(' ');
            for (int a = 0; a < N; a++)
            {
                if(!dic.ContainsKey(Arr[a])){
                dic.Add(Arr[a], 0);
                }
            }
            for (long i = -Q; i < Q; i++)
            {
                if (dic.ContainsKey(i.ToString()))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    return;
                }
            }


        }
    }
} */