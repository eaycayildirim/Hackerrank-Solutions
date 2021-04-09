using System;

class Result
{
    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        long bcz = Math.Min(bc, wc + z);
        long wcz = Math.Min(wc, bc + z);
        long result = b * bcz + w * wcz;

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Result.taumBday(3, 6, 9, 1, 1));
    }
}