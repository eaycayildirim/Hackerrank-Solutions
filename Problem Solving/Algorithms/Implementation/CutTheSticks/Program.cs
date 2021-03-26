using System.Collections.Generic;
using System;

class Solution
{
    public static int[] cutTheSticks(int[] arr)
    {
        SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
        List<int> cuttedSticks = new List<int>();

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
            cuttedSticks.Add(number);
            number -= items.Value;
        }

        return cuttedSticks.ToArray();
    }

    static void Main(string[] args)
    {
        int[] array = { 5, 4, 4, 2, 2, 8 };

        Array.ForEach(cutTheSticks(array), Console.WriteLine);
    }
}