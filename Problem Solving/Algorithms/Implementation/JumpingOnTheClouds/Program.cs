using System;

class Solution
{
    static int jumpingOnClouds(int[] clouds)
    {
        int jumps = 0;

        for (int i = 0; i < clouds.Length - 1; i++)
        {
            if (i + 2 < clouds.Length && clouds[i + 2] == 0)
            {
                i++;
                jumps++;
            }
            else
                jumps++;
        }
        return jumps;
    }

    static void Main(string[] args)
    {
        int[] clouds = { 0, 0, 1, 0, 0, 1, 0 };

        Console.WriteLine(jumpingOnClouds(clouds));
    }
}
