using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int start_y = 0;
    static int start_x = 0;
    static int[][] graph;
    static List<int> roots = new List<int>();
    static int ans = 0;

    public static void Main()
    {
        string[] hw = Console.ReadLine().Split();
        int h = int.Parse(hw[0]);
        int w = int.Parse(hw[1]);

        graph = new int[h][];

        for(int i = 0; i < h; i++)
        {
            graph[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        DFS(h, w, start_y, start_x);
        Console.WriteLine(ans);
    }

    public static void DFS(int h, int w, int y, int x)
    {
        if(roots.Contains(graph[y][x]))
        {
            return;
        }
        
        roots.Add(graph[y][x]);
        
        if(y == h - 1 && x == w - 1)
        {
            ans++;
        }

        if(y + 1 < h)
        {
            DFS(h, w, y + 1, x);
        }
        if(x + 1 < w)
        {
            DFS(h, w, y, x + 1);
        }

        roots.RemoveAt(roots.Count - 1);
    }
}