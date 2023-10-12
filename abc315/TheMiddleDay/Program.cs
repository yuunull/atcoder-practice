using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split();


            int[] array = new int[m];
            for (int i = 0; i < m; i++) 
            {
                array[i] = int.Parse(d[i]) + (i == 0 ? 0 : array[i - 1]);
            }

            int center = (array[m - 1] + 1) / 2;

            int resultM = 1;
            for (int j = 0; j < m; j++) 
            {
                if(int.Parse(d[j]) < center) {
                    center -= int.Parse(d[j]);
                    resultM++;
                }
            }

            Console.WriteLine(resultM + " " + center);
        }
    }
}
