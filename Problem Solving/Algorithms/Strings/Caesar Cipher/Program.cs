using System;

namespace CaesarCipher
{
    class Program
    {
        static string caesarCipher(string s, int k)
        {
            string newstring = "";
            k = k % 26;
            for (int i = 0; i < s.Length; i++)
            {
                int integerString = Convert.ToInt32(s[i]);
                if (integerString >= 65 && integerString <= 90)
                {
                    if (integerString + k > 90)
                    {
                        integerString = (k - Math.Abs(integerString - 90) + 64);
                        newstring += (char)integerString;
                    }
                    else
                        newstring += (char)(integerString + k);
                }
                else if (integerString >= 97 && integerString <= 122)
                {
                    if (integerString + k > 122)
                    {
                        integerString = (k - Math.Abs(integerString - 122) + 96);
                        newstring += (char)integerString;
                    }
                    else
                        newstring += (char)(integerString + k);
                }
                else
                    newstring += s[i];
            }
            return newstring;
        }
        static void Main(string[] args)
        {
            string input = "middle-Outz";

            Console.WriteLine(caesarCipher(input, 2));
        }
    }
}
