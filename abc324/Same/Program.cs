using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            bool isSame = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[0] != array[i])
                {
                    isSame = false;
                    break;
                }
            }

            Console.WriteLine(isSame ? "Yes": "No");
        }
    }
}