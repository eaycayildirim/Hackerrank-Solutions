using System;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int numberOfApples = 0;
        int numberOfOranges = 0;

        for (int i = 0; i < apples.Length; i++)
        {
            if ((a + apples[i]) >= s && (a + apples[i]) <= t)
                numberOfApples++;

        }
        for (int i = 0; i < oranges.Length; i++)
        {
            if ((b + oranges[i]) >= s && (b + oranges[i]) <= t)
                numberOfOranges++;
        }
        Console.WriteLine(numberOfApples + "\n" + numberOfOranges);
    }

    static void Main(string[] args)
    {
        int[] apples = { -2, 2, 1 };
        int[] oranges = { 5, -6 };

        countApplesAndOranges(7, 11, 5, 15, apples, oranges);
    }
}
