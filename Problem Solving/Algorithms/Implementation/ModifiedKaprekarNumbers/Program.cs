using System;
using System.Collections.Generic;

namespace ModifiedKaprekarNumbers
{
    class Program
    {
        static void kaprekarNumbers(int p, int q)
        {
            List<long> kaprekarNumbers = new List<long>();
            for (long i = p; i < q + 1; i++)
            {
                long square = i * i;
                int digits = (int)Math.Floor(Math.Log10(i) + 1);

                double rightNumber = square % Math.Pow(10, digits);
                double leftNumber = square / Math.Pow(10, digits);

                if ((int)(leftNumber + rightNumber) == i)
                    kaprekarNumbers.Add(i);
            }

            Console.WriteLine(kaprekarNumbers.Count > 0 ? string.Join(" ", kaprekarNumbers) : "INVALID RANGE");
        }
        static void Main(string[] args)
        {
            kaprekarNumbers(1, 100);
        }
    }
}
