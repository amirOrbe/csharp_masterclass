using System;
namespace Section_3
{

    class TryCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number => ");
            string numberInput = Console.ReadLine();
            int number1 = 3;
            int number2 = 0;
            int devide;

            try
            {
                devide = number1 / number2;
            }
            catch (Exception)
            {
                Console.WriteLine("Can't devide by 0"); 
            }


            try
            {
                int numberInputAsInt = int.Parse(numberInput);
            }

            catch(FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type! ");
            }
            catch(OverflowException)
            {
                Console.WriteLine("OverFlow exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The value was empty or null");
            }
            finally
            {
                Console.WriteLine("This is called anyways :)");
            }
            Console.ReadKey(); 
        }
    }
}

