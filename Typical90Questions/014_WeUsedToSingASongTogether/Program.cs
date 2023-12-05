using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
    /// <summary>
    /// ・aとbの配列をソートする。
    /// ・aとbの配列を最初の要素から引き算しその絶対値を合計していく
    /// </summary>
	static void Main()
	{
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> sortedA = a.OrderBy(r => r).ToList();
        List<int> sortedB = b.OrderBy(r => r).ToList();

        long result = 0;
        for(int i = 0; i < n; i++)
        {
            result += Math.Abs(sortedA[i] - sortedB[i]);
        }
        Console.WriteLine(result);
	}
}