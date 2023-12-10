using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
	static void Main()
	{
        int[] kgm = Console.ReadLine().Split().Select(int.Parse).ToArray();  
        var k = kgm[0];
        var g = kgm[1];
        var m = kgm[2];

        var ag = 0;
        var am = 0;
        for(int i = 0; i < k; i++)
        {
            if (ag == g)
            {
                ag = 0;
            }
            else if (am == 0)
            {
                am = m;
            }
            else
            {
                var actChange = Math.Min(g - ag, am);
                ag += actChange;
                am -= actChange;
            }
        }
        Console.WriteLine($"{ag} {am}");
	}
}