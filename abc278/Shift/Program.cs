using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            var valueArray = line1.Split(" ");
            var n = Convert.ToInt32(valueArray[0]);
            var k = Convert.ToInt32(valueArray[1]);

            string[] result = new string[n];

            if (n < k) {
                for (var i = 0; i < n; i++)
                {
                    result[i] = "0";
                }
            }
            
            if(n >= k){
                var array = line2.Split(" ");
                int cnt = 0;
                for (var i = k; i < n; i++) {
                    result[cnt] = array[i];
                    cnt++;
                }

                for(var i = 0; i < n - (n - k); i++ ){
                    result[n - k + i] = "0";
                }
            }
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
