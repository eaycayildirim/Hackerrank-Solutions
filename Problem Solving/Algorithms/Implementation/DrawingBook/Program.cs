using System;

class Solution
{
    static int pageCount(int n, int p)
    {
        int page_count_front = 0;
        int page_count_back = 0;
        for (int i = 0; i < p; i++)
        {
            if (i % 2 == 1 || i == 1)
                page_count_front++;
        }
        for (int i = n; i > p; i--)
        {
            if (i % 2 == 0)
                page_count_back++;
        }
        if (page_count_front < page_count_back)
            return page_count_front;
        else
            return page_count_back;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(pageCount(6, 2));
    }
}