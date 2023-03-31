using System;

namespace Section_9
{

    // place for your classes and an interface
    class Gun : Weapon, IShootable
    {
        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }

        public Gun()
        {
            Name = "Gun";
        }
    }

    interface IShootable
    {
        void Shoot();
    }

    class Weapon
    {

        public string Name;

        public void Label()
        {
            Console.WriteLine($"This is {Name}!");
        }
    }

    public static class Section_9
    {
        static public void Main(string[] args)
        {
            // new instance 
            Gun pist = new Gun();

            // test for methods
            pist.Label();
            pist.Shoot();

            // verifying the interface and the parent class
            if (pist is IShootable && pist is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        }
    }
}
