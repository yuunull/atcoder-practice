using System;
using System.Linq;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nmp = Console.ReadLine().Split(' ');
            int n = int.Parse(nmp[0]);
            int m = int.Parse(nmp[1]);
            int p = int.Parse(nmp[2]);

            int cnt = 0;
            if(n >= m){
                bool isNoFullMoon = true;
                int currentDay = m;
                while(isNoFullMoon) {
                    currentDay += p;
                    if(currentDay > n) {
                        isNoFullMoon = false;
                    }
                    cnt++;
                }
            }
            else
            {
                cnt = 0;
            }

            Console.WriteLine(cnt);
        }
    }
}
