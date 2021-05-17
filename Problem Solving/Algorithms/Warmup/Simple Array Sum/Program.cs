using System;
using System.IO;

class Solution
{
    static int simpleArraySum(int[] ar)
    {
        int sum = 0;
        for (int i = 0; i < ar.Length; i++)
            sum += ar[i];
        return sum;
    }

    static void Main(string[] args)
    {

        int[] ar = { 1, 2, 3, 4, 10, 11 };
        Console.WriteLine(simpleArraySum(ar));
    }
}
