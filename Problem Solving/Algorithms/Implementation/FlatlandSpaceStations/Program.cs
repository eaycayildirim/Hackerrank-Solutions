using System;

class Solution
{
    static int flatlandSpaceStations(int n, int[] c)
    {
        int minDistanceWithFirstCity = n;
        int minDistanceWithLastCity = n;
        int maxDistanceBetweenStations = -1;

        Array.Sort(c);

        for (int i = 0; i < c.Length; i++)
        {
            if (Math.Abs(c[i] - 0) < minDistanceWithFirstCity)
            {
                minDistanceWithFirstCity = Math.Abs(c[i] - 0);
            }
            if (Math.Abs(c[i] - (n - 1)) < minDistanceWithLastCity)
            {
                minDistanceWithLastCity = Math.Abs(c[i] - (n - 1));
            }
        }
        for (int i = 0; i < c.Length - 1; i++)
        {
            int asdasd = (int)(c[i + 1] - c[i]) / 2;

            if (asdasd > maxDistanceBetweenStations)
                maxDistanceBetweenStations = asdasd;
        }
        int[] returnValue = { minDistanceWithFirstCity, minDistanceWithLastCity, maxDistanceBetweenStations };
        int solution = -1;

        for (int i = 0; i < returnValue.Length; i++)
        {
            if (returnValue[i] > solution)
                solution = returnValue[i];
        }
        return solution;
    }

    static void Main(string[] args)
    {
        int[] array = { 0, 4 };

        Console.WriteLine(flatlandSpaceStations(5, array));
    }
}
