using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] sa = new string[n, 2];
        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            sa[i, 0] = s[0];
            sa[i, 1] = s[1];
        }

        int min = int.Parse(sa[0, 1]);
        int index = 0;
        for(int i = 1; i < n; i++)
        {
            if(min > int.Parse(sa[i, 1]))
            {
                min = int.Parse(sa[i, 1]);
                index = i;
            }
        }


        for(int i = index; i < n; i++)
        {
            Console.WriteLine(sa[i, 0]);
        }

        for(int i = 0; i < index; i++)
        {
            Console.WriteLine(sa[i, 0]);
        }
    }
}