// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Section_6
// {
//    // this class is a blueprint for a datatype
//   create a public variable lastName of type string.
//    // change the IntroduceMyself method, so it tells the whole name.
//    // create two objects with full information about themself - firstName and lastName
//    class Human
//
//    {
//        // member variable
//        public string firstName;
//        public string lastName;
//        // constructor
//        public Human(string myFirstName, string lastName)
//        {
//            firstName = myFirstName;
//            this.lastName = lastName;
//        }
//        // member method
//        public void IntroduceMyself()
//        {
//            Console.WriteLine($"Hi, I'm {firstName} {lastName}");
//        }
//    }
// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6
{
    internal class Human
    {
        // why private? https://softwareengineering.stackexchange.com/questions/143736/why-do-we-need-private-variables
        private int age;
        private string firstName;
        private string lastName;
        private string eyeColor;
        private bool isHuman = true;

        public Human(int ageInput, string firstName, string lastName, string eyeColor)
        {
            age = ageInput;
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public void IntroduceOnceself()
        {
            Console.WriteLine($"My name is {firstName} {lastName}, and my eye color is {eyeColor}, I'm {age} years old and also this says if I'm human => {isHuman}");
        }
    }
}