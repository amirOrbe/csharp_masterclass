using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void ForLoop()
        {
            for (int i = -3; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            int initialValue = 3;
            while (initialValue >= -3)
            {
                Console.WriteLine(initialValue);
                initialValue--;
            }
        }

        public static void Run()
        {
            WhileLoop();
            ForLoop();

        }

    }
}
