using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> result = new List<int>();
        for(int i = 0; i < n - 1; i++)
        {
            if(a[i] < a[i + 1])
            {
                int count = Math.Abs(a[i + 1] - a[i]);
                for(int j = 0; j < count; j++)
                {
                    result.Add(a[i] + j);
                }
            }
            else if (a[i] > a[i + 1])
            {
                int count = Math.Abs(a[i + 1] - a[i]);
                for(int j = 0; j < count; j++)
                {
                    result.Add(a[i] - j);
                }
            }
            else
            {
                result.Add(a[i] + 1);
            }
        }
        result.Add(a[a.Count() - 1]);
        Console.WriteLine(string.Join(" ", result));
    }
}