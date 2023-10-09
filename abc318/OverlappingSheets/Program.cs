using System;
using System.Linq;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] g = new bool[100, 100];
            int n = int.Parse(Console.ReadLine());

            for (int k = 0; k < n; k++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);
                int d = int.Parse(input[3]);

                for (int i = a; i < b; i++)
                {
                    for (int j = c; j < d; j++)
                    {
                        g[i, j] = true;
                    }
                }
            }

            int trueCount = g.Cast<bool>().Count(b => b == true);

            Console.WriteLine(trueCount);
        }
    }
}
