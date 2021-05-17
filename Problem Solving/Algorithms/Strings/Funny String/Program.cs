using System;

namespace FunnyString
{
    class Program
    {
        static string funnyString(string s)
        {
            int[] differences = new int[s.Length - 1];
            int[] revDifferences = new int[s.Length - 1];
            char[] revString = s.ToCharArray();
            Array.Reverse(revString);

            for (int i = 0; i < s.Length - 1; i++)
            {
                differences[i] = Math.Abs((char)s[i] - (char)s[i + 1]);
                revDifferences[i] = Math.Abs((char)revString[i] - (char)revString[i + 1]);
            }
            for (int i = 0; i < differences.Length; i++)
            {
                if (differences[i] == revDifferences[i])
                    continue;
                else
                    return "Not Funny";
            }
            return "Funny";
        }
        static void Main(string[] args)
        {
            string input = "bcxz";

            Console.WriteLine(funnyString(input));
        }
    }
}
