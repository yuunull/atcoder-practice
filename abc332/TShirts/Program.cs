using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
	static void Main()
	{
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        string s = Console.ReadLine();

        var plain = m;
        var logo = 0;
        var cl = 0;
        for(int i = 0; i < n; i++)
        {
            if (s[i] == '2') 
            {
                if (cl == 0) logo++;
                else cl--;
            }
            else if (s[i] == '1')
            {
                if(plain == 0)
                {
                    if(cl == 0) logo++;
                    else cl--;
                }
                else
                {
                    plain--;
                }
            } 
            else if (s[i] == '0')
            {
                plain = m;
                cl = logo;
            }
        }

        Console.WriteLine(logo);
	}
}