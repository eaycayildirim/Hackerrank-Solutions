using System;

namespace SuperReducedString
{
    class Program
    {
        static string superReducedString(string s)
        {
            string newString = s;
            for (int i = 0; i < newString.Length - 1; i++)
            {
                if (newString[i] == newString[i + 1])
                {
                    newString = newString.Remove(i, 2);
                    i = -1;
                }
            }
            if (newString.Length == 0)
                return "Empty String";
            else
                return newString;
        }
        static void Main(string[] args)
        {
            string input = "aaabccddd";

            Console.WriteLine(superReducedString(input));
        }
    }
}
