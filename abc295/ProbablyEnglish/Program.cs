using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] w = Console.ReadLine().Split();
        string[] s = new string[]{"and", "not", "that", "the", "you"};

        bool isYes = false;
        for(int i = 0; i < n; i++)
        {
            if(s.Contains(w[i]))
            {
                isYes = true;
                break;
            }
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}