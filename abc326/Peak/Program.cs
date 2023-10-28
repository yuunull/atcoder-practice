using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        long n = long.Parse(nm[0]);
        long m = long.Parse(nm[1]);
        List<long> numbers = Console.ReadLine().Split().Select(long.Parse).OrderBy(r => r).ToList();

        int res = 0;
        int r = 0;
        for (int i = 0; i < n; i++)
        {
            while (r < n && numbers[r] < numbers[i] + m)
            {
                r++;
            }
            res = Math.Max(res, r - i);
        }

        Console.WriteLine(res);
    }
}