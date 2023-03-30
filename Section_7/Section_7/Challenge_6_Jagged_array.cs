using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_7
{
    class Program
    {
        // Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
        // Introduce family members from different families to each other via console (three introductions)


        static void main(string[] args)
        {
            string[] myFamily = new string[] { "Ivonne", "Bruce" };


            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Saul", "Cynthia"},
                new string[]{"Amir", "Erendira"},
                new string[]{"Jatz", "Abner"},
                myFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[3][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[2][0], friendsAndFamily[1][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[3][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }
}
