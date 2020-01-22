using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                switch (command[0])
                {
                    case "end":
                        Console.WriteLine("[" + string.Join(", ", inputArray) + "]");
                        return;
                    case "exchange":
                        int index = int.Parse(command[1]);

                        if (index < 0 || index >= inputArray.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputArray = Exchange(inputArray, index);
                        }
                        break;
                    case "max":
                    case "min":
                        if (command[1] == "odd" && HaveOdd(inputArray) == true)
                        {
                            Console.WriteLine(GiveMaxEvenOrOddIndex(inputArray, command[0], command[1]));
                        }
                        else if (command[1] == "even" && HaveEven(inputArray) == true)
                        {
                            Console.WriteLine(GiveMaxEvenOrOddIndex(inputArray, command[0], command[1]));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "first":
                    case "last":
                        int count = int.Parse(command[1]);
                        if (CheckLength(inputArray, count) == true)
                        {
                            if (command[2] == "even")
                            {
                                int[] evenArray = GiveFirstOrLastCountEven(inputArray, count, command[0]);
                                Console.WriteLine("[" + string.Join(", ", evenArray) + "]");
                            }
                            else if (command[2] == "odd")
                            {
                                int[] oddArray = GiveFirstOrLastCountOdd(inputArray, count, command[0]);
                                Console.WriteLine("[" + string.Join(", ", oddArray) + "]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }
            }
        }
        static int[] Exchange(int[] a, int b)
        {
            int[] temp = new int[a.Length];
            for (int i = 0; i < a.Length - b - 1; i++)
            {
                temp[i] = a[b + i + 1];
            }
            int counter = 0;
            for (int i = a.Length - b - 1; i < a.Length; i++)
            {
                temp[i] = a[counter];
                counter++;
            }
            a = temp;
            return a;
        }
        static bool HaveOdd(int[] a)
        {
            bool odd = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    odd = true;
                }
            }
            return odd;
        }

        static bool HaveEven(int[] a)
        {
            bool even = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even = true;
                }
            }
            return even;
        }

        static int GiveMaxEvenOrOddIndex(int[] array, string minMax, string evenOdd)
        {
            int index = 0;
            if (minMax == "max")
            {
                int max = int.MinValue;
                if (evenOdd == "odd")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0 && array[i] >= max)
                        {
                            max = array[i];
                            index = i;
                        }
                    }
                }
                else if (evenOdd == "even")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0 && array[i] >= max)
                        {
                            max = array[i];
                            index = i;
                        }
                    }
                }
            }
            else if (minMax == "min")
            {
                int min = int.MaxValue;
                if (evenOdd == "odd")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0 && array[i] <= min)
                        {
                            min = array[i];
                            index = i;
                        }
                    }
                }
                if (evenOdd == "even")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0 && array[i] <= min)
                        {
                            min = array[i];
                            index = i;
                        }
                    }
                }
            }
            return index;
        }

        static bool CheckLength(int[] a, int b)
        {
            bool check = false;
            if (a.Length >= b)
            {
                check = true;
            }
            if (b < 1)
            {
                check = false;
            }
            return check;
        }

        static int[] GiveFirstOrLastCountEven(int[] array, int count, string firstLast)
        {
            string evenOdd = "even";
            if (count > GiveNumberEvenOrOdd(array, evenOdd))
            {
                count = GiveNumberEvenOrOdd(array, evenOdd);
            }
            int[] temp = new int[count];
            if (firstLast == "first")
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && counter <= count - 1)
                    {
                        temp[counter] = array[i];
                        counter++;
                    }
                }
            }
            else if (firstLast == "last")
            {
                int counter = count - 1;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0 && counter >= 0)
                    {
                        temp[counter] = array[i];
                        counter--;
                    }
                }

            }
            return temp;
        }

        static int[] GiveFirstOrLastCountOdd(int[] array, int count, string firstLast)
        {

            string evenOdd = "odd";
            if (count > GiveNumberEvenOrOdd(array, evenOdd))
            {
                count = GiveNumberEvenOrOdd(array, evenOdd);
            }
            int[] temp = new int[count];
            if (firstLast == "first")
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && counter <= count - 1)
                    {
                        temp[counter] = array[i];
                        counter++;
                    }
                }

            }
            else if (firstLast == "last")
            {
                int counter = count - 1;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0 && counter >= 0)
                    {
                        temp[counter] = array[i];
                        counter--;
                    }
                }
            }
            return temp;
        }

        static int GiveNumberEvenOrOdd(int[] a, string evenOdd)
        {
            int counter = 0;
            if (evenOdd == "even")
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        counter++;
                    }
                }
            }
            else if (evenOdd == "odd")
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 != 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}