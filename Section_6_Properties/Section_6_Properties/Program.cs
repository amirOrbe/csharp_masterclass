using System;

namespace Section_6_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.lenght = 3;
            box.SetLength(1);
            box.Height = 4;
            box.width = 5;
            Console.WriteLine("box lenght is " + box.GetLength());
            Console.WriteLine("box volume is " + box.GetVolume ());
            Console.WriteLine("Frontsurface is {0}", box.FrontSurface);
            box.DisplayInfo();
        }
    }
}
