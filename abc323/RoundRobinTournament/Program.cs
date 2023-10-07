using System;
using System.Linq;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] sArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                sArray[i] = Console.ReadLine();
            }

            int[][] orders = new int[n][];
            for (int i = 1; i < n + 1; i++)
            {
                orders[i - 1] = new int[] { i, sArray[i - 1].Count(c => c == 'o') };
            }

            int[][] sortedArray = orders.OrderByDescending(subArray => subArray[1]).ToArray();
            string result = string.Empty;
            foreach (var subArray in sortedArray)
            {
                result += subArray[0] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
