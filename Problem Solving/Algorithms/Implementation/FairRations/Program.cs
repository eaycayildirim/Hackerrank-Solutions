using System;

namespace FairRations
{
    class Program
    {
        static string fairRations(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[i] += 1;
                    count++;
                    arr[i + 1] += 1;
                    count++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    return "NO";
                }
            }
            return count.ToString();
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 5, 6 };

            Console.WriteLine(fairRations(array));
        }
    }
}
