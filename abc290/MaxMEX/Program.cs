using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nk = Console.ReadLine().Split();
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);

        HashSet<int> hash = new HashSet<int>(a);
        for(int i = 0; i < k; i++)
        {
            if(!hash.Contains(i))
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(k);
    }
}