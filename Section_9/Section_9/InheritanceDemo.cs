using System;

namespace Section_9
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Onkyo");
            //myRadio.SwitchOn();
            myRadio.ListenRadio();

            Tv myTv = new Tv(false, "Panasonic");
            myTv.SwitchOn();
            myTv.WatchTv();

            Dog myDog = new Dog("Leia", 1);
            Console.WriteLine($"{myDog.Name} is {myDog.Age} years old");
            myDog.MakeSound();
            myDog.Play();
            myDog.Eat();

            Post post1 = new Post("Thanks for the birthday wishes", true, "Amir Orbe");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Amir Orbe",
                "https://images.com/shoes", true);

            //Challenge_1

            VideoPost videoPost1 = new VideoPost("FailVideo", "Amir Orbe",
                "https://video.com/failvideo", true, 10);

            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();




            // Challenge_2

            Employee amir = new Employee("Amir", "Luis", 400);

            amir.Work();
            amir.Pause();

            Boss Agus = new Boss("Audi", "Agus", "Ramos", 999999999);

            Agus.Lead();

            Trainee abner = new Trainee(32, 8, "Sanchez", "Abner", 10000);
            abner.Learn();
            abner.Work();
            Console.ReadKey();


        }
    }
}