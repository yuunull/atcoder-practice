using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nhx = Console.ReadLine().Split(' ');
            int n = int.Parse(nhx[0]);
            int h = int.Parse(nhx[1]);
            int x = int.Parse(nhx[2]);
            string[] pArray = Console.ReadLine().Split(' ');

            int a = x - h;
            int result = 0;
            for (int i = 0; i < n; i++) {
                if (a <= int.Parse(pArray[i])) {
                    result = i + 1;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}