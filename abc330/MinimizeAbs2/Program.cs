using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

class Program
{
    public static void Main()
    {
        long D = long.Parse(Console.ReadLine());

        long min = long.MaxValue;

        for (long x = 1; x * x <= D; x++) 
        {
            long y = (long)Sqrt(D - x * x);

            min = Min(min, Abs(x * x + y * y - D));
            if (y >= 2) 
            {
                min = Min(min, Abs(x * x + (y - 1) * (y - 1) - D));
            };
            min = Min(min, Abs(x * x + (y + 1) * (y + 1) - D));
        }

        Console.WriteLine(min);
    }
}