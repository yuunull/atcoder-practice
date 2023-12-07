using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
	static void Main()
	{
        int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();

        double log2a = Math.Log(abc[0], 2);
        double bLogsc = Math.Log(abc[2], 2) * abc[1];
        Console.WriteLine(log2a < bLogsc ? "Yes" : "No");
	}
}