using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = Console.ReadLine();

            var result = IsPartialPalindrome(arg);

            if (result.Item1)
            {
                Console.WriteLine(result.Item2);
            }
            else
            {
                Console.WriteLine(1);
            }
        }

        static (bool, int) IsPartialPalindrome(string input)
        {
            // 文字列を小文字に変換してスペースを削除
            input = input.ToLower().Replace(" ", "");

            int length = input.Length;
            int palindromeLength = 0; // 回文の文字数

            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - i - 1])
                {
                    break; // 回文でない部分が見つかったらループを抜ける
                }

                // 回文の文字数を更新
                palindromeLength += 2; // 2つの文字が回文に寄与するため
            }

            // 回文の文字数が奇数の場合、中央の文字も回文に含まれる
            if (length % 2 == 1)
            {
                palindromeLength++;
            }

            bool isPartialPalindrome = palindromeLength > 0;

            return (isPartialPalindrome, palindromeLength);
        }
    }
}
