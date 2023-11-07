using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string atocder = "atcoder";
        char[] s = Console.ReadLine().ToCharArray();
        char[] t = Console.ReadLine().ToCharArray();

        string str = "abcdefghijklmnopqrstuvwxyz";

        int atCountS = s.Count(x => x == '@');
        int atCountT = t.Count(x => x == '@');

        bool isYes = true;
        foreach(char c in str)
        {
            int countS = s.Count(x => x == c);
            int countT = t.Count(x => x == c);
            if(countS != countT) 
            {
                if(!atocder.Contains(c))
                {
                    isYes = false;
                    break;
                }

                if(countS < countT) 
                {
                    atCountS -= countT - countS;
                    if (atCountS < 0) 
                    {
                        isYes = false;
                        break;
                    }
                } 
                else
                {
                    atCountT -= countS - countT;
                    if (atCountT < 0) 
                    {
                        isYes = false;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(isYes ? "Yes" : "No");
    }
}