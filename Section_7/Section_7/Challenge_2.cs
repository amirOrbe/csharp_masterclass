using System;

namespace Section_7
{
    internal class Challenge_2
    {
        public static void main()
        {
            Console.WriteLine("Enter a value : ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the datatype for the value : ");
            Console.WriteLine("1 for String");
            Console.WriteLine("2 for Integer");
            Console.WriteLine("3 for Boolean");

            Console.WriteLine("Enter : ");
            int inputDataType = int.Parse(Console.ReadLine());

            if(inputDataType >= 1 && inputDataType <= 3)
            {
                ReadValue(inputDataType, inputValue);
            }
            else
            {
                Console.WriteLine("Select a valid Data Type :)");
            }
        }

        public static void ReadValue(int inputDataType, string inputValue)
        {
            bool isValid = false;
            string inputValueType = "";

            switch (inputDataType)
            {
                case 1:
                    isValid = IsALetter(inputValue);
                    inputValueType = "String";
                    break;

                case 2:
                    int parseValue = 0;
                    isValid = int.TryParse(inputValue, out parseValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool flag = false;
                    isValid = bool.TryParse(inputValue, out flag);
                    inputValueType = "Boolean";
                    break;
                default:
                    Console.WriteLine("Error in read the value :( ");
                    break;
            }

            Console.WriteLine(isValid ? $"Is a valid {inputValueType}" : $"Is not a valid {inputValueType}");
            Console.Read();
        }

        public static bool IsALetter(string inputValue)
        {
            foreach(char letter in inputValue)
            {
                return char.IsLetter(letter) ? true : false;
            }
            return false;
        }
    }
}