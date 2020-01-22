using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            char min = GetMinNumber(a, b);
            char max = GetMaxNumber(a, b);
            for (char i = (char)(min + 1); i < max; i++)
            {
                Console.Write(i + " ");
            }
        }

        static char GetMinNumber(char a, char b)
        {
            char minNumber = a;
            if (b < a)
            {
                minNumber = b;
            }
            return minNumber;
        }
        static char GetMaxNumber(char a, char b)
        {
            char maxNumber = a;
            if (b > a)
            {
                maxNumber = b;
            }
            return maxNumber;
        }

    }
}
