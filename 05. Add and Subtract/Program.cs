using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = GiveSumFirstSecond(firstNumber, secondNumber);
            int diff = GiveDiff(sum, thirdNumber);
            Console.WriteLine(diff);
        }
        static int GiveSumFirstSecond(int a, int b)
        {
            int c = a + b;
            return c;

        }
        static int GiveDiff(int a, int b)
        {
            int c = a - b;
            return c;
        }
    }
}
