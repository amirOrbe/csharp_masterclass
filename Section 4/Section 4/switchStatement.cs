using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void main(string[] args)
        {

            int age = 24;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 24:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 24)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Amir";

            switch (username)
            {
                case "Amir":
                    Console.WriteLine("username is Amir");
                    break;
                case "someone":
                    Console.WriteLine("username is someone");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }
            Console.Read();
        }
    }
}
