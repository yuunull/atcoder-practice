using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        char[] s = Console.ReadLine().ToCharArray();

        for(int i = 1; i < s.Count() / 2 + 1; i++)
        {
            int index1 = 2 * i - 2;
            int index2 = 2 * i - 1;
            char temp = s[index1];
            s[index1] = s[index2];
            s[index2] = temp;
        }

        Console.WriteLine(string.Join("", s));
    }
}