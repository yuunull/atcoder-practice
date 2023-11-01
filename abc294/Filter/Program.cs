using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Console.WriteLine(string.Join(" ", a.Where(r => r % 2 == 0).Select(r => r).ToArray()));
    }
}