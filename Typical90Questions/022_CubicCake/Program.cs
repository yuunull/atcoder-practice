using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /// <summary>
    /// A B Cの最大公約数を求める
    /// A B Cを求めた最大公約数で割る。得られた値が各辺に沿って生成される立方体の数
    /// 各辺に沿って生成される立方体から1を引いたものが切断回数
    /// 切断回数の合計が最小の切断回数
    /// </summary>
    public static void Main()
    {
        string[] abc = Console.ReadLine().Split();
        long a = long.Parse(abc[0]);
        long b = long.Parse(abc[1]);
        long c = long.Parse(abc[2]);

        long gcd = Gcd(Gcd(a, b), c);

        Console.WriteLine((a / gcd - 1) + (b / gcd - 1) + (c / gcd - 1));
    }

    static long Gcd(long a, long b) 
    {
        while (b != 0) 
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}