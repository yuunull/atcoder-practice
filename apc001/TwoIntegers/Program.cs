using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] xy = Console.ReadLine().Split();
        int x = int.Parse(xy[0]);
        int y = int.Parse(xy[1]);

        if (x % y == 0)
        {
            Console.WriteLine(-1);
            return;
        }

        Console.WriteLine(x);
    }
}