using System;

class Solution
{
    static int hurdleRace(int k, int[] height)
    {
        int biggestHeight = 0;
        int result = 0;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > biggestHeight)
                biggestHeight = height[i];
        }
        result = biggestHeight - k;
        if (k > biggestHeight)
            return 0;
        else
            return result;
    }
    static void Main(string[] args)
    {
        int[] height = { 1, 6, 3, 5, 2 };

        Console.WriteLine(hurdleRace(4, height));
    }
}
