using System;
using System.Collections.Generic;

namespace EqualizeTheArray
{
    class Program
    {
        static int equalizeArray(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                    dic[arr[i]]++;
                else
                    dic.Add(arr[i], 1);
            }

            KeyValuePair<int, int> max = new KeyValuePair<int, int>();
            foreach (var kvp in dic)
            {
                if (kvp.Value > max.Value)
                    max = kvp;
            }
            return arr.Length - max.Value;
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 3, 2, 1, 3 };

            Console.WriteLine(equalizeArray(array));
        }
    }
}
