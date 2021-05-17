using System;

namespace TheLoveLetterMystery
{
    class Program
    {
        static int theLoveLetterMystery(string s)
        {
            int count = 0;
            char[] revArray = s.ToCharArray();
            Array.Reverse(revArray);
            for (int i = 0; i < s.Length / 2; i++)
            {
                int number = Math.Abs(s[i] - revArray[i]);
                for (int j = 0; j < number; j++)
                {
                    if (s[i] == revArray[i])
                        continue;
                    else
                    {
                        if (s[i] < revArray[i])
                        {
                            revArray[i]--;
                            count++;
                        }
                        else
                        {
                            revArray[i]++;
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
