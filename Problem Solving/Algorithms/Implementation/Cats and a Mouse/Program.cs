using System;

class Solution
{
    static string catAndMouse(int x, int y, int z)
    {
        int distanceForCatA = Math.Abs(z - x);
        int distanceForCatB = Math.Abs(z - y);

        if (distanceForCatA > distanceForCatB)
            return "Cat B";

        else if (distanceForCatA < distanceForCatB)
            return "Cat A";

        else
            return "Mouse C";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(catAndMouse(1, 2, 3));
    }
}