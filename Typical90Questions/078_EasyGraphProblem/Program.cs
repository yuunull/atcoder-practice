using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /// <summary>
    ///  隣接リストを利用してこの単純無向グラフを作成する
    ///  各頂点に対して、隣接する頂点の中で自身より番号が小さい頂点の数を数えます。この数がちょうど1であれば、その頂点は条件を満たします。
    /// </summary>
    public static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        List<int>[] adj = new List<int>[n + 1];
        for (int i = 1; i <= n; i++) 
        {
            adj[i] = new List<int>();
        };

        for (int i = 0; i < m; i++)
        {
            string[] ab = Console.ReadLine().Split();
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            adj[a].Add(b);
            adj[b].Add(a);
        }

        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            int smallerNeighbours = 0;
            foreach (int neighbour in adj[i])
            {
                if (neighbour < i) smallerNeighbours++;
            }
            if (smallerNeighbours == 1) count++;
        }

        Console.WriteLine(count);
    }
}