using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        
        Console.WriteLine(CountWaysToMakeAmount(a, b, c, x));
    }

    static int CountWaysToMakeAmount(int a, int b, int c, int x)
    {
        if (x == 0) return 1;

        if (x < 0 || (a == 0 && b == 0 && c == 0)) return 0;

        int ways = 0;

        if (a > 0) ways += CountWaysToMakeAmount(a - 1, b, c, x - 500);
        if (b > 0) ways += CountWaysToMakeAmount(a, b - 1, c, x - 100);
        if (c > 0) ways += CountWaysToMakeAmount(a, b, c - 1, x - 50);

        return ways;
    }
}