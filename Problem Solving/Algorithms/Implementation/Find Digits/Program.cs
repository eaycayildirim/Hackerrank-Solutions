using System;

class Solution
{
    static int findDigits(int n)
    {
        string number = n.ToString();
        char[] charArray = number.ToCharArray();
        int count = 0;
        for (int i = 0; i < charArray.Length; i++)
        {
            int digit = Convert.ToInt32(charArray[i].ToString());
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
