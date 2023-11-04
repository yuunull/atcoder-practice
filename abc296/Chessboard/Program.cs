using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string result = "";
        for(int i = 8; i > 0; i--)
        {
            char[] s = Console.ReadLine().ToCharArray();
            for(int j = 0; j < 8; j++)
            {
                if(s[j] == '*')
                {
                    char letter = (char)('a' + j);
                    result = letter + i.ToString();
                }
            }
        }
        Console.WriteLine(result);
    }
}