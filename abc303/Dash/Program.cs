using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] nmhk = Console.ReadLine().Split();
        int n = int.Parse(nmhk[0]);
        int m = int.Parse(nmhk[1]);
        int h = int.Parse(nmhk[2]);
        int k = int.Parse(nmhk[3]);
        char[] s = Console.ReadLine().ToCharArray();

        SortedDictionary<string, bool> itemMap = new SortedDictionary<string, bool>();
        for(int i = 0; i < m; i++)
        {
            itemMap.Add(Console.ReadLine(), true);
        }

        bool isWin = true;
        int x = 0;
        int y = 0;
        for(int i = 0; i < s.Count(); i++)
        {
            switch(s[i])
            {
                case 'R':
                    x += 1;
                    break;
                case 'L':
                    x -= 1;
                    break;
                case 'U':
                    y += 1;
                    break;
                case 'D':
                    y -= 1;
                    break;
            }
            h--;
            if(h < 0)
            {
                isWin = false;
                break;
            }

            if(itemMap.ContainsKey(x + " " + y))
            {
                if(h < k)
                {
                    h = k;
                    itemMap.Remove(x + " " + y);
                }
            }
        }

        Console.WriteLine(isWin ? "Yes" : "No");
    }
}