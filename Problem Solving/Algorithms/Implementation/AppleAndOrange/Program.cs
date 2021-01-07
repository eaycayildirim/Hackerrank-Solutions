using System;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int number_apples = 0;
        int number_oranges = 0;

        for (int i = 0; i < apples.Length; i++)
        {
            if ((a + apples[i]) >= s && (a + apples[i]) <= t)
                number_apples++;

        }
        for (int i = 0; i < oranges.Length; i++)
        {
            if ((b + oranges[i]) >= s && (b + oranges[i]) <= t)
                number_oranges++;
        }
        Console.WriteLine(number_apples + "\n" + number_oranges);
    }

    static void Main(string[] args)
    {
        int[] apples = { -2, 2, 1 };
        int[] oranges = { 5, -6 };

        countApplesAndOranges(7, 11, 5, 15, apples, oranges);
    }
}
