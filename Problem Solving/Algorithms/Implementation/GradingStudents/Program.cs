using System.Collections.Generic;
using System;

class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        int[] next_multiples = new int[grades.Count];
        List<int> final_grades = new List<int>(grades);

        for (int i = 0; i < grades.Count; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                while ((grades[i] + j) % 5 == 0)
                {
                    next_multiples[i] = grades[i] + j;
                    break;
                }
            }
            if (grades[i] >= 38)
            {
                if ((next_multiples[i] - grades[i]) < 3)
                    final_grades[i] = next_multiples[i];
                else
                    final_grades[i] = grades[i];
            }

            else
                final_grades[i] = grades[i];
        }
        return final_grades;
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