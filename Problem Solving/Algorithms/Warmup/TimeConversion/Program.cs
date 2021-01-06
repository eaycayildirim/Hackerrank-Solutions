using System;
using System.IO;

class Solution
{
    static string timeConversion(string s)
    {
        string[] array = s.Split(':');
        int hour = 0;

        if (s.Contains("AM"))
        {
            hour = Convert.ToInt32(array[0]);
            if (hour == 12)
                hour = 0;
        }
        if (s.Contains("PM"))
        {
            hour = Convert.ToInt32(array[0]);
            hour += 12;
            if (hour >= 24)
                hour = 12;
        }
        string newTime = hour.ToString("d2") + ":" + array[1] + ":" + array[2];
        string a = newTime.Remove(8);

        return a;
    }
    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}