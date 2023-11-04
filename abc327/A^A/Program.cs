using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    public static void Main()
    {
        long b = long.Parse(Console.ReadLine());

        BigInteger result = -1;
        BigInteger i = 1;
        while (BigInteger.Pow(i, (int)i) <= b)
        {
            if (BigInteger.Pow(i, (int)i) == b)
            {
                result = i;
            }
            i++;
        }
        Console.WriteLine(result);
    }
}