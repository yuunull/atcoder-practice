using System;
using System.Linq;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] orders = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string[] sc = Console.ReadLine().Split(' ');
                orders[i] = new int[] { int.Parse(sc[0]), int.Parse(sc[1])};
            }

            // ABの問題が15分以内で解けるようになったらここにかえってくる
        }
    }
}
