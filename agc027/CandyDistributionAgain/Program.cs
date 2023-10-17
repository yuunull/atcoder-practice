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

            int sum = 0;
            int cnt = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (sum + array[j] <= x)
                {
                    sum += array[j];
                    cnt++;
                }
                else
                {
                    break;
                }
            }

            if (cnt == n && sum < x)
            {
                cnt--;
            }

            Console.WriteLine(cnt);
        }
    }
}