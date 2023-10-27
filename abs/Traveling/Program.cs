using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int prevT = 0, prevX = 0, prevY = 0;

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int t = int.Parse(inputs[0]);
            int x = int.Parse(inputs[1]);
            int y = int.Parse(inputs[2]);

            int dt = t - prevT;
            int distance = Math.Abs(x - prevX) + Math.Abs(y - prevY);
            if (distance > dt || (distance % 2) != (dt % 2))
            {
                Console.WriteLine("No");
                return;
            }

            prevT = t;
            prevX = x;
            prevY = y;
        }
        Console.WriteLine("Yes");
    }
}