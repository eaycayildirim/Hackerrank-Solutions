using System;

namespace StrongPassword
{
    class Program
    {
        static int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";
            char[] char_array = password.ToCharArray();

            int count = 4;
            int digits = 6 - n;

            bool lower = false;
            bool upper = false;
            bool special = false;
            bool number = false;

            for (int i = 0; i < char_array.Length; i++)
            {
                if (numbers.IndexOf(password[i]) > -1 && !number)
                {
                    count--;
                    number = true;
                }
                if (lower_case.IndexOf(password[i]) > -1 && !lower)
                {
                    count--;
                    lower = true;
                }
                if (upper_case.IndexOf(password[i]) > -1 && !upper)
                {
                    count--;
                    upper = true;
                }
                if (special_characters.IndexOf(password[i]) > -1 && !special)
                {
                    count--;
                    special = true;
                }
            }

            if (digits > count)
                return digits;
            else
                return count;
        }
        static void Main(string[] args)
        {
            string password = "#HackerRank";

            Console.WriteLine(minimumNumber(11, password));
        }
    }
}
