﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_7
{
    internal class ForEach
    {
        private static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
            }

            Console.ReadKey();

            // Challenge 👇🏾
            // Create an array with the names of five friends
            // greet all of them with a foreach loop
            string[] myFriends = { "Agus", "Luis", "Julito", "Dan", "Peter" };

            foreach (string name in myFriends)
            {
                Console.WriteLine("Holiwis {0}", name);
            }

            Console.ReadKey();
        }
    }
}
