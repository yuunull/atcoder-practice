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
        string s = Console.ReadLine();

        int[] sumArray = new int[n];
        sumArray[0] = 0;
        for(int i = 1; i < n; i++)
        {
            sumArray[i] = sumArray[i - 1] + (s[i - 1] == s[i] ? 1 : 0);
        }
        
        List<int> resultList = new List<int>();
        for(int i = 0; i < q; i++)
        {
            int[] lr = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            Console.WriteLine(sumArray[lr[1] - 1] - sumArray[lr[0] - 1]);
        }
    }
}