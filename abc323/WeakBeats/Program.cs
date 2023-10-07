using System;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            bool isYes = true;
            for (int i = 1; i < charArray.Length + 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (int.Parse(charArray[i - 1].ToString()) != 0)
                    {
                        isYes = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isYes ? "Yes" : "No");
        }
    }
}
