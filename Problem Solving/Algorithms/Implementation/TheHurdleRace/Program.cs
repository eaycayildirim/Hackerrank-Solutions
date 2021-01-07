using System;

class Solution
{
    static int hurdleRace(int k, int[] height)
    {
        int biggest_height = 0;
        int result = 0;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > biggest_height)
                biggest_height = height[i];
        }
        result = biggest_height - k;
        if (k > biggest_height)
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
