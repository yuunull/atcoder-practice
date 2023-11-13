using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /// <summary>
    ///  登録した人はHashSetに追加する
    ///  HashSetに登録済みか検索し重複していたら何もしない
    ///  登録されていなかったらHashSetに追加する、また登録順を表示する
    /// </summary>
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> hashSet = new HashSet<string>();
        for(int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            if(!hashSet.Contains(s))
            {
                hashSet.Add(s);
                Console.WriteLine(i + 1);
            }
        }
    }
}