using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
	static void Main()
	{
        int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();

        long c = 1;
        for(int i = 0; i < abc[1]; i++)
        {
            c *= abc[2];
        }
        bool result = abc[0] < c;
        Console.WriteLine(result ? "Yes" : "No");
	}
}