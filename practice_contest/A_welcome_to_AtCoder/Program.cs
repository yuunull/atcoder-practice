using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();

            var a = Convert.ToInt32(line1);
            var bArray = line2.Split(" ");
            var b1 = Convert.ToInt32(bArray[0]);
            var b2 = Convert.ToInt32(bArray[1]);


            Console.WriteLine($"{a + b1 + b2} {line3}");
        }
    }
}
