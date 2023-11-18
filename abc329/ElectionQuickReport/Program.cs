using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] array = new int[n + 1];
        int index = -1;
        int max = 0;
        for(int i = 0; i < m; i++)
        {
            array[a[i]] += 1;
            if(max < array[a[i]])
            {
                max = array[a[i]];
                index = a[i];
            }
            if(max == array[a[i]] && index > a[i])
            {
                index = a[i];
            }
            Console.WriteLine(index);
        }
   }
}