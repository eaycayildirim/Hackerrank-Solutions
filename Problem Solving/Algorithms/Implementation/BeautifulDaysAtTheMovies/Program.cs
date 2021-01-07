using System;

class Solution
{
    static int beautifulDays(int i, int j, int k)
    {
        int count = 0;
        for (int m = i; m <= j; m++)
        {
            int left = m;
            int reverse = 0;
            while (Convert.ToBoolean(left))
            {
                int r = left % 10;
                reverse = reverse * 10 + r;
                left = left / 10;
            }
            if ((Math.Abs(m - reverse)) % k == 0)
                count++;
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(beautifulDays(20, 23, 6));
    }
}