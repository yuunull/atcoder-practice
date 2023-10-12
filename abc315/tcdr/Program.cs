using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sArray = Console.ReadLine().ToCharArray();

            string result = string.Empty;
            for (int i = 0; i < sArray.Length; i++) 
            {
                if(sArray[i].ToString() == "a") {
                    continue;
                }

                if(sArray[i].ToString() == "i") {
                    continue;
                }

                if(sArray[i].ToString() == "u") {
                    continue;
                }

                if(sArray[i].ToString() == "e") {
                    continue;
                }

                if(sArray[i].ToString() == "o") {
                    continue;
                }
                result += sArray[i].ToString();
            }

            Console.WriteLine(result);
        }
    }
}
