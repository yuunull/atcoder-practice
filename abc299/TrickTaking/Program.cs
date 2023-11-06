using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nt = Console.ReadLine().Split();
        int n = int.Parse(nt[0]);
        int t = int.Parse(nt[1]);
        int[] c = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] r = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] indices = new int[n];
        if(c.Contains(t))
        {
            indices = c.Select((value, index) => new { value, index }).Where(pair => pair.value == t).Select(pair => pair.index).ToArray();
            
        }
        else
        {
            indices = c.Select((value, index) => new { value, index }).Where(pair => pair.value == c[0]).Select(pair => pair.index).ToArray();
        }

        int result = 0;
        int max = 0;
        for(int i = 0; i < indices.Count(); i++)
        {
            if(max < r[indices[i]])
            {
                max = r[indices[i]];
                result = indices[i] + 1;
            }
        }
        Console.WriteLine(result);
    }
}