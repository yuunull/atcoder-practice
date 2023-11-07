using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int t = s.Count(r => r == 'T');
        int a = s.Count(r => r == 'A');

        if(t > a)
        {
            Console.WriteLine('T');
            return;
        }

        if(t < a)
        {
            Console.WriteLine('A');
            return;
        }

        if(t == a)
        {
            int tTesult = t;
            int aTesult = a;
            for(int i = 0; i < n; i++)
            {
                if(s[i] == 'T')
                {
                    tTesult--;
                    if(tTesult == 0)
                    {
                        Console.WriteLine('T');
                        break;
                    }
                }
                if(s[i] == 'A')
                {
                    aTesult--;
                    if(aTesult == 0)
                    {
                        Console.WriteLine('A');
                        break;
                    }
                }
                
            }
        }

        
    }
}