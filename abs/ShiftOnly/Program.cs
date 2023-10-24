using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] aArray = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

        int count = 0;
        while (aArray.All(r => r % 2 == 0))
        {
            aArray = aArray.Select(r => r / 2).ToArray();
            count++;

            if (aArray.Any(r => r % 2 != 0))
            {
                break;
            }
        }
        Console.WriteLine(count);
    }
}