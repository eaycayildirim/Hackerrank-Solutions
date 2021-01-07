using System;

class Solution
{
    static string catAndMouse(int x, int y, int z)
    {
        int cat_a_distance = Math.Abs(z - x);
        int cat_b_distance = Math.Abs(z - y);

        if (cat_a_distance > cat_b_distance)
            return "Cat B";

        else if (cat_a_distance < cat_b_distance)
            return "Cat A";

        else
            return "Mouse C";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(catAndMouse(1, 2, 3));
    }
}