using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] charArray = Console.ReadLine().ToCharArray();

            int abcIndex = -1;
            for(int i = 0; i < n - 2; i++) {
                if(charArray[i].ToString() == "A") {
                    if(charArray[i + 1].ToString() == "B") {
                        if(charArray[i + 2].ToString() == "C") {
                            abcIndex = i + 1;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(abcIndex);
        }
    }
}