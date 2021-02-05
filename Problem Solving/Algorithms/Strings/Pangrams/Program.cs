using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static string pangrams(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string new_string = s.Replace(" ", "");
            new_string = new_string.ToLower();
            foreach (var letters in new_string)
            {
                if (dic.ContainsKey(letters))
                    continue;
                else
                    dic.Add(letters, 1);
            }
            if (dic.Count == 26)
                return "pangram";
            else
                return "not pangram";
        }
        static void Main(string[] args)
        {
            string input = "We promptly judged antique ivory buckles for the prize";

            Console.WriteLine(pangrams(input));
        }
    }
}
