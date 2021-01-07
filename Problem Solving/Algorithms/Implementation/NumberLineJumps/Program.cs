using System;

class Solution
{
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        string result;
        if (x2 > x1 && v1 <= v2)
            result = "NO";
        else if ((x1 - x2) % (v2 - v1) != 0)
            result = "NO";
        else
            result = "YES";

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(kangaroo(0, 3, 4, 2));
    }
}