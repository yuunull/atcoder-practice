using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] tEnds = { "eraser", "erase", "dreamer", "dream" };

        string ans = "YES";
        while (!string.IsNullOrEmpty(s))
        {
            var endswithAny = false;
            for (int i = 0; i < tEnds.Length; i++)
            {
                if (s.EndsWith(tEnds[i]))
                {
                    // 後ろから切る
                    endswithAny = true;
                    s = s[..(s.Length - tEnds[i].Length)];
                    break;
                }
            }
            if (!endswithAny)
            {
                ans = "NO";
                break;
            }

        }

        Console.WriteLine(ans);
    }
}