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
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(numbers);

        int[] result = new int[q];
        for(int i = 0; i < q; i++)
        {
            int x = int.Parse(Console.ReadLine());

            int mid1 = 0;
            int low = 0;
            int high = numbers.Length - 1;

            // xより小さい最大の数値のindexを取得する
            while (low <= high)
            {
                mid1 = (low + high) / 2;

                if (x >= numbers[mid1])
                {
                    low = mid1 + 1;
                }
                else
                {
                    high = mid1 - 1;
                }
            }

            int mid2 = 0;
            low = 0;
            high = numbers.Length - 1;

            // xより大きい最小の数値のindexを取得する
            while (low <= high)
            {
                mid2 = (low + high) / 2;

                if (x >= numbers[mid2])
                {
                    low = mid2 + 1;
                }
                else
                {
                    high = mid2 - 1;
                }
            }

            Console.WriteLine(mid1.ToString() + mid2.ToString());
            result[i] = mid1 - mid2;
        }

        // for(int i = 0; i < q; i++)
        // {
        //     Console.WriteLine(result[i]);
        // }
    }
}