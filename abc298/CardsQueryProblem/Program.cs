using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        
        var cardList = new SortedSet<int>[200002];
        var boxList = new List<int>[200002];
        for (int i = 0; i < 200002; i++)
        {
            cardList[i] = new SortedSet<int>();
            boxList[i] = new List<int>();
        }

        for(int i = 0; i < q; i++)
        {
            int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
            switch(query[0])
            {
                case 1:
                    cardList[query[1]].Add(query[2]);
                    boxList[query[2]].Add(query[1]);
                    break;
                
                case 2:
                    boxList[query[1]].Sort();
                    Console.WriteLine(string.Join(" ", boxList[query[1]]));
                    break;

                case 3:
                    Console.WriteLine(string.Join(" ", cardList[query[1]]));
                    break;
            }
        }
    }
}