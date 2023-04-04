// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Security.Cryptography;
// using System.Text;
// using System.Threading.Tasks;
// namespace Section_6
// s{
//    class Program
//    {
//        static void main(string[] args)
//        {
//            Human amir = new Human(24, "Amir", "Orbe", "brown");
//            amir.IntroduceMyself();
//            Human fietz = new Human(9, "Fietz", "Dog", "brown");
//            fietz.IntroduceMyself();
//            Human leia = new Human(1, "Leia", "Bitch XD", "brown");
//            leia.IntroduceMyself();
//            Console.ReadKey();
//        }
//    }
// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section_6;

namespace Classes___Basics
{
    internal class Section_6
    {
        private static void Main(string[] args)
        {
            Human amir = new Human("amir", "amir", "black", 24);
            amir.IntroduceMyself();

            Human ere = new Human("Erendira", "Sanchez", "Brown");
            ere.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human jatz = new Human("Jatz");
            jatz.IntroduceMyself();

            Human abner = new Human("Abner", "Sanchez");
            abner.IntroduceMyself();

            Human leia = new Human("Leia", "Bitch", 1);
            leia.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
