using System;
using System.Collections.Generic;

namespace Sparse_Arrays
{
    class Program
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < queries.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < strings.Count; j++)
                {
                    if (queries[i] == strings[j])
                        count++;
                }
                list.Add(count);
            }
            return list;
        }

        static void Main(string[] args)
        {
            List<string> strings = new List<string>{ "aba", "baba", "aba", "xzxb" };
            List<string> queries = new List<string> { "aba", "xzxb" , "ab" };

            List<int> list = matchingStrings(strings, queries);
            list.ForEach(Console.WriteLine);
        }
    }
}
