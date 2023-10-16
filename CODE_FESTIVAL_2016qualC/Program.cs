using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            bool isCF = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == "C")
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j].ToString() == "F")
                        {
                            isCF = true;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(isCF ? "Yes" : "No");
        }
    }
}