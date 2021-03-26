using System;

namespace HalloweenSale
{
    class Program
    {
        static int howManyGames(int p, int d, int m, int s)
        {
            int count = 0;
            while (!(s < m) && !(s < p))
            {
                if (p - d <= m)
                {
                    s -= m;
                    count++;
                }
                else
                {
                    s -= p;
                    p -= d;
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int price = 20;
            int discount = 3;
            int minimum = 6;
            int startingBudget = 80;

            Console.WriteLine(howManyGames(price, discount, minimum, startingBudget));
        }
    }
}
