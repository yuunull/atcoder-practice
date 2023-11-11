using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        List<string> result = new List<string>();
        for(int i = 0; i < s.Length; i++)
        {
            result.Add(s[i].ToString());
            if(s[i] == 'C')
            {
                int length = result.Count();
                if(length > 2)
                {
                    if(result[length - 3] == "A" && result[length - 2] == "B")
                    {
                        result.RemoveRange(length - 3, 3);
                    }
                }
            }
        }

        Console.WriteLine(string.Join("", result));
    }
}