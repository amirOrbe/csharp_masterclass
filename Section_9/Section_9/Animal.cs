using System;
namespace Section_9
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating :P");
            }
            else
            {
                Console.WriteLine($"Is not hungry :)");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing :O");
        }
    }
}