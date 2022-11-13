using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputValue = Console.ReadLine();
            var result = -1;
            for (var i = 0; i < inputValue.Length; i++)
            {
                if (inputValue.Substring(i,1).Equals("a")) {
                    result = i + 1;
                };
            }

            Console.WriteLine(result);
        }
    }
}