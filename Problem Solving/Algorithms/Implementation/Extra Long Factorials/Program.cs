using System;
using System.Numerics;

class Solution
{
    static void extraLongFactorials(int n)
    {
        BigInteger bigInteger = new BigInteger(1);
        while (n != 1)
        {
            bigInteger *= n;
            n--;
        }
        Console.WriteLine(bigInteger);
    }

    static void Main(string[] args)
    {
        extraLongFactorials(25);
    }
}
