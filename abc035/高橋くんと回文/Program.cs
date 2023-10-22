using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        char[] sArray = Console.ReadLine().ToCharArray();
        char[] reversed = sArray.Reverse().ToArray();

        bool isYes = true;
        for(int i = 0; i < sArray.Length; i++) 
        {
            if(sArray[i].ToString() == "*" || reversed[i].ToString() == "*") continue;
            if(sArray[i] != reversed[i])
            {
                isYes = false;
                break;
            }
        }

        Console.WriteLine(isYes ? "YES" : "NO");
    }
}