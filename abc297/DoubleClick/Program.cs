using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nd = Console.ReadLine().Split();
        int n = int.Parse(nd[0]);
        int d = int.Parse(nd[1]);
        int[] t = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();

        int result = -1;
        for(int i = 0; i < n - 1; i++)
        {
            if(t[i + 1] - t[i] <= d)
            {
                result = t[i + 1];
                break;
            }
        }
        Console.WriteLine(result);
    }
}