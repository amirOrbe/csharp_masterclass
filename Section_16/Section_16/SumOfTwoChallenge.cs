using System;
using System.Collections.Generic;

namespace Section_16
{
    public class SumOfTwoChallenge
    {
        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int result = 0;

            foreach (int value in nums)
            {
                if (dic.ContainsKey(SumToFind - value) && dic[SumToFind - value] > 0)
                {
                    dic[SumToFind - value] -= 1;

                    result++;
                    continue;
                }

                if (dic.ContainsKey(value))
                {
                    dic[value] += 1;
                }
                else
                {
                    dic.Add(value, 1);
                }
            }

            return result;
        }
    }
}