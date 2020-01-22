using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double div = GiveFactorial(first) / GiveFactorial(second);
            Console.WriteLine($"{div:F2}");
        }

        static double GiveFactorial(int a)
        {
            double result = 2;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
