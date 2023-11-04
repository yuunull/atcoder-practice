using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[,] a = new string[9, 9];
        for(int i = 0; i < 9; i++)
        {
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < 9; j++)
            {
                a[i, j] = s[j];
            }
        }

        bool isYes = true;
        for(int i = 0; i < 9; i++)
        {
            List<string> temp = new List<string>();
            List<string> temp2 = new List<string>();
            for(int j = 0; j < 9; j++)
            {
                temp.Add(a[i, j]);
                temp2.Add(a[j, i]);
            }

            if(temp.Distinct().Count() != 9)
            {
                isYes = false;
                break;
            }

            if(temp2.Distinct().Count() != 9)
            {
                isYes = false;
                break;
            }
        }
        
        List<string> temp3 = new List<string>();
        for(int k = 0; k < 9; k += 3)
        {
            temp3 = new List<string>();
            for(int l = 0; l < 3; l++)
            {
                temp3.Add(a[k, l]);
                temp3.Add(a[k + 1, l]);
                temp3.Add(a[k + 2, l]);
            }
            if(temp3.Distinct().Count() != 9)
            {
                isYes = false;
                break;
            }

            temp3 = new List<string>();
            for(int l = 0; l < 3; l++)
            {
                temp3.Add(a[l, k]);
                temp3.Add(a[l, k + 1]);
                temp3.Add(a[l, k + 2]);
            }
            if(temp3.Distinct().Count() != 9)
            {
                isYes = false;
                break;
            }
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}