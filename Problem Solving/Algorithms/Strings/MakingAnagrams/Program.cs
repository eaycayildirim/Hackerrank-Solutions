using System;
using System.Collections.Generic;

namespace MakingAnagrams
{
    class Program
    {
        static int makingAnagrams(string s1, string s2)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (dic.ContainsKey(s1[i]))
                    dic[s1[i]]++;
                else
                    dic.Add(s1[i], 1);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (dic.ContainsKey(s2[i]) && dic[s2[i]] > 0)
                {
                    dic[s2[i]]--;
                    count += 2;
                }
            }
            return s1.Length + s2.Length - count;
        }
        static void Main(string[] args)
        {
            string first_input = "cde";
            string second_input = "abc";

            Console.WriteLine(makingAnagrams(first_input, second_input));
        }
    }
}
