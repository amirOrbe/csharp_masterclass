using System;

namespace Challenge2
{
    public class Challenge2
    {
        public static void NestedCheck(int number)
        {
            Console.WriteLine(number % 3 == 0 ? "Divisible by 3." : number % 7 == 0 ? "Divisible by 7." : number % 2 == 0 ? "Even number." : "Odd number.");
        }
    }
}
