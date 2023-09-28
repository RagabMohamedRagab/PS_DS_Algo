using System;
namespace Problem
{
   class Program
   {
      private static void Main(string[] args)
      {
         string[] Quries = Console.ReadLine().Split(' ');
         int N = Int32.Parse(Quries[0]);
         int M = Int32.Parse(Quries[1]);
         string[] Arr = Console.ReadLine().Split(' ');
         int[] temp = new int[N];
         int[] Frq = new int[(M * 2) + 1];
         for (int a = 0; a < N; a++)
         {
            temp[a] = Int32.Parse(Arr[a]);
            Frq[temp[a] + M]++;
         }
         for (int i = -M; i < M; i++)
         {
            if (Frq[i] == 0)
            {
               System.Console.WriteLine(i);
               break;
            }
         }

      }
   }
}