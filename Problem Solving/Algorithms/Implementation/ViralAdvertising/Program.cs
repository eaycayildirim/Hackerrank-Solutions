using System;

class Solution
{
    static int viralAdvertising(int n)
    {
        int people = 5;
        int cumulativeLikes = 0;

        for (int i = 0; i < n; i++)
        {
            int likes = people / 2;
            people = likes * 3;
            cumulativeLikes += likes;
        }
        return cumulativeLikes;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(viralAdvertising(3));
    }
}