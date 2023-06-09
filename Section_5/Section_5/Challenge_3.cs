﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_5
{
    internal class Challenge_3
    {
        private static void Main(string[] args)
        {
            string? input = "0";
            int count = 0;
            int total = 0;
            int current = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", current);
                Console.WriteLine("Enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("--------------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if (int.TryParse(input, out current) && current > 0 && current < 21)
                {
                    total += current;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Enter a value between 1 and 20");
                    }
                    continue;
                }

                count++;
            }

            Console.ReadLine();
        }
    }
}
