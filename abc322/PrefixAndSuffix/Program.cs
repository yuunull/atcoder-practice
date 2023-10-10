using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            bool isPrefix = false; 
            bool isSuffix = false; 
            int result = 3;
            if(n == m) {
                if(s == t) {
                    result = 0;
                }
            }
            else
            {
                for(int i = 0; i < n; i++) {
                    if (sArray[i] == tArray[i]) {
                        isPrefix = true;
                    }
                    else
                    {
                        isPrefix = false;
                        break;
                    }
                }

                for(int i = 0; i < n; i++) {
                    if (sArray[i] == tArray[m - n + i]) {
                        isSuffix = true;
                    }
                    else
                    {
                        isSuffix = false;
                        break;
                    }
                }
            }

            if(isPrefix && isSuffix) {
                result = 0;
            }
            else if (isPrefix && !isSuffix) {
                result = 1;
            }
            else if (!isPrefix && isSuffix) {
                result = 2;
            }

            Console.WriteLine(result);
        }
    }
}