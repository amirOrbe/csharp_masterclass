using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StructsC
{
    public struct Game
    {
        public string Name;
        public string Developer;
        public double Rating;
        public string ReleaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.Name = name;
            this.Developer = developer;
            this.Rating = rating;
            this.ReleaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Game 1's name is :{0}", Name);
            Console.WriteLine("Game 1' was developed by :{0}", Developer);
            Console.WriteLine("Game 1's rating is :{0}", Rating);
            Console.WriteLine("Game 1 was released in :{0}", ReleaseDate);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Game game1;

            game1.Name = "Pokemon Go";
            game1.Developer = "Niantic";
            game1.Rating = 3.5;
            game1.ReleaseDate = "01.07.2016";

            game1.Display();

            Console.ReadKey();
        }
    }
}
