// <copyright file="Challenge_1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Challenge1
{
    using System;

    internal class Challenge_1
    {
        private static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name and press enter: ");
            name = Console.ReadLine();
            string nameUpperCase = name.ToUpper();
            string nameLowerCase = name.ToLower();
            string nameTrim = name.Trim();
            string nameSubstring = name.Substring(0, 3);
            Console.WriteLine("UpperCase ---> " + nameUpperCase);
            Console.WriteLine("LowerCase ---> " + nameLowerCase);
            Console.WriteLine("Trim ---> " + nameTrim);
            Console.WriteLine("Substring ---> " + nameSubstring);
            Console.Read();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}