using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nl = Console.ReadLine().Split();
        int n = int.Parse(nl[0]);
        int l = int.Parse(nl[1]);
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        int result = 0;
        for(int i = 0; i < n; i++)
        {
            if(a[i] >= l)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}