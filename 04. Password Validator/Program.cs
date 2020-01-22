using System;

namespace _04._Password_Validator
{
    class Program
    {
        public static void Main()
        {
            string password = Console.ReadLine().ToLower();
            bool length = false;
            bool lettersDigit = true;
            bool twoDigit = false;

            length = CheckLength(password, length);
            lettersDigit = CheckLetterDigit(password, lettersDigit);
            twoDigit = CheckTwoDigit(password, twoDigit);

            if (length == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (lettersDigit == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (twoDigit == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (length == true && lettersDigit == true && twoDigit == true)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool CheckLength(string password, bool length)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                length = true;
            }
            return length;
        }
        static bool CheckLetterDigit(string password, bool lettersDigit)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= '0' && password[i] <= '9') && !(password[i] >= 'a' && password[i] <= 'z'))
                {
                    lettersDigit = false;
                }
            }
            return lettersDigit;
        }
        static bool CheckTwoDigit(string password, bool twoDigit)
        {
            int counterDigit = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    counterDigit++;
                }
            }
            if (counterDigit >= 2)
            {
                twoDigit = true;
            }
            return twoDigit;
        }
    }
}
