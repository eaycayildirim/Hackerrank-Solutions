using System.Collections.Generic;
using System;

class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int maximum = candles[0];
        int count = 0;
        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] > maximum)
                maximum = candles[i];
        }
        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] == maximum)
                count++;
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> candles = new List<int>() { 3, 2, 1, 3 };

        Console.WriteLine(Result.birthdayCakeCandles(candles));
    }
}