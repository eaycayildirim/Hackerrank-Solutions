using System.IO;
using System;

class Solution
{
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int count = 0;

        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = 1; j < ar.Length; j++)
            {
                if (i < j && (ar[i] + ar[j]) % k == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}