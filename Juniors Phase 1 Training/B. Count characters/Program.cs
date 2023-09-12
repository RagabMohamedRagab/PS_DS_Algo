using System;

namespace Countcharacters
{
    public class Program
    {
        static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
        private static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = SortString(str);
          var dict=new Dictionary<char,int>();
          foreach (var item in str)
          {
            if(dict.ContainsKey(item)){
                ++dict[item];
            }else{
                dict.Add(item,1);
            }
          }
          foreach (var item in dict)
          {
            Console.WriteLine($"{item.Key} {item.Value}");
          }
        }
    }
}
