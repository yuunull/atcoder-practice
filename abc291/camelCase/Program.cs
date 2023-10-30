using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        
        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsUpper(s[i]))
            {
                Console.WriteLine(i + 1);
                return;
            }
        }
    }
}