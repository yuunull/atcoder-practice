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

        if(x > y)
        {
            Console.WriteLine(x - y <= 3 ? "Yes" : "No");
        }
        else
        {
            Console.WriteLine(y - x <= 2 ? "Yes" : "No");
        }
    }
}