using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        Console.WriteLine(s.Contains("ab") || s.Contains("ba") ? "Yes" : "No");
    }
}