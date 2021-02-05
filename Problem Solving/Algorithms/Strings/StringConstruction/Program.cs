using System;
using System.Collections.Generic;

namespace StringConstruction
{
    class Program
    {
        static int stringConstruction(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                    continue;
                else
                    dic.Add(s[i], 1);
            }
            return dic.Count;
        }
        static void Main(string[] args)
        {
            string input = "abcd";

            Console.WriteLine(stringConstruction(input));
        }
    }
}
