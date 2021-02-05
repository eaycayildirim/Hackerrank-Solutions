using System;

namespace Gemstones
{
    class Program
    {
        static int gemstones(string[] arr)
        {
            int number = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Contains(i))
                        count++;
                }
                if (count == arr.Length)
                    number++;
            }
            return number;
        }
        static void Main(string[] args)
        {
            string[] array = { "abcdde", "baccd", "eeabg" };

            Console.WriteLine(gemstones(array));
        }
    }
}
