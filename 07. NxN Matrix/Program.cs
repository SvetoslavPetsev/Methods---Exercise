using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);
        }

        private static void PrintMatrix(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintColumn(number);
                Console.WriteLine();
            }
        }

        private static void PrintColumn(int number)
        {
            for (int j = 1; j <= number; j++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
