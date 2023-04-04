using System;
namespace Section_2
{
    internal class Constants
    {
        private const double PI = 3.141592;
        private const int Weeks = 52;
        private const int Months = 12;
        private const int Days = 365;
        private const string Birthday = "13/09/98";
        private static object? birthday;

        private static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always to be: {0}", birthday);
            Console.Read();
        }
    }
}