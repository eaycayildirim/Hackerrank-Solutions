using System.Collections.Generic;
using System;

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int principalDiagonal = 0;
        int reverseDiagonal = 0;
        for (int i = 0; i < arr.Count; i++)
            principalDiagonal += arr[i][i];

        for (int i = 0; i < arr.Count; i++)
            reverseDiagonal += arr[i][arr.Count - 1 - i];

        return Math.Abs(principalDiagonal - reverseDiagonal);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> list = new List<List<int>>() { new List<int> { 11, 2, 4 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 8, -12 } } ;

        Console.WriteLine(Result.diagonalDifference(list));
    }
}