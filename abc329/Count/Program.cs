using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        char[] charArray = s.ToCharArray();
        char[] sorteds = charArray.Distinct().ToArray();

        int result = 0;
        foreach(char ch in sorteds)
        {
            result += MaxConsecutive(s, ch);
        }

        
        Console.WriteLine(result);
   }

   static int MaxConsecutive(string str, char ch)
    {
        int maxCount = 0;
        int currentCount = 0;

        foreach (char c in str)
        {
            if (c == ch)
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 0;
            }
        }

        return maxCount;
    }
}