using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            
            bool isYes = false;
            for (int x = 0; x < 100; x++)
            {
                double twoX = Math.Pow(2, x);
                for (int y = 0; y < 100; y++)
                {
                    double threeY = Math.Pow(3, y);
                    if (twoX * threeY == n) {
                        isYes = true;
                        break;
                    }
                }

                if (isYes) 
                {
                    break;
                }
            }

            Console.WriteLine(isYes ? "Yes": "No");
        }
    }
}