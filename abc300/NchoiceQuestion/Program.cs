using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nab = Console.ReadLine().Split();
        int n = int.Parse(nab[0]);
        int a = int.Parse(nab[1]);
        int b = int.Parse(nab[2]);
        int[] c = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int ab =  a + b;
        for(int i = 0; i < n; i++)
        {
            if(ab == c[i])
            {
                Console.WriteLine(i + 1);
                break;
            }
        }
    }
}