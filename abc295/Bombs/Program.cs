using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] rc = Console.ReadLine().Split();
        int r = int.Parse(rc[0]);
        int c = int.Parse(rc[1]);

        char[][] array = new char[r][];
        for(int i = 0; i < r; i++)
        {
            array[i] = Console.ReadLine().ToArray();
        }

        for(int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                if(array[i][j] == '.' || array[i][j] == '#') continue;
                int p = int.Parse(array[i][j].ToString());
                for(int k = 0; k < r; k++)
                {
                    for(int l = 0; l < c; l++)
                    {
                        if(Math.Abs(i - k) + Math.Abs(j - l) <= p && array[k][l] == '#') array[k][l] = '.';
                    }
                }
                array[i][j] = '.';
            }
        }

        foreach(var item in array) Console.WriteLine(string.Join("", item));
    }
}