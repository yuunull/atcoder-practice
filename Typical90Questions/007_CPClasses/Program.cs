using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
    /// <summary>
    /// ・aの配列をソートし2分探索できるようにする
    /// ・bをa配列から2分探索する。一致するindexがあればその要素とbの絶対値をとる
    /// ・一致するindexがない場合、ビット反転する。ビット反転したものからindex,index-1どちらに近いか判定する
    /// </summary>
	static void Main()
	{
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int q = int.Parse(Console.ReadLine());

        List<int> sorted = a.OrderBy(r => r).ToList();
        List<int> result = new List<int>();
        for(int i = 0; i < q; i++)
        {
            int b = int.Parse(Console.ReadLine());
            int index = sorted.BinarySearch(b);
            int closestIndex = index;
            if(index < 0)
            {
                index = ~index;

                if (index == 0)
                {
                    closestIndex = 0;
                }
                else if (index >= sorted.Count())
                {
                    closestIndex = sorted.Count() - 1;
                }
                else
                {
                    int lower = sorted[index - 1];
                    int higher = sorted[index];
                    closestIndex = (b - lower <= higher - b) ? index - 1 : index;
                }
            }
            result.Add(Math.Abs(sorted[closestIndex] - b));
        }
        foreach(int val in result)
        {
            Console.WriteLine(val);
        }
	}
}