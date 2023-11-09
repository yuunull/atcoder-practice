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

        string[][] a = new string[m][];
        for(int i = 0; i < m; i++)
        {
            a[i] = Console.ReadLine().Split();
        }

        List<string> pair = new List<string>();
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n - 1; j++)
            {
                int[] temp = new int[2];
                temp[0] = int.Parse(a[i][j]);
                temp[1] = int.Parse(a[i][j + 1]);
                string val = string.Join("", temp.OrderBy(r => r));
                if(pair.Where(r => r == val).Count() == 0)
                {
                    pair.Add(val);
                }
            }
        }
        Console.WriteLine(Combination(n, 2) - pair.Count());
    }

    static long Combination(int n, int k) 
    {
        if (k > n) return 0;
        if (k == 0 || k == n) return 1;

        long result = 1;
        for (int i = 1; i <= k; i++) 
        {
            result = result * (n - i + 1) / i;
        }

        return result;
    }
}