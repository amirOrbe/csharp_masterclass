using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhanced_If_Statements
{
    class Challenge_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature: ");
            string temperature = Console.ReadLine();

            try
            {
          
                temperatureCheck(int.Parse(temperature));
            }
            catch (Exception)
            {
                Console.WriteLine("Not a valid Temperature");
            }
            Console.Read();

        }

        public static void temperatureCheck(int temperature)
        {
            Console.WriteLine(temperature <= 15 ? "it is too cold here" : temperature >= 16 && temperature <= 28 ? "it is ok" : temperature > 28 ? "it is hot here" : "Not Valid temperature");
        }
    }
}
