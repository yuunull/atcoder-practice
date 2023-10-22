using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();

        int result = t.Length;
        for(int i = 0; i <= s.Length - t.Length; i++)
        {
            int diff = 0;
            for(int j = 0; j < t.Length; j++)
            {
                if(t[j] != s[i + j])
                {
                    diff++;
                }
            }

            if(result > diff){
                result = diff;
            }
        }

        Console.WriteLine(result);
    }
}