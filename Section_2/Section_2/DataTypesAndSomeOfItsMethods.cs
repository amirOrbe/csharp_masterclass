using System;

namespace DataTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string myname = "Amir";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }

    }
}
