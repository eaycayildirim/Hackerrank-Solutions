using System;
using System.Collections.Generic;

namespace LeftRotation
{
    class Program
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int numberOfRotation = d % arr.Count;
            List<int> newList = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                newList.Add(arr[(i+numberOfRotation)%arr.Count]);
            }
            return newList;
        }

        static void Main(string[] args)
        {
            int d = 4;
            List<int> list = new List<int>{ 1, 2, 3, 4, 5 };

            rotateLeft(d, list).ForEach(Console.WriteLine);
        }
    }
}
