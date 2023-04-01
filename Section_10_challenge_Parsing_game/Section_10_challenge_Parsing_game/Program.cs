using System;

namespace ParsingGame
{
    class Section_10_Parsing_game
    {
        public static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"./input.txt");
            string output = "";
            foreach (string line in lines)
            {
                if (line.Contains("split"))
                {
                    var phrase = line.Split(' ');
                    output += phrase[4] + " ";
                }
            }
            File.WriteAllText("./output.txt", output);
        }
    }
}