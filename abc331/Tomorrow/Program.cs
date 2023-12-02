using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

class Program
{
    public static void Main()
    {
        string[] md = Console.ReadLine().Split();
        int m = int.Parse(md[0]);
        int d = int.Parse(md[1]);
        int[] ymd = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if(ymd[2] + 1 > d)
        {
            if(ymd[1] + 1 > m)
            {
                Console.WriteLine((ymd[0] + 1) + " " + 1 + " " + 1);
            }
            else
            {
                Console.WriteLine(ymd[0] + " " + (ymd[1] + 1) + " " + 1);
            }
        }
        else
        {
            Console.WriteLine(ymd[0] + " " + ymd[1] + " " + (ymd[2] + 1));
        }
        
    }
}