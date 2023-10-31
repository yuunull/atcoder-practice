using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] result = new int[k];
        for(int i = 0; i < k; i++)
        {
            if(result[i] == 0)
            {
                result[x[i] - 1] += 1;
            }
        }

        Console.WriteLine(result.Where(r => r == 0).Count());
        var zeroIndexes = result.Select((value, index) => new { Value = value, Index = index }).Where(item => item.Value == 0)
            .Select(item => item.Index + 1).OrderBy(index => index);
        Console.WriteLine(string.Join(" ", zeroIndexes));
    }
}