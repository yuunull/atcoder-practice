using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] hw = Console.ReadLine().Split();
        int h = int.Parse(hw[0]);
        int w = int.Parse(hw[1]);

        int[][] a = new int[h][];
        int[,] result = new int[h, w];
        int[] hSumArray = new int[w];
        int[] wSumArray = new int[h];
        for(int i = 0; i < h; i++)
        {
            a[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            wSumArray[i] = a[i].Sum();
        }

        for(int i = 0; i < w; i++)
        {
            hSumArray[i] = a.Sum(row => row.Length > i ? row[i] : 0);
        }

        for(int i = 0; i < h; i++)
        {
            for(int j = 0; j < w; j++)
            {
                result[i, j] = wSumArray[i] + hSumArray[j] - a[i][j];
            }
        }

        for(int i = 0; i < h; i++)
        {
            int[] ans = new int[w];
            for (int j = 0; j < w; j++) 
            {
                ans[j] = result[i, j];
            }
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}