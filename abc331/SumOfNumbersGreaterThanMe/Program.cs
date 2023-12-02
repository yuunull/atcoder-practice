using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;
using System.Numerics;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
        List<long> sorted = a.OrderBy(r => r).ToList();
        long[] sumArray = new long[n + 1];
        for(int i = 1; i < n + 1; i++)
        {
            sumArray[i] = sumArray[i - 1] + sorted[i - 1];
        }

        List<long> result = new List<long>();
        long max = a.Max();
        for(int i = 0; i < n; i++)
        {
            if(max <= a[i])
            {
                result.Add(0);
            }
            else
            {
                var index = sorted.BinarySearch(a[i]);
                if (index < 0)
                {
                    index = ~index;
                }
                while (index < sorted.Count && sorted[index] == a[i])
                {
                    index++;
                }
                
                result.Add(sumArray[n] - sumArray[index]);
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}