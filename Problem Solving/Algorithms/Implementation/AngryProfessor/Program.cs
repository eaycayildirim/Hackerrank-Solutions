using System;

class Solution
{
    static string angryProfessor(int k, int[] a)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] <= 0)
                count++;
        }
        if (count < k)
            return "YES";
        else
            return "NO";
    }

    static void Main(string[] args)
    {
        int[] a = { -1, -3, 4, 2 };

        Console.WriteLine(angryProfessor(3, a));
    }
}