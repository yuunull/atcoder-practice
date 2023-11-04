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

        List<string> result = new List<string>();
        for(int i = 0; i < h; i++)
        {
            string s = Console.ReadLine();
            result.Add(s.Replace("TT","PC"));
        }

        foreach(string val in result)
        {
            Console.WriteLine(val);
        }
    }
}