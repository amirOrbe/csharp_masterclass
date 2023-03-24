using System;

namespace Challenge2
{
    class Challenge_2
    {

        static void Main(string[] args)
        {
            string word;
            Console.Write("Enter a string here: ");
            word = Console.ReadLine();

            string character;
            Console.Write("Enter the character to search: ");
            character = Console.ReadLine();
            int index = word.IndexOf(character);
            Console.WriteLine($"position of the {character} in the word {word} is -> " + index);
            string firstName;
            Console.Write("Enter the first name: ");
            firstName = Console.ReadLine();
            string lastName;
            Console.Write("Enter the last name: ");
            lastName = Console.ReadLine();
            string nameConcatenation = string.Concat(firstName, " ", lastName);
            Console.WriteLine(nameConcatenation);
            Console.Read();
        }
    }
}