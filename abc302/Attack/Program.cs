using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] ab = Console.ReadLine().Split();
        long a = long.Parse(ab[0]);
        long b = long.Parse(ab[1]);

        long result = a / b + (a % b == 0 ? 0 : 1);
        Console.WriteLine(result);
    }
}