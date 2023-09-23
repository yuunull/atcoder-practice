using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = Console.ReadLine();
            char[] charArray = arg.ToCharArray();

            bool is321LikeNumber = true;
            for (var i = 0; i < charArray.Length - 1; i++)
            {
                if ((int)charArray[i] <= (int)charArray[i + 1])
                {
                    is321LikeNumber = false;
                }
            }

            Console.WriteLine(is321LikeNumber ? "Yes" : "No");
        }
    }
}
