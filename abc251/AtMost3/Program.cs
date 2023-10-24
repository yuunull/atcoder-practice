using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nw = Console.ReadLine().Split();
        int n = int.Parse(nw[0]);
        int w = int.Parse(nw[1]);
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(numbers);

        // 途中でやめた
    }
}