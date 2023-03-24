using System;

namespace Types
{
    class DoubleType
    {

        static void main(string[] args)
        {
            int age = 15; //variable of type integer
            Console.WriteLine(age); //output will be 15
            age = 20;
            Console.WriteLine(age); //output will be 20
            Console.Read();

            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " devided by " + num2 + " is " + sumD);
            Console.Read();
        }

    }
}
