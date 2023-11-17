using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] npq = Console.ReadLine().Split();
        int n = int.Parse(npq[0]);
        int p = int.Parse(npq[1]);
        int q = int.Parse(npq[2]);
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int result = 0;
        for(int i = 0; i < n - 5; i++)
        {
            long sum = 1;
            for(int j = i; j < i + 5; j++)
            {
                sum *= a[j];
            }
            if(sum % p == q)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}