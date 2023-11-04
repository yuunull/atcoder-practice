using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        char[] s = Console.ReadLine().ToCharArray();

        List<int> b = new List<int>();
        List<int> r = new List<int>();
        int kindex = 0;
        for(int i = 0; i < 8; i++)
        {
            if(s[i] == 'B')
            {
                b.Add(i + 1);
                continue;
            }
            if(s[i] == 'R')
            {
                r.Add(i + 1);
                continue;
            }
            if(s[i] == 'K')
            {
                kindex = i + 1;
            }
        }

        if(Math.Abs(b[1] - b[0]) % 2 == 0)
        {
            Console.WriteLine("No");
            return;
        }

        if(r[0] < kindex && r[1] > kindex)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}