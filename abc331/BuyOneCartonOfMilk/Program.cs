using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

class Program
{
    public static void Main()
    {
        string[] nsml = Console.ReadLine().Split();
        int n = int.Parse(nsml[0]);
        int s = int.Parse(nsml[1]);
        int m = int.Parse(nsml[2]);
        int l = int.Parse(nsml[3]);

        int ans = 100000000;
        for(int i = 0; i < 100; i++)
        {
            for(int j = 0; j < 100; j++)
            {
                for(int k = 0; k < 100; k++)
                {
                    if(i * 6 + j * 8 + k * 12 >= n)
                    {
                        ans = Math.Min(ans, i * s + j * m + k * l);
                    }
                }
            }
        }
        
        Console.WriteLine(ans);
    }
}