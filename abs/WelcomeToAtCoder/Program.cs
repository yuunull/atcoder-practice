using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int[] bc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        string s = Console.ReadLine();

        Console.WriteLine(a + bc[0] + bc[1] + " " + s);
    }
}