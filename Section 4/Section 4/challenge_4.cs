using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsChallenge2
{
    class Challenge_4
    {
        static int highscore = 300;
        static string highscorePlayer = "Amir";

        static void main(string[] args)
        {
            var numberRandom = new Random();
            CheckHighscore(numberRandom.Next(140), "Agus");
            CheckHighscore(numberRandom.Next(250), "Noe");
            CheckHighscore(numberRandom.Next(350), "Luis");

            Console.Read();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);

            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
            }
        }

    }
}
