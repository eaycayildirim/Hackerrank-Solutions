using System;

namespace MarsExploration
{
    class Program
    {
        static int marsExploration(string s)
        {
            string message = "SOS";
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != message[i % 3])
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            string input = "SOSSPSSQSSOR";

            Console.WriteLine(marsExploration(input));
        }
    }
}
