using System.Collections.Generic;
using System;

class Solution
{
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int[] array = new int[2];
        List<int> points = new List<int>(array);

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
                points[0]++;

            else if (b[i] > a[i])
                points[1]++;
        }
        return points;
    }

    static void Main(string[] args)
    {
        List<int> a = new List<int>() { 5, 6, 7 };

        List<int> b = new List<int>() { 3, 6, 10 };

        compareTriplets(a, b).ForEach(i => Console.Write("{0} ", i));
    }
}
