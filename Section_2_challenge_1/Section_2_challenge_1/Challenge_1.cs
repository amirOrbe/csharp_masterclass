using System;

namespace Challenge1
{
    class Challenge_1
    {

        static void Main(string[] args)
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
    }
}