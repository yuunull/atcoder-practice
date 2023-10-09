using System;
using System.Linq;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            // リファクタリングすること
            // 累積和使って計算量を少なくすること
            // d/n回総和を計算して一番低い値段を判定するプログラムに修正すること
            string[] ndp = Console.ReadLine().Split(' ');
            string[] fArray = Console.ReadLine().Split(' ');
            int[] fIntArray = Array.ConvertAll(fArray, int.Parse).OrderByDescending(r => r).ToArray();

            int cnt = 0;
            int d1 = (int)(int.Parse(ndp[2]) / int.Parse(ndp[1]));
            for(int i = 0; i < fIntArray.Length; i++) {
                if(fIntArray[i] > d1) {
                    cnt++;
                }
            }
            Console.WriteLine(d1);

            int result = 0;
            int buy = (int)(cnt / int.Parse(ndp[1]));
            Console.WriteLine(buy);

            if(buy > 0) {
                for(int i = buy * int.Parse(ndp[1]); i < fIntArray.Length; i++) {
                    result += fIntArray[i];
                }
                result += buy * int.Parse(ndp[2]);
            }
            else
            {
                for(int i = 0; i < fIntArray.Length; i++) {
                    result += fIntArray[i];
                }
            }

            
            Console.WriteLine(result);
        }
    }
}
