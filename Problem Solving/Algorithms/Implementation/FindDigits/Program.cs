using System;

class Solution
{
    static int findDigits(int n)
    {
        string number = n.ToString();
        char[] char_array = number.ToCharArray();
        int count = 0;
        for (int i = 0; i < char_array.Length; i++)
        {
            int digit = Convert.ToInt32(char_array[i].ToString());
            if (digit != 0 && n % digit == 0)
                count++;
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(findDigits(12));
    }
}
