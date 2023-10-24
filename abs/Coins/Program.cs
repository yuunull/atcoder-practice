using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int[] choices = new int[a + b + c];
        for(int i = 0; i < a; i++)
        {
            choices[i] = 500;
        }

        for(int i = a; i < a + b; i++)
        {
            choices[i] = 100;
        }

        for(int i = a + b; i < a + b + c; i++)
        {
            choices[i] = 50;
        }

        int count = 0;
        List<int> currentCombination = new List<int>();
        DFS(0, x, choices, currentCombination, count);
        
        Console.WriteLine(count);
    }

    static void DFS(int currentNumber, int targetNumber, int[] choices, List<int> currentCombination, int count)
    {
        if (currentNumber == targetNumber)
        {
            count++;
            return;
        }

        if (choices.Length == 0 || currentNumber > targetNumber)
        {
            return;
        }

        for (int i = 0; i < choices.Length; i++)
        {
            int choice = choices[i];
            currentCombination.Add(choice);
            DFS(currentNumber + choice, targetNumber, choices[i..], currentCombination, count);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}