using System;

class Solution
{
    static int utopianTree(int n)
    {
        int result = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 1)
                result = result * 2;
            else
                result++;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(utopianTree(4));
    }
}