using System.Collections.Generic;
using System;

class Solution
{
    static void bonAppetit(List<int> bill, int k, int b)
    {
        int totalBill = 0;
        for (int i = 0; i < bill.Count; i++)
        {
            if (i == k)
                continue;
            totalBill += bill[i];

        }
        if (b == totalBill / 2)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(b - (totalBill / 2));
    }

    static void Main(string[] args)
    {
        List<int> bill = new List<int>() { 3, 10, 2, 9 };

        bonAppetit(bill, 1, 12);
    }
}