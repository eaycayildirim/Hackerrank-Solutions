using System;

class Solution
{
    static int[] breakingRecords(int[] scores)
    {
        int highestScore = scores[0];
        int leastScore = scores[0];
        int count1 = 0;
        int count2 = 0;

        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > highestScore)
            {
                highestScore = scores[i];
                count1++;
            }

            else if (scores[i] < leastScore)
            {
                leastScore = scores[i];
                count2++;
            }
        }

        int[] array = new int[2] { count1, count2 };
        return array;
    }

    static void Main(string[] args)
    {
        int[] scores = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

        Console.Write(String.Join(" ", breakingRecords(scores)));
    }
}