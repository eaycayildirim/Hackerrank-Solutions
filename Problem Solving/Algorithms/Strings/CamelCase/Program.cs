using System;

namespace CamelCase
{
    class Program
    {
        static int camelcase(string s)
        {
            int count = 1;
            foreach (var word in s)
            {
                if ((int)word >= 65 && (int)word <= 90)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            string input = "saveChangesInTheEditor";

            Console.WriteLine(camelcase(input));
        }
    }
}
