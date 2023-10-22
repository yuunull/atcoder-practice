using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] array = Console.ReadLine().ToCharArray();

        string[] moveArray = new string[n + 1];
        int x = 0;
        int y = 0;
        moveArray[0] = "00";
        for(int i = 1; i < n + 1; i++)
        {
            switch(array[i - 1].ToString())
            {
                case "R":
                    x += 1;
                    break;
                case "L":
                    x -= 1;
                    break;
                case "U":
                    y += 1;
                    break;
                case "D":
                    y -= 1;
                    break;
            }
            moveArray[i] = x.ToString() + y.ToString();
        }

        bool isYes = false;
        if(moveArray.Length - moveArray.Distinct().Count() > 0)
        {
            isYes = true;
        }

        Console.WriteLine(isYes ? "Yes" : "No");
    }
}