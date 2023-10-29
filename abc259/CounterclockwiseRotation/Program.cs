using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nq = Console.ReadLine().Split();
        int n = int.Parse(nq[0]);
        int q = int.Parse(nq[1]);
        List<long> numbers = Console.ReadLine().Split().Select(long.Parse).OrderBy(r => r).ToList();

        long[] xArray = new long[q];
        for(int i = 0; i < q; i++)
        {
            xArray[i] = long.Parse(Console.ReadLine());
        }
        
        foreach(int i in xArray)
        {
            var index = numbers.BinarySearch(i);
            if (index < 0)
            {
                index = ~index;
            }

            int result = n - index;
            if (result < 0)
            {
                result = 0;
            }

            Console.WriteLine(result);
        }
    }
}