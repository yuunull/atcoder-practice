using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /// <summary>
    /// +-１のみ変化できるのでAとBが同じになるのに必要な操作回数を求める
    /// 最低操作回数がKより大きかったら同じにすることはできない
    /// そうでない場合、K-最低操作回数が2で割り切れれば同じ数字にできる
    /// </summary>
    public static void Main()
    {
        string[] nk = Console.ReadLine().Split();
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);
        
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int count = 0;
        for(int i = 0; i < n; i++)
        {
            count += Math.Abs(a[i] - b[i]);
        }

        if(k < count)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(Math.Abs(k - count) % 2 == 0 ? "Yes" : "No");
        }
    }
}