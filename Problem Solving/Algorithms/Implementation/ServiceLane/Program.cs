using System;

namespace ServiceLane
{
    class Program
    {
        static int[] serviceLane(int n, int[] width, int[][] cases)
        {
            int[] result = new int[cases.Length];

            for (int i = 0; i < cases.Length; i++)
            {
                int min = 100;
                for (int j = cases[i][0]; j <= cases[i][1]; j++)
                {
                    if (min > width[j])
                        min = width[j];
                }
                result[i] = min;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = 8;
            int[] width = { 2, 3, 1, 2, 3, 2, 3, 3 };
            int[][] cases =
            {
                new int[] { 0, 3 },
                new int[] { 4, 6 },
                new int[] { 6, 7 },
                new int[] { 3, 5 },
                new int[] { 0, 7 }
            };

            Array.ForEach(serviceLane(n, width, cases), Console.WriteLine);
        }
    }
}
