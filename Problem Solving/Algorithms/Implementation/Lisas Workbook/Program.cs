using System;

namespace LisasWorkbook
{
    class Program
    {
        static int workbook(int n, int k, int[] arr)
        {
            int count = 0;
            int page = 0;

            for (int i = 0; i < n; i++)
            {
                page++;
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (page == j)
                        count++;
                    if (j % k == 0 && j != arr[i])
                        page++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] array = { 4, 2, 6, 1, 10 };

            Console.WriteLine(workbook(5, 3, array));
        }
    }
}
