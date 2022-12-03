using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            char[] t = Console.ReadLine().ToCharArray();

            var result = s.Length + 1;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] != t[i]) {
                    result = i + 1;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
