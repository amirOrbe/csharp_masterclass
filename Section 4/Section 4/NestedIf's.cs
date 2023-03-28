using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIf
{
    class Program
    {
        static void main(string[] args)
        {
            //Some Booleans
            //Play around with the Values
            bool isRegistered = true;
            string userName = "";
            bool isAdmin = true;

            //User-Input
            //Try "Amir"
            Console.WriteLine("Please enter you username");
            userName = Console.ReadLine();

            //Code inside will be executed, if isRegistered is true
            if (isRegistered)
            {
                Console.WriteLine("User is registered");

                //Code inside will be executed, if userName is not ""
                if (userName != "")
                {
                    Console.WriteLine($"Hello {userName}");

                    //Code inside will be executed, if userName is "Amir"
                    if (isAdmin)
                    {
                        Console.WriteLine("Oh, an Admin logged in. Welcome");
                    }
                }
            }

            //The same result can be achieved by using logical and
            if (isRegistered && userName != "" && isAdmin)
            {
                Console.WriteLine("User is registered");
                Console.WriteLine($"Hello {userName}");
                Console.WriteLine("Oh, an Admin logged in. Welcome");

                if (userName == "Amir")
                {
                    Console.WriteLine("Welcome, Master Amir");
                }
            }

            //This will keep the Console open
            Console.Read();
        }
    }
}
