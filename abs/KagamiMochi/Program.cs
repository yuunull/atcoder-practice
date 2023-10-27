using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for(int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] intArray = array.Distinct().ToArray();
        Console.WriteLine(intArray.Count());
    }
}