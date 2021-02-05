using System;

namespace BeautifulBinaryString
{
    class Program
    {
        static int beautifulBinaryString(string b)
        {
            int count = 0;
            for (int i = 0; i < b.Length - 2; i++)
            {
                if (b[i] == '0' && b[i + 1] == '1' && b[i + 2] == '0')
                {
                    count++;
                    i = i + 2;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string input = "0101010";

            Console.WriteLine(beautifulBinaryString(input));
        }
    }
}
