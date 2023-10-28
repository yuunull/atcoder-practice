using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool isOk = true;
        while(isOk)
        {
            char[] array = n.ToString().ToCharArray();
            int x = int.Parse(array[0].ToString());
            int y = int.Parse(array[1].ToString());
            int z = int.Parse(array[2].ToString());
            if(x * y == z)
            {
                Console.WriteLine(n);
                isOk = false;
                break;
            }
            n++;
        }
    }
}