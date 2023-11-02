using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int result = 0;

        Array.Sort(a);

        for(int i = 0; i < n - 1; i++)
        {
            if(a[i] == a[i + 1])
            {
                result++;
                i++;
            }
        }

        Console.WriteLine(result);
    }
}