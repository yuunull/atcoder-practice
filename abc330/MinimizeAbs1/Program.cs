using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nlr = Console.ReadLine().Split();
        int n = int.Parse(nlr[0]);
        long l = int.Parse(nlr[1]);
        long r = int.Parse(nlr[2]);
        long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        List<long> array = new List<long>();
        for(int i = 0; i < n; i++)
        {
            if(a[i] >= l && a[i] < r)
            {
                array.Add(a[i]);
                continue;
            }

            if(a[i] < l)
            {
                array.Add(l);
                continue;
            }

            if(a[i] >= r)
            {
                array.Add(r);
                continue;
            }
        }
        Console.WriteLine(string.Join(" ", array));
    }
}