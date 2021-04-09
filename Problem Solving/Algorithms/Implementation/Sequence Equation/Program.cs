using System;

namespace SequenceEquation
{
    class Program
    {
        static int[] permutationEquation(int[] p)
        {
            int[] result = new int[p.Length];

            for (int i = 0; i < p.Length; i++)
            {
                result[p[p[i] - 1] - 1] = i + 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 1 };

            Array.ForEach(permutationEquation(array), Console.WriteLine);
        }
    }
}
