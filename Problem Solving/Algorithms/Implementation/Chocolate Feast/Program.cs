using System;

class Solution
{
    static int chocolateFeast(int n, int c, int m)
    {
        int chocolate = n / c;
        int wrappers = chocolate;

        while (wrappers >= m)
        {
            chocolate += wrappers / m;
            wrappers = wrappers % m + wrappers / m;
        }
        return chocolate;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(chocolateFeast(10, 2, 5));
    }
}