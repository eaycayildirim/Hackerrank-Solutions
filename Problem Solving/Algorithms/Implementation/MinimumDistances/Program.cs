using System;

class Solution
{
    static int minimumDistances(int[] a)
    {
        int result = a.Length;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    if (result > Math.Abs(j - i))
                        result = Math.Abs(j - i);
                }
            }
        }
        if (result == a.Length)
            return -1;
        else
            return result;
    }

    static void Main(string[] args)
    {
        int[] array = { 7, 1, 3, 4, 1, 7 };

        Console.WriteLine(minimumDistances(array));
    }
}