using System;

namespace AlternatingCharacters
{
    class Program
    {
        static int alternatingCharacters(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            string input = "AAAA";

            Console.WriteLine(alternatingCharacters(input));
        }
    }
}
