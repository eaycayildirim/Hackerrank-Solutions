using System;

namespace SuperReducedString
{
    class Program
    {
        static string superReducedString(string s)
        {
            string new_string = s;
            for (int i = 0; i < new_string.Length - 1; i++)
            {
                if (new_string[i] == new_string[i + 1])
                {
                    new_string = new_string.Remove(i, 2);
                    i = -1;
                }
            }
            if (new_string.Length == 0)
                return "Empty String";
            else
                return new_string;
        }
        static void Main(string[] args)
        {
            string input = "aaabccddd";

            Console.WriteLine(superReducedString(input));
        }
    }
}
