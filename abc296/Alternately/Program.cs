using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] s = Console.ReadLine().ToCharArray();

        bool isYes = true;
        for(int i = 0; i < n - 1; i++)
        {
            if(s[i] == s[i + 1])
            {
                isYes = false;
                break;
            }
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}