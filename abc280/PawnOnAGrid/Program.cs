using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var h = Convert.ToInt32(input[0]);
            var w = Convert.ToInt32(input[1]);

            string[,] X = new string[h, w];

            var result = 0;
            for (int i = 0; i < h; i++)
            {
               char[] gyou = Console.ReadLine().ToCharArray();
                for (int j = 0; j < w; j++)
                {
                    if(gyou[j].ToString() == "#"){
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
