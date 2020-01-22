using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 1; i <= range; i++)
            {
                int sum = GiveSum(i);
                if (IsDivEight(sum) == true)
                {
                    if (HaveOdd(i) == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static int GiveSum(int a)
        {
            string b = a.ToString();
            int sum = 0;
            for (int j = 0; j < b.Length; j++)
            {
                int c = Convert.ToInt32(b[j]);
                sum += c;
            }
            return sum;

        }
        static bool IsDivEight(int sum)
        {
            bool div = false;
            if (sum % 8 == 0)
            {
                div = true;
            }
            return div;
        }
        static bool HaveOdd(int a)
        {
            bool odd = false;
            string b = a.ToString();
            for (int j = 0; j < b.Length; j++)
            {
                int c = Convert.ToInt32(b[j]);
                if (c % 2 != 0)
                {
                    odd = true;
                }
            }
            return odd;
        }
    }
}
