using System;

class Solution
{
    static void plusMinus(int[] arr)
    {
        double countPositives = 0;
        double countNegatives = 0;
        double countZeros = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                countPositives++;
            else if (arr[i] < 0)
                countNegatives++;
            else
                countZeros++;
        }
        double ratio1 = countPositives / arr.Length;
        double ratio2 = countNegatives / arr.Length;
        double ratio3 = countZeros / arr.Length;
        Console.WriteLine(ratio1.ToString("n6"));
        Console.WriteLine(ratio2.ToString("n6"));
        Console.WriteLine(ratio3.ToString("n6"));
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}