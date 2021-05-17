using System;

namespace StrongPassword
{
    class Program
    {
        static int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialCharacters = "!@#$%^&*()-+";
            char[] charArray = password.ToCharArray();

            int count = 4;
            int digits = 6 - n;

            bool lower = false;
            bool upper = false;
            bool special = false;
            bool number = false;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (numbers.IndexOf(password[i]) > -1 && !number)
                {
                    count--;
                    number = true;
                }
                if (lowerCase.IndexOf(password[i]) > -1 && !lower)
                {
                    count--;
                    lower = true;
                }
                if (upperCase.IndexOf(password[i]) > -1 && !upper)
                {
                    count--;
                    upper = true;
                }
                if (specialCharacters.IndexOf(password[i]) > -1 && !special)
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
