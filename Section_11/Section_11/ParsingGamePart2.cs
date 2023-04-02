using System;
using System.Text.RegularExpressions;

namespace ParsingGame
{
    class Section_10_Parsing_game
    {
        public static void Main(string[] args)
        {
            //string[] lines = System.IO.File.ReadAllLines(@"/Users/amir/Downloads/input2.txt");
            string output = "";
            string sourceText = File.ReadAllText(@"/Users/amir/Downloads/input2.txt");


            Regex regex = new Regex(@"\d{2,3}");
            MatchCollection matches = regex.Matches(sourceText);

            foreach (Match match in matches)
            {
                int num = int.Parse(match.Value);
                char c = (char)num;
                output += c;
                File.WriteAllText("/Users/amir/Downloads/new_output.txt", output);
            }

        }
    }
}