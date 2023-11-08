using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // 解けてない
    public static void Main()
    {
        string[] hw = Console.ReadLine().Split();
        long h = long.Parse(hw[0]);
        long w = long.Parse(hw[1]);

        char[][] s = new char[h][];
        for(int i = 0; i < h; i++)
        {
            s[i] = Console.ReadLine().ToCharArray();
        }

        bool hasSnuke = false;
        List<string> result = new List<string>();

        // 横の検査
        for(int i = 0; i < h; i++)
        {
            for(int j = 0; j <= w - 5; j++)
            {
                if("" + s[i][j] + s[i][j + 1] + s[i][j + 2] + s[i][j + 3] + s[i][j + 4] == "snuke")
                {
                    result.Add(i + 1 + " " + (j + 1));
                    result.Add(i + 1 + " " + (j + 2));
                    result.Add(i + 1 + " " + (j + 3));
                    result.Add(i + 1 + " " + (j + 4));
                    result.Add(i + 1 + " " + (j + 5));
                    hasSnuke = true;
                    break;
                }

                if("" + s[i][j + 4] + s[i][j + 3] + s[i][j + 2] + s[i][j + 1] + s[i][j] == "snuke")
                {
                    result.Add(i + 1 + " " + (j + 5));
                    result.Add(i + 1 + " " + (j + 4));
                    result.Add(i + 1 + " " + (j + 3));
                    result.Add(i + 1 + " " + (j + 2));
                    result.Add(i + 1 + " " + (j + 1));
                    hasSnuke = true;
                    break;
                }
            }
        }

        if(!hasSnuke)
        {
            // 縦の検査
            for(int i = 0; i <= h - 5; i++)
            {
                for(int j = 0; j < w; j++)
                {
                    if("" + s[i][j] + s[i + 1][j] + s[i + 2][j] + s[i + 3][j] + s[i + 4][j] == "snuke")
                    {
                        result.Add(i + 1 + " " + (j + 1));
                        result.Add(i + 2 + " " + (j + 1));
                        result.Add(i + 3 + " " + (j + 1));
                        result.Add(i + 4 + " " + (j + 1));
                        result.Add(i + 5 + " " + (j + 1));
                        hasSnuke = true;
                        break;
                    }

                    if("" + s[i + 4][j] + s[i + 3][j] + s[i + 2][j] + s[i + 1][j] + s[i][j] == "snuke")
                    {
                        result.Add(i + 5 + " " + (j + 1));
                        result.Add(i + 4 + " " + (j + 1));
                        result.Add(i + 3 + " " + (j + 1));
                        result.Add(i + 2 + " " + (j + 1));
                        result.Add(i + 1 + " " + (j + 1));
                        hasSnuke = true;
                        break;
                    }
                }
            }
        }

        if(!hasSnuke)
        {
            for(int i = 0; i <= h - 5; i++)
            {
                for(int j = 0; j <= w - 5; j++)
                {
                    if("" + s[i][j] + s[i + 1][j + 1] + s[i + 2][j + 2] + s[i + 3][j + 3] + s[i + 4][j + 4] == "snuke")
                    {
                        result.Add(i + 1 + " " + (j + 1));
                        result.Add(i + 2 + " " + (j + 2));
                        result.Add(i + 3 + " " + (j + 3));
                        result.Add(i + 4 + " " + (j + 4));
                        result.Add(i + 5 + " " + (j + 5));
                        break;
                    }

                    if("" + s[i + 4][j + 4] + s[i + 3][j + 3] + s[i + 2][j + 2] + s[i + 1][j + 1] + s[i][j] == "snuke")
                    {
                        result.Add(i + 5 + " " + (j + 5));
                        result.Add(i + 4 + " " + (j + 4));
                        result.Add(i + 3 + " " + (j + 3));
                        result.Add(i + 2 + " " + (j + 2));
                        result.Add(i + 1 + " " + (j + 1));
                        break;
                    }
                }
            }
        }

        foreach(string ans in result)
        {
            Console.WriteLine(ans);
        }
    }
}