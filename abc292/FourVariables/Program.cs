using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] counts = new long[n];

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                int v = i * j;
                if (v >= n)
                {
                    break;
                }
                counts[v]++;
            }
        }

        long sum = 0;
        for (int i = 1; i < n; i++)
        {
            sum += counts[i] * counts[n - i];
        }

        Console.WriteLine(sum);
    }
}