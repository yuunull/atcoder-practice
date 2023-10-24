using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int count = 0;

        for(var i = 0; i <= a; i++)
        {
            for(var j = 0; j <= b; j++)
            {
                for( var k = 0; k <= c; k++)
                {
                    if ((500 * i + 100 * j + 50 * k) == x)
                    {
                        count++;
                    }
                }
            }
        }
        
        Console.WriteLine(count);
    }
}