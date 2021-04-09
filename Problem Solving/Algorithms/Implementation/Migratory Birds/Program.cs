using System;
using System.Collections.Generic;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdsDictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (birdsDictionary.ContainsKey(arr[i]))
                    birdsDictionary[arr[i]]++;
                else
                    birdsDictionary.Add(arr[i], 1);
            }

            KeyValuePair<int, int> max = new KeyValuePair<int, int>();
            foreach (var kvp in birdsDictionary)
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
