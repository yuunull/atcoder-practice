using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];
        for(int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        Console.WriteLine(array.Distinct().Count());
    }
}