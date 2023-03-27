using System;

namespace Section_3
{
    class Program
    {

        static void main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();
        }
        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

    }
}
