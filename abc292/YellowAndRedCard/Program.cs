using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nq = Console.ReadLine().Split();
        int n = int.Parse(nq[0]);
        int q = int.Parse(nq[1]);

        int[] result = new int[n];
        List<string> ansArray = new List<string>(); 
        for(int i = 0; i < q; i++)
        {
            string[] x = Console.ReadLine().Split();
            int x1 = int.Parse(x[0]);
            int x2 = int.Parse(x[1]);
            if(x1 == 1)
            {
                result[x2 - 1] += 1;
            }

            if(x1 == 2)
            {
                result[x2 - 1] += 2;
            }

            if(x1 == 3)
            {
                ansArray.Add(result[x2 - 1] > 1 ? "Yes" : "No");
            }
        }

        foreach(string ans in ansArray)
        {
            Console.WriteLine(ans);
        }
    }
}