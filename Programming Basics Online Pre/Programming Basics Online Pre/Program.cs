﻿using System;
using System.Collections.Generic;
namespace Programming_Basics_Online_Pre
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             https://judge.softuni.bg/Contests/Compete/Index/2877#5
             06.Gold Mine
             
            decimal input = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                decimal total = 0;
                decimal input1 = decimal.Parse(Console.ReadLine());
                decimal input2 = decimal.Parse(Console.ReadLine());
                for (int j = 0; j < input2; j++)
                {
                    decimal input3 = decimal.Parse(Console.ReadLine());
                    total += input3;
                }
                decimal real = total / input2;
                if (input1 <= real)
                {
                    Console.WriteLine($"Good job! Average gold per day: {real:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {input1 - real:f2} gold.");
                }


            }
          
            05.Puppy Care
              

            decimal input = decimal.Parse(Console.ReadLine()) * 1000;
            string input2 = (Console.ReadLine());
            decimal total = 0;
            decimal current = 0;
            while (input2 != "Adopted")
            {
                current = decimal.Parse(input2);
              
                total += current;
                


                input2 = (Console.ReadLine());
            }
            
            if (total <= input)
            {
                Console.WriteLine($"Food is enough! Leftovers: {input-total} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {total- input} grams more.");
            }

            04.Gifts from Santa
            

            decimal input = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());

            for (decimal i = input2; i >= input; i--)
            {
                if (i %2 == 0  && i %3 == 0)
                {
                    if (i == input3)
                    {
                        break;
                    }
                    Console.Write($"{i} ");
                }
                
            }
            
            03.Cat Life
            

            var male = new Dictionary<string, decimal>()
            {
                {"British Shorthair",13 },
                {"Siamese",15 },
                {"Persian",14 },
                {"Ragdoll",16 },
                {"American Shorthair",12 },
                {"Siberian",11 }
            };
            var female = new Dictionary<string, decimal>()
            {
                {"British Shorthair",14 },
                {"Siamese",16 },
                {"Persian",15 },
                {"Ragdoll",17 },
                {"American Shorthair",13 },
                {"Siberian",12 }
            };

            string input = (Console.ReadLine());
            string input1 = (Console.ReadLine());
            var real = new Dictionary<string, decimal>();

            //setting the dictionary
            if (input1 == "m")
            {
                real = male;
            }
            else
            {
                real = female;
            }
            //check if cat exists
            if (!real.ContainsKey(input))
            {
                Console.WriteLine($"{input} is invalid cat!");
            }
            
            else
            {
                decimal months = 0;
                months = (real[input] * 12) / 6;
                Console.WriteLine($"{months} cat months");
            }

            02.Spaceship
           

            decimal input = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal input4 = decimal.Parse(Console.ReadLine());

            decimal rocketFace = input * input2 * input3;
            decimal roomFace = (input4 + 0.40m) * 2 * 2;
            decimal totalRoom = Math.Floor(rocketFace / roomFace);

            if (totalRoom >=3 && totalRoom <= 10)
            {
                Console.WriteLine($"The spacecraft holds {totalRoom} astronauts.");
            }
            else if (totalRoom < 3)
            {
                Console.WriteLine("The spacecraft is too small."); 
            }
            else if (totalRoom > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }


            01.Room painting
          
            decimal input = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal input4 = decimal.Parse(Console.ReadLine());

            decimal paint = 21.50m * input;
            decimal tapeti = 5.20m * input2;
            decimal gloves = Math.Ceiling(input2 * 35m / 100m);
            decimal glovesP = gloves * input3;
            decimal brush = Math.Floor(input * 48m / 100m);
            decimal brushP = brush * input4;

            
            decimal lastP = (paint + tapeti + glovesP + brushP) *1/15;
            Console.WriteLine($"This delivery will cost {lastP:f2} lv.");
               */
        }
    }
}
