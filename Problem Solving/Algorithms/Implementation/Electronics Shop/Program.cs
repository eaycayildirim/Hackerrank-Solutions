using System;

class Solution
{
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int result = -1;
        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int j = 0; j < drives.Length; j++)
            {
                int sumKeyboardAndDrives = keyboards[i] + drives[j];
                if (sumKeyboardAndDrives > result && sumKeyboardAndDrives <= b)
                    result = sumKeyboardAndDrives;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        int[] keyboards = { 3, 1 };
        int[] drives = { 5, 2, 8 };

        Console.WriteLine(getMoneySpent(keyboards, drives, 10));
    }
}
