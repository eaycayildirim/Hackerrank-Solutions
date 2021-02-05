using System;

namespace HackerRankInAString
{
    class Program
    {
        static string hackerrankInString(string s)
        {
            string array = "hackerrank";
            int count = 0;
            int matches = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = count; j < s.Length; j++)
                {
                    if (array[i] == s[j])
                    {
                        count++;
                        matches++;
                        break;
                    }
                    count++;
                }
            }
            if (matches == array.Length)
                return "YES";
            else
                return "NO";
        }
        static void Main(string[] args)
        {
            string input = "hereiamstackerrank";

            Console.WriteLine(hackerrankInString(input));
        }
    }
}
