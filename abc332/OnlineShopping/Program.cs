using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
	static void Main()
	{
        int[] nsk = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int result = 0;
        for(int i = 0; i < nsk[0]; i++)
        {
            int[] pq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            result += pq[0] * pq[1];
        }

        if(result < nsk[1])
        {
            result += nsk[2];
        }
        Console.WriteLine(result);
	}
}