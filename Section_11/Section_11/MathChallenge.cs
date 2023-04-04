using System;

namespace Section_11
{
    public class MatchChallenge
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            int angle;

            if (int.TryParse(line, out angle) == false || (angle < 0 || angle > 180))
            {
                System.Console.WriteLine("Check the input!");
                return;
            }

            System.Console.WriteLine("Cos = {0}", Math.Cos(ConvertToRadians(angle)));
            System.Console.WriteLine("Sin = {0}", Math.Sin(ConvertToRadians(angle)));
            System.Console.WriteLine("Tg = {0}", Math.Tan(ConvertToRadians(angle)));
        }
    }
}
