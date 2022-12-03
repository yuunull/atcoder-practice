using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long result = n;

            for (int i = 2; i < n; i++)
            {
                try
                {
                    var factorial = Factorial(i);
                    if(factorial % n == 0) {
                        result = i;
                        break;
                    }
                }
                catch(OverflowException ex) 
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }

        private static long Factorial (long n) {
            return checked (n == 0 ? 1L : n * Factorial(n - 1));
        }
    }
}
