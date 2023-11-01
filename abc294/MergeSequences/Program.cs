using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> c = a.Concat(b).OrderBy(r => r).ToList();

        int[] aResult = new int[n];
        for(int i = 0; i < n; i++)
        {
            var index = c.BinarySearch(a[i]);
            aResult[i] = index + 1;
        }

        Console.WriteLine(string.Join(" ", aResult));

        int[] bResult = new int[m];
        for(int i = 0; i < m; i++)
        {
            var index = c.BinarySearch(b[i]);
            bResult[i] = index + 1;
        }

        Console.WriteLine(string.Join(" ", bResult));
    }
}