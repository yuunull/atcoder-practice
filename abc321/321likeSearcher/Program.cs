using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            List<int> likeArray = new List<int>();
            for (int i = 1; i <= 987654321; i++)
            {
                bool is321LikeNumber = true;
                char[] charArray = i.ToString().ToCharArray();
                for (var j = 0; j < charArray.Length - 1; j++)
                {
                    if ((int)charArray[j] <= (int)charArray[j + 1])
                    {
                        is321LikeNumber = false;
                        break;
                    }
                }

                if (is321LikeNumber)
                {
                    likeArray.Add(i);
                }

                if (likeArray.Count() > k)
                {
                    break;
                }
            }

            Console.WriteLine(likeArray[k - 1]);
        }
    }
}
