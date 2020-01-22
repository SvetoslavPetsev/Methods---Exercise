using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            while (number != "END")
            {
                Console.WriteLine(IsPalindrome(number).ToString().ToLower());
                number = Console.ReadLine();
            }
            
        }
        static bool IsPalindrome(string a)
        {
            bool palindrome = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[a.Length -1 - i])
                {
                    palindrome = false;
                }
            }
            return palindrome;
        }
    }
}
