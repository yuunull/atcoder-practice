using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(ab[0] * ab[1] % 2 == 0 ? "Even" : "Odd");
    }
}