using System;

class Solution
{
    static void staircase(int n)
    {
        char[,] matrix = new char[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j >= n - 1 - i; j--)
            {
                matrix[i, j] = '#';
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                char output = matrix[i, j] != '#' ? ' ' : matrix[i, j];
                Console.Write(output);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}