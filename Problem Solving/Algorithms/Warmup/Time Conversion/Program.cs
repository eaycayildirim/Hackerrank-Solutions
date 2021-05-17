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
        string s = "07:05:45PM";

        Console.WriteLine(timeConversion(s));
    }
}