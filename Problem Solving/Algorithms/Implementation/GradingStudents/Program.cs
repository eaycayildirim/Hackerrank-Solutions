using System.Collections.Generic;
using System.IO;
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
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}