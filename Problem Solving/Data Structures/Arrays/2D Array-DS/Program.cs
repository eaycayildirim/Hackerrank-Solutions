using System;
using System.Collections.Generic;
using System.Linq;

namespace Array2D
{
    class Program
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int max = -99;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    int sum = 0;
                    for (int k = i-1; k <= i+1; k+=2)
                    {
                        for (int m = j-1; m <= j+1; m++)
                        {
                            sum += arr[k][m];
                        }
                    }
                    sum += arr[i][j];
                    if (sum > max)
                        max = sum;
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            Console.WriteLine(hourglassSum(arr));
        }
    }
}
