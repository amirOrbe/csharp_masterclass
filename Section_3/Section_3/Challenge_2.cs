using System;

namespace Coding.Exercise
{
    public class Method
    {
        // Place for your methods
        public static void Run()
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            // Change nothing down here.
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }

        public static string LowUpper(string word)
        {
            string upperWord = word.ToUpper();
            string lowerWord = word.ToLower();
            return $"{lowerWord}{upperWord}";
        }

        public static void Count(string word)
        {
            int wordCount = word.Length;
            Console.WriteLine($"The amount of characters is {wordCount}.");
        }
    }
}
