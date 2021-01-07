using System.Collections.Generic;
using System;

class Solution
{
    static void bonAppetit(List<int> bill, int k, int b)
    {
        int total_bill = 0;
        for (int i = 0; i < bill.Count; i++)
        {
            if (i == k)
                continue;
            total_bill += bill[i];

        }
        if (b == total_bill / 2)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(b - (total_bill / 2));
    }

    static void Main(string[] args)
    {
        List<int> bill = new List<int>() { 3, 10, 2, 9 };

        bonAppetit(bill, 1, 12);
    }
}