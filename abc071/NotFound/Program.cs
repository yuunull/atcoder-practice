using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            char[] sortedDistinctChars = s.Distinct().OrderBy(c => c).ToArray();
            string all = "abcdefghijklmnopqrstuvwxyz";

            if(new string(sortedDistinctChars) == all)
            {
                Console.WriteLine("None");
            }
            else
            {
                string result = "";
                int index = 0;
                char[] allArray = all.ToCharArray();
                foreach(char val in allArray)
                {
                    if (index >= sortedDistinctChars.Length || val != sortedDistinctChars[index])
                    {
                        result = val.ToString();
                        break;
                    }
                    index++;
                }

                Console.WriteLine(result);
            }
        }
    }
}