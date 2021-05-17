using System;
using System.Collections.Generic;

namespace WeightedUniformStrings
{
    class Program
    {
        public static string[] weightedUniformStrings(string s, int[] queries)
        {
            List<string> list = new List<string>();
            int count = 1;
            HashSet<int> set = new HashSet<int>();
            set.Add((int)s[0] - 96);

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    count++;
                    set.Add(((int)s[i] - 96) * count);
                }
                else
                {
                    set.Add((int)s[i] - 96);
                    count = 1;
                }
            }

            for (int i = 0; i < queries.Length; i++)
            {
                if (set.Contains(queries[i]))
                    list.Add("Yes");
                else
                    list.Add("No");
            }
            return list.ToArray();
        }

        static void Main(string[] args)
        {
            string s = "abccddde";

            int[] queries = { 1, 3, 12, 5, 9, 10 };

            Array.ForEach(Program.weightedUniformStrings(s, queries), Console.WriteLine);
        }
    }
}
