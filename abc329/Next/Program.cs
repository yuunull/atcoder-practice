using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int max = a.Max();
        int result = a.Where(r => r != max).Max();
        Console.WriteLine(result);
   }
}