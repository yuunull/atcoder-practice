using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arg1Array = Console.ReadLine().Split(' ');
            string[] arg2Array = Console.ReadLine().Split(' ');

            string n = arg1Array[0];
            int x = int.Parse(arg1Array[1]);
            int[] intArray = arg2Array.Where(str => int.TryParse(str, out _)).Select(int.Parse).ToArray();

            int a = intArray.Sum() - intArray.Max();
            int b = intArray.Sum() - intArray.Min() - intArray.Max();
            int c = intArray.Sum() - intArray.Min();

            int result;
            if (x <= a)
            {
                Console.WriteLine(0);
            }
            else if (x > c)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(x - b);
            }
        }
    }
}