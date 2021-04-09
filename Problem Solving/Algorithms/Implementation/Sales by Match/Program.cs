using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < ar.Length; i++)
            {
                if (!dic.ContainsKey(ar[i]))
                    dic.Add(ar[i], 1);
                else
                {
                    pairs++;
                    dic.Remove(ar[i]);
                }
            }
            return pairs;
        }
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            Console.WriteLine(sockMerchant(9, array));
        }
    }
}
