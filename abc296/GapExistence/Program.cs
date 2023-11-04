using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nx = Console.ReadLine().Split();
        int n = int.Parse(nx[0]);
        int x = int.Parse(nx[1]);
        int[] a = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();

        List<int> list = a.Select(r => r + x).ToList();
        var result = list.Intersect(a).ToList();
        if (result.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }
}