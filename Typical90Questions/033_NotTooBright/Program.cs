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

        if(h == 1)
        {
            Console.WriteLine(w);
        }
        else if(w == 1)
        {
            Console.WriteLine(h);
        }
        else
        {
            var H = (double)h / 2;
            var h1 = Math.Ceiling(H);
            var W = (double) w / 2;
            var w1 = Math.Ceiling(W);

            var result = (int) h1 * w1;

            Console.WriteLine(result);
        }
    }
}