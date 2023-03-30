using System;
using System.Collections.Generic;

namespace Section_7
{
    public class Challenge_9
    {
        public static string Convert(int i)
        {
            Dictionary<int, string> values = new Dictionary<int, string>()

            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" }
            };
            return values.ContainsKey(i) ? values[i] : "nope";
        }
    }
}
