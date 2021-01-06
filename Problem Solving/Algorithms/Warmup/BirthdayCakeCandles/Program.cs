using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}