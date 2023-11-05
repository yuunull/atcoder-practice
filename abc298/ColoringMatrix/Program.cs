using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] a = new int[n, n];
        int[,] b = new int[n, n];

        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < n; j++)
            {
                a[i, j] = int.Parse(s[j]);
            }
        }

        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < n; j++)
            {
                b[i, j] = int.Parse(s[j]);
            }
        }

        bool isYes = true;
        int count = 0;
        int[,] rotated = new int[n, n];
        while(count != 4)
        {
            isYes = true;
            rotated = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    rotated[j, n - 1 - i] = a[i, j];
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(rotated[i, j] == 1 && b[i, j] != 1)
                    {
                        isYes = false;
                    }
                }
            }

            if(isYes)
            {
                break;
            }

            a = rotated;
            count++;
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}