using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManupulation
{
    class Program
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] array = new long[n];

            for (int i = 0; i < queries.Count; i++)
            {
                for (int j = queries[i][0] - 1; j < queries[i][1]; j++)
                {
                    array[j] += queries[i][2];
                }
            }
            long maxValue = array.Max();

            return maxValue;
        }

        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            Console.WriteLine(arrayManipulation(n, queries));
        }
    }
}
