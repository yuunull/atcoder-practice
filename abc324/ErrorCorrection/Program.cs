using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nt = Console.ReadLine().Split();
            int n = int.Parse(nt[0]);
            string t = nt[1];

            string[] sArray = new string[n];
            for (int i = 0; i < n; i++) 
            {
                sArray[i] = Console.ReadLine();
            }

            List<int> resultArray = new List<int>();
            for (int x = 0; x < n; x++)
            {
                bool isContinue = false;

                // 一つ目の条件
                if(sArray[x] == t)
                {
                    resultArray.Add(x + 1);
                    isContinue = true;
                }

                if (isContinue) continue;
                
                // 2つ目の条件
                if(sArray[x].Length + 1 == t.Length)
                {
                    for (int i = 0; i < sArray[x].Length + 1; i++) 
                    {
                        for (int j = 0; j < t.Length; j++) 
                        {
                            string orginal = sArray[x];
                            string aa = orginal.Insert(i, t[j].ToString());
                            if (aa == t) {
                                resultArray.Add(x + 1);
                                isContinue = true;
                                break;
                            }
                        }
                    }
                }

                if (isContinue) continue;

                // 3つ目の条件
                if(sArray[x].Length - 1 == t.Length)
                {
                    for (int i = 0; i < sArray[x].Length; i++)
                    {
                        if (sArray[x].Remove(i, 1) == t)
                        {
                            resultArray.Add(x + 1);
                            isContinue = true;
                            break;
                        }
                    }
                }

                if (isContinue) continue;

                if (sArray[x].Length == t.Length) {
                    for (int i = 0; i < sArray[x].Length; i++)
                    {
                        for (int j = 0; j < t.Length; j++) 
                        {
                            char[] orginalArray = sArray[x].ToCharArray();
                            orginalArray[i] = t[j];
                            if (new String(orginalArray).Contains(t)) {
                                resultArray.Add(x + 1);
                                break;
                            }
                        }
                    }
                }
            }


            Console.WriteLine(resultArray.Count());
            Console.WriteLine(String.Join(" ", resultArray));
        }
    }
}