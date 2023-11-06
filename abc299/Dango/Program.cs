using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] s = Console.ReadLine().ToCharArray();

        if(!s.Contains('-'))
        {
            Console.WriteLine(-1);
            return;
        }
        
        int count = 0;
        int result = 0;
        for(int i = 0; i < n; i++)
        {
            if(s[i] == 'o')
            {
                count++;
            }
            else
            {
                if(result < count)
                {
                    result = count;
                }
                count = 0;
            }
        }

        if(count > 0 && result < count) result = count;    
        Console.WriteLine(result == 0 ? -1 : result);
    }
}