using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nw = Console.ReadLine().Split();
        int n = int.Parse(nw[0]);
        int w = int.Parse(nw[1]);
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(numbers);

       List<int> result = new List<int>();
       for(int i = 0; i < n; i++)
       {
            if(numbers[i] <= w)
            {
                result.Add(numbers[i]);
            }
            else
            {
                break;
            }

            for(int j = i + 1; j < n; j++)
            {
                if(numbers[i] + numbers[j] <= w)
                {
                    result.Add(numbers[i] + numbers[j]);
                }
                else
                {
                    break;
                }

                for(int k = j + 1; k < n; k++)
                {
                    if(numbers[i] + numbers[j] + numbers[k] <= w)
                    {
                        result.Add(numbers[i] + numbers[j] + numbers[k]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
       }

       Console.WriteLine(result.Distinct().Count());
    }
}