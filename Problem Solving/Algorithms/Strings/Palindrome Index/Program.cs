using System;

namespace PalindromeIndex
{
    class Program
    {
        static int palindromeIndex(string s)
        {
            string newString = s;
            char[] reverse = newString.ToCharArray();
            Array.Reverse(reverse);
            int index = -1;
            int count = 0;

            for (int i = 0; i < newString.Length; i++)
            {
                if (newString[i] != reverse[i] && count <= 1)
                {
                    newString = s.Remove(i, 1);
                    reverse = newString.ToCharArray();
                    Array.Reverse(reverse);
                    index = i;
                    i = -1;
                    count++;
                }
                else if (newString[i] != reverse[i] && count > 1)
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
