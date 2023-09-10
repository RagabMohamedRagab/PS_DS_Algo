// Data Structures and Algorithms 10-9-2023
// Happy Code
// Time Complexity O(N)
// Space Complexity (3N)
using System;
namespace CountNumbers
{
    public class Program{
        private static void Main(string []args){
            string[] inputs=Console.ReadLine().Split(' ');
            int size=Int32.Parse(inputs[0]);
            int quires=Int32.Parse(inputs[1]); 
           
            int []Freq=new int[size+1];
            int a=1,i=0;
            while(a<=quires){
                 string []Q=Console.ReadLine().Split(' ');
                int z=Int32.Parse(Q[0]);
                int x=Int32.Parse(Q[1]);
                if(z==1){
                    ++Freq[x];
                }else{
                   Console.WriteLine(Freq[x]);
                } 
                a++;
            }
            
        }
    }
}