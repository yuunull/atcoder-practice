using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            string[] sArray = Console.ReadLine().Split(' ');

            bool[] everyDays = new bool[n];
            for (int i = 0; i < n; i++) {
                everyDays[i] = false;
            }

            for (int j = 0; j < m; j++) {
                everyDays[int.Parse(sArray[j]) - 1] = true;
            }

            int cnt = 0;
            int[] resultArray = new int[n];
            for (int k = n - 1; k >= 0; k--) {
                if (everyDays[k]) {
                    resultArray[k] = 0;
                    cnt = 0;
                }
                else
                {
                    cnt++;
                    resultArray[k] = cnt;
                }
            }

            foreach (int result in resultArray) {
                Console.WriteLine(result);
            }
        }
    }
}