using System;

class Solution
{
    static int designerPdfViewer(int[] h, string word)
    {
        int result = 0;
        int maxHeight = 0;
        char[] array = word.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            if (h[array[i] - 'a'] > maxHeight)
                maxHeight = h[array[i] - 'a'];
        }
        result = maxHeight * array.Length;
        return result;
    }
    static void Main(string[] args)
    {
        int[] array = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

        Console.WriteLine(designerPdfViewer(array, "abc"));
    }
}