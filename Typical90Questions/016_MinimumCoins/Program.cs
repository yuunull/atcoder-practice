using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
	static void Main()
	{
        int n = int.Parse(Console.ReadLine());
        int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
        long result = 9999;

        for (long i = 0; i <= 9999; i++)
        {
            for (long j = 0; j < 9999 - i; j++)
            {
                long zan = n - (abc[0] * i + abc[1] * j);
                if (zan < 0) continue;
                if (zan % abc[2] == 0)
                {
                    result = Math.Min(result, i + j + (zan / abc[2]));
                }
            }
        }

        Console.WriteLine(result);
	}
}