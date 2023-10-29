using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        string[] a = Console.ReadLine().Split();
        string[] b = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        int result = 0;
        for(int i = 0; i < m; i++)
        {
            result += int.Parse(a[int.Parse(b[i]) - 1]);
        }

        Console.WriteLine(result);
    }
}