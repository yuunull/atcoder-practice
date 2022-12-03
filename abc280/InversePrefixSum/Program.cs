using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            string[] sArray = Console.ReadLine().Split(' ');

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                if(i == 0) {
                    result[i] = Convert.ToInt32(sArray[i]);
                }
                else
                {
                    result[i] = Convert.ToInt32(sArray[i]) - Convert.ToInt32(sArray[i - 1]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
