using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] s = Console.ReadLine().ToCharArray();
        char[] t = Console.ReadLine().ToCharArray();
        
        bool isYes = true;
        for(int i = 0; i < n; i++)
        {
            if(s[i] == t[i])
            {
                isYes = true;
                continue;
            }
            else
            {
                isYes = false;
            }

            if((s[i] == '1' && t[i] == 'l') || (t[i] == '1' && s[i] == 'l'))
            {
                isYes = true;
                continue;
            }
            else
            {
                isYes = false;
            }

            if((s[i] == '0' && t[i] == 'o') || t[i] == '0' && s[i] == 'o')
            {
                isYes = true;
                continue;
            }
            else
            {
                isYes = false;
            }

            if(!isYes) break;
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}