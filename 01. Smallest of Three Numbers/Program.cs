using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                minNumber = IsMinNumber(minNumber, number);
            }
            Console.WriteLine(minNumber);

        }

        private static int IsMinNumber(int minNumber, int number)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }

            return minNumber;
        }
    }
}
