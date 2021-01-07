using System;

class Solution
{
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int count = 0;

        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = 1; j < ar.Length; j++)
            {
                if (i < j && (ar[i] + ar[j]) % k == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 3, 2, 6, 1, 2 };

        Console.WriteLine(divisibleSumPairs(6, 3, array));
    }
}