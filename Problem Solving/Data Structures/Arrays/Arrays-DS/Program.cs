using System;
using System.Collections.Generic;

namespace Arrays_DS
{
    class Program
    {
        public static List<int> reverseArray(List<int> a)
        {
            List<int> list = new List<int>();
            for (int i = a.Count-1; i >= 0; i--)
            {
                list.Add(a[i]);
            }
            return list;

            //Second Solution
            //a.Reverse();
            //return a;
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 4, 3, 2 };
            List<int> list = reverseArray(a);

            list.ForEach(Console.WriteLine);
        }
    }
}
