using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = (int)Math.Floor(Math.Log10(n));
        if(k < 3)
        {
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine(n -( n % (int)Math.Pow(10, k - 2)));
        }
    }
}