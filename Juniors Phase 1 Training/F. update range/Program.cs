// Happy Code
// Time Complexity O(1.5)
// Space Complexity O(N)
using System;
using System.Data.SqlTypes;
using System.Diagnostics;
namespace UpdateRanage
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Inputs  N Q
            string []Inputs=Console.ReadLine().Split(' ');
            long size=Int64.Parse(Inputs[0]);
            long process=Int64.Parse(Inputs[1]);
            // Declare array
            long []Arr=new long[size];
            // Array
            string []Arr_Str=Console.ReadLine().Split(' ');
            for(int y=0;y<size;y++){
                Arr[y]=Int64.Parse(Arr_Str[y]);
            }

            // Declare Temp Array

            long []Temp=new long[size+1];
            
            // Enter Process
            int a=0;
            while(++a<=process){
                string []Quires=Console.ReadLine().Split(' ');
                long L=Int64.Parse(Quires[0]);
                long R=Int64.Parse(Quires[1]);
                long add=Int64.Parse(Quires[2]);

                Temp[L-1]+=add;
                Temp[R]-=add;
            }

          // Prefix Sum temp Array
            int b=1;
            while(b<Temp.Length){
                Temp[b]+=Temp[b-1];
                b++;
            }

            // Sumation Of Temp Array and Orignail Array

            for(int i=0;i<Arr.Length;i++){
                long sum=Temp[i]+Arr[i];
                Console.Write($"{sum} ");
            }


        }
    }
}