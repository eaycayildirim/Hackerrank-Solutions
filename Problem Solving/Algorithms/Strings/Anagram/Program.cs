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
                string firstPart = s.Substring(0, s.Length / 2);
                string secondPart = s.Substring(s.Length / 2, s.Length / 2);
                Dictionary<char, int> dic = new Dictionary<char, int>();
                for (int i = 0; i < secondPart.Length; i++)
                {
                    if (dic.ContainsKey(secondPart[i]))
                        dic[secondPart[i]]++;
                    else
                        dic.Add(secondPart[i], 1);
                }
                for (int i = 0; i < firstPart.Length; i++)
                {
                    if (dic.ContainsKey(firstPart[i]) && dic[firstPart[i]] > 0)
                    {
                        dic[firstPart[i]]--;
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
