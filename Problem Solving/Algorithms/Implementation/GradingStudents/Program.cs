using System.Collections.Generic;
using System;

class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        int[] nextMultiples = new int[grades.Count];
        List<int> finalGrades = new List<int>(grades);

        for (int i = 0; i < grades.Count; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                while ((grades[i] + j) % 5 == 0)
                {
                    nextMultiples[i] = grades[i] + j;
                    break;
                }
            }
            if (grades[i] >= 38)
            {
                if ((nextMultiples[i] - grades[i]) < 3)
                    finalGrades[i] = nextMultiples[i];
                else
                    finalGrades[i] = grades[i];
            }

            else
                finalGrades[i] = grades[i];
        }
        return finalGrades;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        List<int> grades = new List<int>() { 73, 67, 38, 33};

        Result.gradingStudents(grades).ForEach(Console.WriteLine);
    }
}