using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static int anagram(string s)
        {
            int count = 0;
            if (s.Length % 2 == 0)
            {
                string first_part = s.Substring(0, s.Length / 2);
                string second_part = s.Substring(s.Length / 2, s.Length / 2);
                Dictionary<char, int> dic = new Dictionary<char, int>();
                for (int i = 0; i < second_part.Length; i++)
                {
                    if (dic.ContainsKey(second_part[i]))
                        dic[second_part[i]]++;
                    else
                        dic.Add(second_part[i], 1);
                }
                for (int i = 0; i < first_part.Length; i++)
                {
                    if (dic.ContainsKey(first_part[i]) && dic[first_part[i]] > 0)
                    {
                        dic[first_part[i]]--;
                    }
                    else
                        count++;
                }
                return count;
            }
            else
                return -1;
        }
        static void Main(string[] args)
        {
            string input = "aaabbb";

            Console.WriteLine(anagram(input));
        }
    }
}
