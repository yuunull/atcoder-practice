using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] s = Console.ReadLine().ToCharArray();

        bool isYes = false;
        for(int i = 0; i < n; i++)
        {
            if(s[i] == 'o')
            {
                isYes = true;
            }
            if(s[i] == 'x')
            {
                isYes = false;
                break;
            }
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}