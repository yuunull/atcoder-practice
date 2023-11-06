using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] hw = Console.ReadLine().Split();
        int h = int.Parse(hw[0]);
        int w = int.Parse(hw[1]);
        char[][] a = new char[h][];
        char[][] b = new char[h][];

        for(int i = 0; i < h; i++)
        {
            a[i] = Console.ReadLine().ToCharArray();
        }  
        for(int i = 0; i < h; i++)
        {
            b[i] = Console.ReadLine().ToCharArray();
        }

        for(int i= 0; i < h; i++)
        {
            for(int j= 0; j < w; j++)
            {
                if (CheckEqual(a, b, h, w,i,j))
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
        }

        Console.WriteLine("No");
    }

    static bool CheckEqual(char[][] a, char[][] b, int h, int w,int x,int y)
    {
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (a[(i+x)%h][(j+y)%w] != b[i][j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}