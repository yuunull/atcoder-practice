using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] xy = Console.ReadLine().Split();
        int x1 = int.Parse(xy[0]);
        int y1 = int.Parse(xy[1]);
        int x2 = int.Parse(xy[2]);
        int y2 = int.Parse(xy[3]);

        x2 = x2 - x1;
        y2 = y2 - y1;

        // ピタゴラスの定理
        double ans1 = Math.Pow(x2 - 1, 2) + Math.Pow(y2 - 2, 2);
        double ans2 = Math.Pow(x2 - 2, 2) + Math.Pow(y2 - 1, 2);
        double ans3 = Math.Pow(x2 - 2, 2) + Math.Pow(y2 + 1, 2);
        double ans4 = Math.Pow(x2 - 1, 2) + Math.Pow(y2 + 2, 2);
        double ans5 = Math.Pow(x2 + 1, 2) + Math.Pow(y2 - 2, 2);
        double ans6 = Math.Pow(x2 + 2, 2) + Math.Pow(y2 - 1, 2);
        double ans7 = Math.Pow(x2 + 2, 2) + Math.Pow(y2 + 1, 2);
        double ans8 = Math.Pow(x2 + 1, 2) + Math.Pow(y2 + 2, 2);

        if(ans1 == 5 || ans2 == 5 || ans3 == 5 || ans4 == 5 || ans5 == 5 || ans6 == 5 || ans7 == 5 || ans8 == 5 )
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}