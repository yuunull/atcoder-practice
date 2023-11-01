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

        SortedSet<int> set = new SortedSet<int>();
        int count = 1;
        for(int i = 0; i < q; i++)
        {
            string[] events = Console.ReadLine().Split();
            switch (events[0])
            {
                case "1":
                    set.Add(count);
                    count++;
                    break;
                case "2":
                    set.Remove(int.Parse(events[1]));
                    break;
                case "3":
                    Console.WriteLine(set.Min);
                    break;
            }
        }
    }
}