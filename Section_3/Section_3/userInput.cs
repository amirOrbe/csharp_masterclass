using System;
namespace Section_3
{
    internal class UserInput
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Sum());
            Console.Read();
        }

        public static int Sum()
        {
            Console.WriteLine("Enter first number => ");
            string numberInput1 = Console.ReadLine();
            Console.WriteLine("Enter second number => ");
            string numberInput2 = Console.ReadLine();

            int number1 = int.Parse(numberInput1);
            int number2 = int.Parse(numberInput2);

            return number1 + number2;
        }
    }
}