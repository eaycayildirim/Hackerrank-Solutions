using System;

namespace CircularArrayRotation
{
    class Program
    {
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] new_array = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                new_array[(i + k) % a.Length] = a[i];
            }

            for (int i = 0; i < queries.Length; i++)
            {
                queries[i] = new_array[queries[i]];
            }
            return queries;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            int count = 2;
            int[] queries = { 0, 1, 2 };

            Array.ForEach(circularArrayRotation(array, count, queries), Console.WriteLine);
        }
    }
}
