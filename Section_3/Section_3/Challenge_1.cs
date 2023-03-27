using System;
namespace Section_3
{
    class Challenge_1
    {
        static void main(string[] args)
        {
            string friend1 = "Agus";
            string friend2 = "Luis";
            string friend3 = "Julito";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine($"Holi {friendName} amigo :)");
        }
    }
}

