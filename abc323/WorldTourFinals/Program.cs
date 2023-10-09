using System;
using System.Linq;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            string[] pointArray = Console.ReadLine().Split(' ');
            int[] intPointArray = Array.ConvertAll(pointArray, int.Parse);

            string[] rArray = new string[n];
            for (int input = 0; input < n; input++)
            {
                rArray[input] = Console.ReadLine();
            }

            int[] pointResultArray = new int[n];
            int i = 0;
            foreach (string value in rArray)
            {
                int j = 0;
                bool hasAns = false;
                foreach (char c in value)
                {
                    if (c == 'o')
                    {
                        pointResultArray[i] += intPointArray[j];
                        hasAns = true;
                    }
                    j++;
                }
                if (hasAns)
                {
                    pointResultArray[i] += i + 1;
                }
                i++;
            }

            int[] resultArray = new int[n];
            int maxPoint = pointResultArray.Max();
            int[] sortedIntPointArray = intPointArray.OrderByDescending(x => x).ToArray();

            // 点数ごとに処理
            int resultIndex = 0;
            foreach (int point in pointResultArray)
            {
                // 最大点数より点数が低い場合
                int cnt = 0;
                if (point < maxPoint)
                {
                    int addPoint = point;
                    foreach (int s in sortedIntPointArray)
                    {
                        cnt++;
                        addPoint += s;
                        if (addPoint > maxPoint)
                        {
                            break;
                        }
                    }
                    resultArray[resultIndex] = cnt;
                }
                else
                {
                    resultArray[resultIndex] = 0;
                }
                resultIndex++;
            }

            foreach (var result in resultArray)
            {
                Console.WriteLine(result);
            }
        }
    }
}
