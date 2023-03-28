using System;

namespace Challenge_2
{
    public class Challenge_2
    {
        public static void Main()
        {
            int i = -10;

            while (true)
            {

                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 10)
                {

                    break;
                }
                Console.WriteLine(i++);
            }
        }
    }
}
