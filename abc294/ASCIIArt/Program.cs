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

        for(int i = 0; i < h; i++)
        {
            string result = string.Empty;
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();   
            for(int j = 0; j < w; j++)
            {
                if(a[j] == 0)
                {
                    result += ".";
                }
                else
                {
                    result += (char)('A' + a[j] - 1);
                }
            }
            Console.WriteLine(result);
        }
    }
}