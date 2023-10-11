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
            Array.Sort(array);
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] == 2)
                {
                    Console.WriteLine(array[i] - 1);
                    break;
                }
            }
        }
    }
}