using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] av = Console.ReadLine().Split();
            string[] bw = Console.ReadLine().Split();
            int t = int.Parse(Console.ReadLine());
            int a = int.Parse(av[0]);
            int v = int.Parse(av[1]);
            int b = int.Parse(bw[0]);
            int w = int.Parse(bw[1]);

            bool isCatch = false;
            for (int i = 0; i < t; i++)
            {
                a += v;
                b += w;
                if (a >= b)
                {
                    isCatch = true;
                    break;
                }
            }

            Console.WriteLine(isCatch ? "YES" : "NO");
        }
    }
}