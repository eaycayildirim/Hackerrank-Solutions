using System;

class Solution
{
    static void miniMaxSum(int[] arr)
    {
        long maximum = arr[0];
        long minimum = arr[0];
        long total_array = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maximum)
                maximum = arr[i];
            if (arr[i] < minimum)
                minimum = arr[i];

            total_array += arr[i];
        }

        Console.WriteLine((total_array - maximum) + " " + (total_array - minimum));
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        miniMaxSum(arr);
    }
}