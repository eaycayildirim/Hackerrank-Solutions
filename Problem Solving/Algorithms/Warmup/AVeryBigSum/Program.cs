using System;

class Solution
{
    static long aVeryBigSum(long[] ar)
    {
        long sum = 0;
        for (int i = 0; i < ar.Length; i++)
            sum += ar[i];
        return sum;
    }

    static void Main(string[] args)
    {
        long[] array = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

        Console.WriteLine(aVeryBigSum(array));
       
    }
}
