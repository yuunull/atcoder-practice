using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        char[] sArray = Console.ReadLine().ToCharArray();
        Console.WriteLine(sArray.Count(r => r.ToString() == "1"));
    }
}