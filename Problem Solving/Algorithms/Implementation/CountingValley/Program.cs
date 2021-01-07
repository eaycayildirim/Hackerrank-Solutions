using System;

class Result
{
    public static int countingValleys(int steps, string path)
    {
        int count = 0;
        int valley = 0;
        char[] array = path.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 'U')
            {
                count++;
                if (count == 0)
                    valley++;
            }
            else
                count--;
        }
        return valley;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Result.countingValleys(8, "UDDDUDUU"));
    }
}