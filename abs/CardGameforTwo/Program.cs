using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] aArray = Console.ReadLine().Split();
        int[] intArray = aArray.Select(s => int.Parse(s)).OrderByDescending(num => num).ToArray();

        int alice = 0;
        int bob = 0;
        for(int i = 1; i < n + 1; i++)
        {
            if(i % 2 != 0)
            {
                alice += intArray[i - 1];
            }
            else
            {
                bob += intArray[i - 1];
            }
        }
        
        Console.WriteLine(alice - bob);
    }
}