using System;

namespace TwoStrings
{
    class Program
    {
        static string twoStrings(string s1, string s2)
        {
            for (char i = 'a'; i < 'z'; i++)
            {
                if (s1.Contains(i) && s2.Contains(i))
                    return "YES";
            }
            return "NO";
        }
        static void Main(string[] args)
        {
            string first_input = "hello";
            string second_input = "world";

            Console.WriteLine(twoStrings(first_input, second_input));
        }
    }
}
