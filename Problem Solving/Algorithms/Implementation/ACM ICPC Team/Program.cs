using System;

namespace ACMICPCTeam
{
    class Program
    {
        static int[] acmTeam(string[] topic)
        {
            int max = int.MinValue;
            int count = 1;

            for (int i = 0; i < topic.Length; i++)
            {
                for (int j = i + 1; j < topic.Length; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < topic[i].Length; k++)
                    {
                        if (topic[i][k] == '1' || topic[j][k] == '1')
                            temp++;
                    }
                    if (max < temp)
                    {
                        max = temp;
                        count = 1;
                    }
                    else if (temp == max)
                        count++;
                }
            }
            return new int[] { max, count };
        }
        static void Main(string[] args)
        {
            string[] topic = { "10101", "11110", "00010" };

            Array.ForEach(acmTeam(topic), Console.WriteLine);
        }
    }
}
