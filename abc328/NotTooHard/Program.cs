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
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int result = s.Where(r => r <= x).Sum();
        Console.WriteLine(result);
    }
}