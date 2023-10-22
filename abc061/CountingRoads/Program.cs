using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        int[] result = new int[n];
        for(int i = 0; i < m; i++)
        {
            string[] ab = Console.ReadLine().Split();
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            result[a - 1] += 1;
            result[b - 1] += 1;
        }

        for(int i = 0; i < result.Length; i++){
            Console.WriteLine(result[i]);
        }
    }
}