using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /// <summary>
    ///  問題分通りに実装すればいい
    /// </summary>
    public static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        int[][] tx = new int[q][];
        for(int i = 0; i < q; i++)
        {
            tx[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        
        List<int> list = new List<int>();
        for(int i = 0; i < q; i++)
        {
            switch(tx[i][0])
            {
                case 1:
                    list.Insert(0, tx[i][1]);
                    break;
                case 2:
                    list.Add(tx[i][1]);
                    break;
                case 3:
                    Console.WriteLine(list[tx[i][1] - 1]);
                    break;
            }
        }
   }
}