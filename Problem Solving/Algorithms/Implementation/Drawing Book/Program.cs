using System;

class Solution
{
    static int pageCount(int n, int p)
    {
        int pageCountFront = 0;
        int pageCountBack = 0;
        for (int i = 0; i < p; i++)
        {
            if (i % 2 == 1 || i == 1)
                pageCountFront++;
        }
        for (int i = n; i > p; i--)
        {
            if (i % 2 == 0)
                pageCountBack++;
        }
        if (pageCountFront < pageCountBack)
            return pageCountFront;
        else
            return pageCountBack;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(pageCount(6, 2));
    }
}