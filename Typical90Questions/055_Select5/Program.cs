using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /// <summary>
    ///  以下を知らなかった。
    ///  この性質は複数の数に拡張可能
    ///  (a * b) mod p == (a mod p) * (b mod p)
    /// </summary>
    public static void Main()
    {
        string[] npq = Console.ReadLine().Split();
        int n = int.Parse(npq[0]);
        int p = int.Parse(npq[1]);
        int q = int.Parse(npq[2]);
        long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

        int result = 0;
        for(int i = 0; i < n - 4; i++)
        {           
            for(int j = i + 1; j < n - 3; j++)
            {
                for (int k = j + 1; k < n - 2; k++)
                {
                    for (int l = k + 1; l < n - 1; l++)
                    {
                        for (int m = l + 1; m < n ; m++)
                        {
                            if (a[i]%p * a[j]%p * a[k]%p * a[l]%p * a[m]%p == q) 
                            {
                                result++;
                            }
                        }
                    }                               
                }
            }                       
        }
        Console.WriteLine(result);
    }
}