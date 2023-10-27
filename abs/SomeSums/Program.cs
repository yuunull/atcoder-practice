using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nab = Console.ReadLine().Split();
        int n = int.Parse(nab[0]);
        int a = int.Parse(nab[1]);
        int b = int.Parse(nab[2]);

        List<int> someArray = new List<int>();
        for(int i = 1; i <= n; i++)
        {
            int sum = i.ToString().ToCharArray().Select(c => (int)Char.GetNumericValue(c)).ToArray().Sum();
            if(sum >= a && sum <= b)
            {
                someArray.Add(i);
            }
        }
        
        Console.WriteLine(someArray.Sum());
    }
}