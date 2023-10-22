using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        // 入力の読み取り
        string[] hw = Console.ReadLine().Split();
        int h = int.Parse(hw[0]);
        int w = int.Parse(hw[1]);
        string[,] result = new string[h, w];
        
        for(int i = 0; i < h; i++) 
        {
            char[] input = Console.ReadLine().ToCharArray();
            for (int j = 0; j < w; j++)
            {
                result[i, j] = input[j].ToString();
            }
        }

        int col = 0;
        for(int i = 0; i < h + 2; i++) 
        {
            int row = 0;
            string rowResult = string.Empty;
            for (int j = 0; j < w + 2; j++)
            {
                if(i == 0 || h + 1 == i)
                {
                    rowResult += "#";
                    continue;
                }

                if(j == 0 || w + 1 == j)
                {
                    rowResult += "#";
                }
                else
                {
                    rowResult += result[col, row];
                    row++;
                }
            }

            Console.WriteLine(rowResult);

            if(i != 0 && h + 1 != i)
            {
                col++;
            }
        }
    }
}