using System;

namespace TheLoveLetterMystery
{
    class Program
    {
        static int theLoveLetterMystery(string s)
        {
            int count = 0;
            char[] rev_array = s.ToCharArray();
            Array.Reverse(rev_array);
            for (int i = 0; i < s.Length / 2; i++)
            {
                int number = Math.Abs(s[i] - rev_array[i]);
                for (int j = 0; j < number; j++)
                {
                    if (s[i] == rev_array[i])
                        continue;
                    else
                    {
                        if (s[i] < rev_array[i])
                        {
                            rev_array[i]--;
                            count++;
                        }
                        else
                        {
                            rev_array[i]++;
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string input = "abcd";

            Console.WriteLine(theLoveLetterMystery(input));
        }
    }
}
