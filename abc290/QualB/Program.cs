using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nk = Console.ReadLine().Split();
        char[] s = Console.ReadLine().ToCharArray();
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);

        string result = string.Empty;
        int count = 0;
        for(int i = 0; i < n; i++)
        {
            result += s[i].ToString();
            if(s[i].ToString() == "o")
            {
                count++;
                if(count == k)
                {
                    break;
                }
            }
        }

        Console.WriteLine(result.PadRight(n, 'x'));
    }
}