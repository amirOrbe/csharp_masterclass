using System;

namespace Section_2
{
    internal class ParsingNumbers
    {
        private static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = int.Parse(myString);
            int num2 = int.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine("sum concatination result => " + result);

            Console.WriteLine("sum of numbers type => " + resultInt);
            Console.Read();
        }

    }
}
