using System;

class Solution
{
    static int jumpingOnClouds(int[] c, int k)
    {
        int energy = 100;
        int index = 0;
        do
        {
            if (c[(index + k) % c.Length] == 1)
                energy -= 2;
            energy--;
            index += k;
            if (index >= c.Length)
                index = index % c.Length;

        } while (index != 0);

        return energy;
    }

    static void Main(string[] args)
    {
        int[] array = { 0, 0, 1, 0, 0, 1, 1, 0 };

        Console.WriteLine(jumpingOnClouds(array, 2));
    }
}
