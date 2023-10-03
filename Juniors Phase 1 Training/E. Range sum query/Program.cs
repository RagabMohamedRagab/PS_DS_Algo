using System;
namespace RangeSumQuery
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] Inputs = Console.ReadLine().Split(' ');
            long N = Int64.Parse(Inputs[0]);  // N
            long Q = Int64.Parse(Inputs[1]);  // Q

            long[] A = new long[N];  // Array 

            string[] Arr = Console.ReadLine().Split(' ');

            for (long i = 0; i < N; i++)
            {
                A[i] = Int64.Parse(Arr[i]);
            }

            long a = 1;
            while (a < N)
            {
                A[a] = A[a]+A[a-1];
                a++;
            }
           // Enter Quries base on L R 

           long b=1;
           while(b<=Q){
               string []Quires=Console.ReadLine().Split(' ');
               long L=Int64.Parse(Quires[0])-1;
               long R=Int64.Parse(Quires[1])-1;

               if(L==0){
                   Console.WriteLine($"{A[R]}");
               }else{
                   long result=A[R]-A[L-1];
                   Console.WriteLine(result);
               }
            b++;
           }
        }
    }
}