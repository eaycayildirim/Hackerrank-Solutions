using System;
using System.Collections.Generic;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birds_dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (birds_dictionary.ContainsKey(arr[i]))
                    birds_dictionary[arr[i]]++;
                else
                    birds_dictionary.Add(arr[i], 1);
            }

            KeyValuePair<int, int> max = new KeyValuePair<int, int>();
            foreach (var kvp in birds_dictionary)
            {
                if (kvp.Value > max.Value)
                    max = kvp;
                else if (kvp.Value == max.Value)
                {
                    if (max.Key > kvp.Key)
                        max = kvp;
                }
            }
            return max.Key;

        }
        static void Main(string[] args)
        {
            List<int> birds = new List<int>() { 1, 4, 4, 4, 5, 3 };

            Console.WriteLine(migratoryBirds(birds));
        }
    }
}
