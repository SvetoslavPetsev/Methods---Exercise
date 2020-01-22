using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddle(input));
        }
        static string GetMiddle(string a)
        {
            string middle = "";
            int length = a.Length;
            if (length % 2 == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    middle += a[(length - 1) / 2 + i];
                }
            }
            else
            {
                middle += a[(length - 1) / 2];
            }
            return middle;
        }
    }
}
