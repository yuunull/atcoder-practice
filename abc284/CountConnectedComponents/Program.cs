using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int N = int.Parse(nm[0]);
        int M = int.Parse(nm[1]);

        List<int>[] graph = new List<int>[N];
        for (int i = 0; i < N; i++) 
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < M; i++) 
        {
            string[] uv = Console.ReadLine().Split();
            int u = int.Parse(uv[0]) - 1;
            int v = int.Parse(uv[1]) - 1;
            graph[u].Add(v);
            graph[v].Add(u);
        }

        int count = 0;
        bool[] visited = new bool[N];
        for (int i = 0; i < N; i++) 
        {
            if (!visited[i]) {
                count++;
                DFS(i, graph, visited);
            }
        }

        Console.WriteLine(count);
    }

    static void DFS(int v, List<int>[] graph, bool[] visited) 
    {
        visited[v] = true;
        foreach (int u in graph[v]) 
        {
            if (!visited[u]) 
            {
                DFS(u, graph, visited);
            }
        }
    }
}