using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Section_10
{
    internal class Section_10
    {
        // Create a base class Car with two properties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired!" onto the console 
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.
        private static void Main(string[] args)
        {
            // a car can be a BMW, an Audi, a Porsche etc.
            // Polymorphism at work #1: an Audi,  BMW, Porsche
            // can all be used whereever a Car is expected. No cast is
            // required because an implicit conversion exists from a derived 
            // class to its base class.
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            // Polymorphism at work #2: the virtual method Repair is
            // invoked on each of the derived classes, not the base class.
            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Amir Orbe");
            audiA3.SetCarIDInfo(1235, "Erendira Sanchez");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();
            Console.ReadKey();

            /*
             * ******************************************************** Read a file 👇🏾
             */

            // string text = System.IO.File.ReadAllText(@"/Users/amir/Desktop/file.txt");

            // Console.WriteLine("Textfile contains the following text: {0}", text);

            ////Receive the Text line by line.
            // string[] lines = System.IO.File.ReadAllLines(@"/Users/amir/Desktop/file.txt");

            // Console.WriteLine("Content of the file line by line:");
            // foreach (string line in lines)
            // {
            //    //\t is a tab
            //    Console.WriteLine("\t" + line);
            // }

            /*
             * ******************************************************** Write a file 👇🏾
             */

            // To keep the Console open.
            string[] lines = { "First 100", "Second 32", "Third 50" };

            File.WriteAllLines(@"/Users/amir/Desktop/new_file.txt", lines);
            /*
            // Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"F:\C# Masterclass Course\Projects\Assets\" + fileName + ".txt", input);
            */

            // Method 3
            // using (StreamWriter file = new StreamWriter(@"F:\C# Masterclass Course\Projects\Assets\myText2.txt"))
            // {
            //    foreach (string line in lines)
            //    {
            //        if (line.Contains("2"))
            //        {
            //            file.WriteLine(line);
            //        }
            //    }
            // }

            // using (StreamWriter file = new StreamWriter(@"F:\C# Masterclass Course\Projects\Assets\myText2.txt", true))
            // {
            //    file.WriteLine("Additional line");
            // }
            Console.Read();
        }
    }
}
