using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        
        bool isOk = false;
        for (int i = 0; i < s.Length; i++)
        {
            string sub = s.Substring(0, s.Length - 1);
            string last = s.Substring(s.Length - 1);
            if(last + sub == t)
            {
                isOk = true;
                break;
            }
            else
            {
                s = last + sub;
            }
        }

        Console.WriteLine(isOk ? "Yes" : "No");
    }
}