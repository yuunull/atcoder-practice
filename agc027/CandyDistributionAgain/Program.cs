using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nx = Console.ReadLine().Split();
            int n = int.Parse(nx[0]);
            int x = int.Parse(nx[1]);
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(array);

            int cnt = 0;
            for (int j = 0; j < array.Length; j++)
            {
                x -= array[j];
                if (x >= 0)
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}