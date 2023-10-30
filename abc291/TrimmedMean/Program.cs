using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(x);

        int[] newArray = x.Skip(n).Take(x.Length - 2 * n).ToArray();
        
        decimal sum = newArray.Sum();
        decimal newN = newArray.Count();
        Console.WriteLine(sum / newN);
    }
}