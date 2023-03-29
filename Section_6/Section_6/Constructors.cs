using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section_6;

namespace _0602Class
{
    class Constructors
    {
        static void Main(string[] args)
        {

            Human amir = new Human(24, "Amir", "Orbe", "Pink");
            Human ere = new Human(24, "Erendira", "Sanchez", "Beautiful");
            amir.IntroduceOnceself();
            ere.IntroduceOnceself();
            Console.Read();
        }
    }
}
