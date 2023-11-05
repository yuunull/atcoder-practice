using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
///  TLEする改善すること
/// </summary>
class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        
        List<List<int>> resultList = new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            resultList.Add(new List<int>());
        }

        for(int i = 0; i < q; i++)
        {
            int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
            switch(query[0])
            {
                case 1:
                    resultList[query[2] - 1].Add(query[1]);
                    break;
                
                case 2:
                    Console.WriteLine(string.Join(" ", resultList[query[1] - 1].OrderBy(r => r)));
                    break;

                case 3:
                    List<int> indices = new List<int>();
                    for (int k = 0; k < resultList.Count(); k++)
                    {
                        if(resultList[k].Contains(query[1]))
                        {
                            indices.Add(k + 1);
                        }
                    }
                    Console.WriteLine(string.Join(" ", indices.OrderBy(r => r)));
                    break;
            }
        }
    }
}