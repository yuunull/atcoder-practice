using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        string s2 = s.Replace(".", "");
        if(s2.Contains("|*|"))
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}