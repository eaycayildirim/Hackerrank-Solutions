using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static string pangrams(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string newString = s.Replace(" ", "");
            newString = newString.ToLower();
            foreach (var letters in newString)
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
