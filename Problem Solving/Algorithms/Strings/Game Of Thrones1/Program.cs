using System;
using System.Collections.Generic;

namespace GameOfThrones1
{
    class Program
    {
        static string gameOfThrones(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int odds = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                    dic[s[i]]++;
                else
                    dic.Add(s[i], 1);
            }
            foreach (var values in dic.Values)
            {
                if (values % 2 == 1)
                    odds++;
            }
            if ((s.Length % 2 == 0 && odds == 0) || ((s.Length % 2 != 0 && odds == 1)))
                return "YES";
            else
                return "NO";
        }
        static void Main(string[] args)
        {
            string input = "aaabbbb";

            Console.WriteLine(gameOfThrones(input));
        }
    }
}
