using System;

class Solution
{
    static int saveThePrisoner(int n, int m, int s)
    {
        if ((m + s - 1) % n == 0)
            return n;
        else
            return (m + s - 1) % n;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(saveThePrisoner(5, 2, 1));
    }
}