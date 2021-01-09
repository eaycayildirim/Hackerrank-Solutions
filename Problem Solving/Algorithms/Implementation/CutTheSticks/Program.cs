using System.Collections.Generic;
using System;

class Solution
{
    public static int[] cutTheSticks(int[] arr)
    {
        SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
        List<int> sticks_cut = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (dictionary.ContainsKey(arr[i]))
            {
                dictionary[arr[i]]++;
            }
            else
            {
                dictionary.Add(arr[i], 1);
            }
        }
        int number = arr.Length;

        foreach (var items in dictionary)
        {
            sticks_cut.Add(number);
            number -= items.Value;
        }

        return sticks_cut.ToArray();
    }

    static void Main(string[] args)
    {
        int[] arr = { 5, 4, 4, 2, 2, 8 };

        Array.ForEach(cutTheSticks(arr), Console.WriteLine);
    }
}