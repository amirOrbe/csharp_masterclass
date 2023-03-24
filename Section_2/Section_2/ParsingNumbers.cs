using System;

namespace Section_2
{
    class ParsingNumbers
    {

        static void main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine("sum concatination result => " + result);

            Console.WriteLine("sum of numbers type => " + resultInt);
            Console.Read();
        }

    }
}
