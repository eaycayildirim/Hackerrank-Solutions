using System;
using System.Collections.Generic;

namespace ModifiedKaprekarNumbers
{
    class Program
    {
        static void kaprekarNumbers(int p, int q)
        {
            List<long> kaprekar_numbers = new List<long>();
            for (long i = p; i < q + 1; i++)
            {
                long square = i * i;
                int digits = (int)Math.Floor(Math.Log10(i) + 1);

                double right_number = square % Math.Pow(10, digits);
                double left_number = square / Math.Pow(10, digits);

                if ((int)(left_number + right_number) == i)
                    kaprekar_numbers.Add(i);
            }

            Console.WriteLine(kaprekar_numbers.Count > 0 ? string.Join(" ", kaprekar_numbers) : "INVALID RANGE");
        }
        static void Main(string[] args)
        {
            kaprekarNumbers(1, 100);
        }
    }
}
