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

        bool isYes = true;
        if(array.Length != array.Distinct().Count())
        {
            isYes = false;
        }

        if(isYes)
        {
            for(int i = 0; i < n - 1; i++)
            {
                if(array[i][array[i].Length - 1] != array[i + 1][0])
                {
                    isYes = false;
                    break;
                }
            }
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}