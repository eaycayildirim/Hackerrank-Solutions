using System;

namespace CaesarCipher
{
    class Program
    {
        static string caesarCipher(string s, int k)
        {
            string new_string = "";
            k = k % 26;
            for (int i = 0; i < s.Length; i++)
            {
                int integer_string = Convert.ToInt32(s[i]);
                if (integer_string >= 65 && integer_string <= 90)
                {
                    if (integer_string + k > 90)
                    {
                        integer_string = (k - Math.Abs(integer_string - 90) + 64);
                        new_string += (char)integer_string;
                    }
                    else
                        new_string += (char)(integer_string + k);
                }
                else if (integer_string >= 97 && integer_string <= 122)
                {
                    if (integer_string + k > 122)
                    {
                        integer_string = (k - Math.Abs(integer_string - 122) + 96);
                        new_string += (char)integer_string;
                    }
                    else
                        new_string += (char)(integer_string + k);
                }
                else
                    new_string += s[i];
            }
            return new_string;
        }
        static void Main(string[] args)
        {
            string input = "middle-Outz";

            Console.WriteLine(caesarCipher(input, 2));
        }
    }
}
