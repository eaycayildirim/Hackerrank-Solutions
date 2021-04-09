using System.Collections.Generic;
using System;

class Solution
{
    static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        for (int i = 0; i <= s.Count - m; i++)
        {
            int sum = 0;
            for (int j = i; j < i + m; j++)
            {
                sum += s[j];
            }
            if (sum == d)
                count++;
        }
        return count;
    }
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 1, 3, 2 };

        Console.WriteLine(birthday(list, 3, 2));
    }
}