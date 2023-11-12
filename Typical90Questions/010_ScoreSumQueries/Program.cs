using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /// <summary>
    /// 【累積和】
    /// 1組・2組の累積和を作成する
    /// 範囲における1組、2組のそれぞれの合計を求める
    /// </summary>
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cp1 = new int[n + 1];
        int[] cp2 = new int[n + 1];
        for(int i = 0; i < n; i++)
        {
            cp1[i + 1] = cp1[i];
            cp2[i + 1] = cp2[i];

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if ((input[0] % 2) > 0)
            {
                cp1[i + 1] += input[1];
            }
            else 
            {
                cp2[i + 1] += input[1];
            }
        }

        int q = int.Parse(Console.ReadLine());
        for(int i = 0; i < q; i++)
        {
            string[] s = Console.ReadLine().Split();
            int v1 = cp1[int.Parse(s[1])] - cp1[int.Parse(s[0]) - 1];
            int v2 = cp2[int.Parse(s[1])] - cp2[int.Parse(s[0]) - 1];
            Console.WriteLine(v1 + " " + v2);
        }
    }
}