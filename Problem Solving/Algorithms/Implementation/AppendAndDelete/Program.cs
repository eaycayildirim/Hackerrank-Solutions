using System;

namespace AppendAndDelete
{
    class Program
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int index = -1;
            int range = Math.Min(s.Length, t.Length);
            for (int i = 0; i < range; i++)
            {
                if (s[i] == t[i])
                    continue;
                else
                {
                    index = i;
                    break;
                }
            }
            int count;
            if (index == -1)
                count = Math.Abs(s.Length - t.Length);
            else
                count = (s.Length - index) + (t.Length - index);

            if (count % 2 == k % 2 && count <= k)
                return "Yes";
            else if (k == count || k >= s.Length + t.Length)
                return "Yes";
            else
                return "No";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(appendAndDelete("hackerhappy", "hackerrank", 9));
        }
    }
}
