using System;

namespace Types
{
    class StringManipulation
    {

        static void main(string[] args)
        {
            int age = 24;
            string name = "Amir";
            string job = "Developer";

            //1.-String concatenation
            Console.WriteLine("String concatenation -------->");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");
            Console.Read();

            //2.- String formatting
            // string formatting uses index

            Console.WriteLine("String formatting ------------->");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I am a {2}", name, age, job);
            Console.Read();
            // 3.- String interpolation.
            /* string interpolation uses $ at the start which will allows to write our
             * variables like this {variableName}
             */
            Console.WriteLine("String interpolation ------------->");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old. I am a {job}");
            Console.Read();

            // 4.- Verbatim strings.
            /*verbatim strings start with @ and tells the compiler to take the string literally
             * and ignore any spaces and escape characters like \n
             */
            Console.WriteLine("Varbatim strings------------->");
            Console.WriteLine(@" is simply dummy text of the printing and
typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a");
            Console.Read();

            /*instead of using \\ to write file paths we can use verbatim strings to make it easier
             * if you remove the @ you will get an error because \U , \A and \D are not valid escape characters
             */
            Console.WriteLine(@"C:\Users\Amir\someurl");
            Console.Read();

            //with varbatim strings event valid escape characters won't work
            Console.WriteLine(@"Test message \n with valid escape character and not work");
            Console.Read();

            Console.WriteLine("Test message \n with valid escape character and work");
            Console.Read();
        }

    }
}
