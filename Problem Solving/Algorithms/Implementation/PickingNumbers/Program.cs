using System;
using System.Collections.Generic;

namespace PickingNumbers
{
    class Program
    {
        public static int pickingNumbers(List<int> a)
        {
            int count_numbers = 0;
            int numbers = 0;
            for (int i = 0; i < a.Count; i++)
            {
                numbers = 0;
                for (int j = 0; j < a.Count; j++)
                {
                    if (a[i] - a[j] == 0 || a[i] - a[j] == 1)
                    {
                        numbers++;
                    }
                }
                if (numbers > count_numbers)
                    count_numbers = numbers;
            }
            return count_numbers;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 2, 3, 1, 2 };

            Console.WriteLine(pickingNumbers(list));
        }
    }
}
