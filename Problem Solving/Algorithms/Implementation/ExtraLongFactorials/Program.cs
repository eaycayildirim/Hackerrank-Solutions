using System;
using System.Numerics;

class Solution
{
    static void extraLongFactorials(int n)
    {
        BigInteger big_integer = new BigInteger(1);
        while (n != 1)
        {
            big_integer *= n;
            n--;
        }
        Console.WriteLine(big_integer);
    }

    static void Main(string[] args)
    {
        extraLongFactorials(25);
    }
}
