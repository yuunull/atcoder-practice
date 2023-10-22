using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] aArray = Console.ReadLine().Split();

        List<int> cutList = new List<int>();
        cutList.Add(0);
        cutList.Add(360);
        int sum = 0;
        for(int i = 0; i < aArray.Length; i++){
            sum = (sum + int.Parse(aArray[i])) % 360;
            cutList.Add(sum);
        }

        int max = 0;
        cutList.Sort();
        for(int i= 0; i < cutList.Count - 1; i++){
            max = Math.Max(max, cutList[i + 1] - cutList[i]);
        }

        Console.WriteLine(max);
    }
}