using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int counterVowel = GiveCountVowel(input);

            Console.WriteLine(counterVowel);
        }

        private static int GiveCountVowel(string input)
        {
            string vowels = "aeiou";
            int counterVowel = 0;
            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (vowels[i] == input[j])
                    {
                        counterVowel++;
                    }
                }
            }

            return counterVowel;
        }
    }
}
