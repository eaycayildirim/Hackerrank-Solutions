using System;

class Solution
{
    static void miniMaxSum(int[] arr)
    {
        long maximum = arr[0];
        long minimum = arr[0];
        long totalArray = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maximum)
                maximum = arr[i];
            if (arr[i] < minimum)
                minimum = arr[i];

            totalArray += arr[i];
        }

        Console.WriteLine((totalArray - maximum) + " " + (totalArray - minimum));
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        miniMaxSum(arr);
    }
}