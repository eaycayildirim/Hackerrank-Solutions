using System;

namespace PalindromeIndex
{
    class Program
    {
        static int palindromeIndex(string s)
        {
            string new_string = s;
            char[] reverse = new_string.ToCharArray();
            Array.Reverse(reverse);
            int index = -1;
            int count = 0;

            for (int i = 0; i < new_string.Length; i++)
            {
                if (new_string[i] != reverse[i] && count <= 1)
                {
                    new_string = s.Remove(i, 1);
                    reverse = new_string.ToCharArray();
                    Array.Reverse(reverse);
                    index = i;
                    i = -1;
                    count++;
                }
                else if (new_string[i] != reverse[i] && count > 1)
                {
                    index = s.Length - 1 - i;
                    break;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            string input = "aaab";

            Console.WriteLine(palindromeIndex(input));
        }
    }
}
