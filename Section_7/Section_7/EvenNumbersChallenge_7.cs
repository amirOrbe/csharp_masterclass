using System;
using System.Collections.Generic;
namespace Coding.Exercise
{
    public class ListsExercise
    {
        public static List<int> Solution()
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 100; i <= 170; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }

            return evenNumbers;
        }
    }
}
