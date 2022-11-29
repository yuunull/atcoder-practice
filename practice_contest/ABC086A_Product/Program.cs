using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var a = Convert.ToInt32(input[0]);
            var b = Convert.ToInt32(input[1]);

            if(IsEven(a, b))
            {
                Console.WriteLine("Even");
            } 
            else 
            {
                Console.WriteLine("Odd");
            }
        }

        private static bool IsEven(int a, int b) {
            return a * b % 2 == 0;
        }
    }
}
