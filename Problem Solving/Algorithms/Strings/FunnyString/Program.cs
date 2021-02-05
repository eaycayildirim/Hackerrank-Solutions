using System;

namespace FunnyString
{
    class Program
    {
        static string funnyString(string s)
        {
            int[] differences = new int[s.Length - 1];
            int[] rev_differences = new int[s.Length - 1];
            char[] rev_string = s.ToCharArray();
            Array.Reverse(rev_string);

            for (int i = 0; i < s.Length - 1; i++)
            {
                differences[i] = Math.Abs((char)s[i] - (char)s[i + 1]);
                rev_differences[i] = Math.Abs((char)rev_string[i] - (char)rev_string[i + 1]);
            }
            for (int i = 0; i < differences.Length; i++)
            {
                if (differences[i] == rev_differences[i])
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
