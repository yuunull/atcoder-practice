using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] d = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int result = 0;
        int month = 1;
        for(int i = 0; i < n; i++)
        {
            int day = 1;
            for(int j = 0; j < d[i]; j++)
            {
                bool isZoro = true;
                char[] daysString = day.ToString().ToCharArray();
                char[] daySum = daysString.Concat(month.ToString().ToCharArray()).ToArray();
                if(daySum.All(c => c == daySum[0]))
                {
                    result++;
                }
                day++;
            }
            month++;
        }

        Console.WriteLine(result);
    }
}