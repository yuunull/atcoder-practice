using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        bool isSatisfaction = false;
        int target = 1;
        int result = 0;
        for(int i = 0; i < n; i++)
        {
            if(numbers[i] == target)
            {
                isSatisfaction = true;
                target++;
            }
            else
            {
                result++;
            }
        }

       Console.WriteLine(isSatisfaction ? result : -1);
    }
}