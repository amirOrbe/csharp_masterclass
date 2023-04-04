// <copyright file="Challenge_2.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Challenge2
{
    using System;

    /// <summary>
    /// Challenge_2.
    /// </summary>
    internal class Challenge_2
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");

            #pragma warning disable
            string word = Console.ReadLine();

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