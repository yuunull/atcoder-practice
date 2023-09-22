using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sArray = Console.ReadLine().Split(' ');

            int a = int.Parse(sArray[0]);
            int b = int.Parse(sArray[1]);

            var left = Math.Pow(a, b);
            var right = Math.Pow(b, a);

            Console.WriteLine(left + right);
        }
    }
}
