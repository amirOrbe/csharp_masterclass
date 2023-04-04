using System;

namespace Section_7
{
    public class Challenge_1
    {
        public static void GetOdd(int[] Array)
        {
            foreach (int number in Array)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            foreach (int number in Array)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);
        }
    }
}
