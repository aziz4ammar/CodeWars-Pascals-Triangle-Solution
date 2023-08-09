using System;
using System.Collections.Generic;

public static class Kata
{
    public static List<int> PascalsTriangle(int n)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int value = 1;
            for (int j = 0; j <= i; j++)
            {
                result.Add(value);
                value = value * (i - j) / (j + 1);
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int n = 5; // Change n to the desired number of rows in Pascal's Triangle
        List<int> pascalsTriangle = PascalsTriangle(n);

        // Print Pascal's Triangle
        for (int i = 0; i < pascalsTriangle.Count; i++)
        {
            Console.Write(pascalsTriangle[i] + " ");
        }
    }
}