using System;

namespace StrangeCounter
{
    class Program
    {
        static long strangeCounter(long t)
        {
            long count = 4;

            while (count <= t)
            {
                count = count * 2 + 2;
            }
            return count - t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(strangeCounter(4));
        }
    }
}
