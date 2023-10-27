using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int n = int.Parse(s[0]);
        int y = int.Parse(s[1]);

        for(int i = 0; i <= n; i++)
        {
            if(10000 * i > y) continue;
            for(int j = n - i; j >= 0; j--)
            {
                if(10000 * i + 5000 * j + 1000 * (n - i - j) == y)
                {
                    Console.WriteLine(i + " " + j + " " + (n - i - j));
                    return;
                }
            }
        }
        Console.WriteLine("-1 -1 -1");
    }
}