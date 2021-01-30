using System;
using System.Collections.Generic;
namespace Programming_Basics_Online_Exam___20_and_21_April_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://judge.softuni.bg/Contests/1637/Programming-Basics-Online-Exam-20-and-21-April-2019
            // 01.Easter Lunch

            // Козунак – 3.20 лв.
            //• Яйца – 4.35 лв.за кора с 12 яйца
            //• Курабии – 5.40 лв.за килограм
            //• Боя за яйца - 0.15 лв.за яйце

            //decimal input1 = decimal.Parse(Console.ReadLine());
            //decimal input2 = decimal.Parse(Console.ReadLine());
            //decimal input3 = decimal.Parse(Console.ReadLine());

            //decimal priceK = input1 * 3.20m;
            //decimal priceE = input2 * 4.35m;
            //decimal priceKu = input3 * 5.40m;
            //decimal priceDE = input2 * 12 * 0.15m;
            //decimal totalP = priceK + priceE + priceKu + priceDE;

            //Console.WriteLine($"{totalP:F2}");

            //02.Easter Party

            //decimal input1 = decimal.Parse(Console.ReadLine());
            //decimal input2 = decimal.Parse(Console.ReadLine());
            //decimal input3 = decimal.Parse(Console.ReadLine());
            //decimal per = 0;
            //if (input1 < 10)
            //{

            //}
            //else if (input1 >= 10 && input1 <= 15)
            //{
            //    per = 15;
            //}
            //else if (input1 <= 20)
            //{
            //    per = 20;
            //}
            //else if (input1 > 20)
            //{
            //    per = 25;
            //}

            //decimal discound = input2 - input2 * per / 100;
            //decimal cakePrice = input3 * 10 / 100;
            //decimal totalSum = input1 * discound + cakePrice;

            //if (totalSum <= input3)
            //{
            //    Console.WriteLine($"It is party time! {input3- totalSum:F2} leva left.");
            //}
            //else
            //{
            //    Console.WriteLine($"No party! {totalSum - input3:F2} leva needed.");
            //}

            //03.Easter Trip
            /*
            decimal[] germany = {32, 37, 43 };
            decimal[] italy = { 28, 32, 39 };
            decimal[] france = { 30, 35, 40 };

            string destination = Console.ReadLine();
            decimal[] input = {0,0,0};
            if (destination == "Germany")
            {
                input = germany;
            }
            else if (destination == "France")
            {
                input = france;
            }
            else if (destination == "Italy")
            {
                input = italy;
            }
            string dates = Console.ReadLine();
            int index = 0;
            if (dates == "21-23")
            {
                index = 0;
            }
            else if (dates == "24-27")
            {
                index = 1;
            }
            else if (dates == "28-31")
            {
                index = 2;
            }
            decimal nights = decimal.Parse(Console.ReadLine());




            Console.WriteLine($"Easter trip to {destination} : {nights * input[index]:F2} leva.");


            04.Easter Eggs Battle

              

            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            bool check = false;
            string input3 = Console.ReadLine();

            while (input3 != "End of battle")
            {
                if (input3 == "one")
                {
                    input2--;
                    if (input2 == 0)
                    {

                        check = true;
                        break;
                        
                    }
                }
                else if (input3 =="two")
                {
                    input1--;
                    if (input1 == 0)
                    {
                        check = false;
                        break;
                        
                    }
                }

               

                input3 = Console.ReadLine();
            }
            if (input3 == "End of battle")
            {
                Console.WriteLine($"Player one has {input1} eggs left.");
                Console.WriteLine($"Player two has {input2} eggs left.");
            }
            else if (check == true)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {input1} eggs left.");
            }
            else
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {input2} eggs left.");
            }


            05. Easter Eggs
              

            var eggs = new Dictionary<string, decimal>()
            {
                {"Red eggs", 0 },
                {"Orange eggs", 0 },
                {"Blue eggs", 0 },
                {"Green eggs", 0 },
                {"Max eggs", 0 },
            };
            
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                string egg = Console.ReadLine();
                switch (egg)
                {
                    case "red":
                        eggs["Red eggs"]++;
                        break;
                    case "orange":
                        eggs["Orange eggs"]++;
                        break;
                    case "blue":
                        eggs["Blue eggs"]++;
                        break;
                    case "green":
                        eggs["Green eggs"]++;
                        break;
                    default:
                        break;
                }
                
               
            }

            decimal x = Math.Max(Math.Max(Math.Max(eggs["Red eggs"], eggs["Orange eggs"]), eggs["Blue eggs"]), eggs["Green eggs"]);
            string maxColor = "";
            if (x == eggs["Red eggs"])
            {
                maxColor = "red";
            }
            else if (x == eggs["Blue eggs"])
            {
                maxColor = "blue";
            }
            else if (x == eggs["Orange eggs"])
            {
                maxColor = "Orange";
            }
            else if (x == eggs["Green eggs"])
            {
                maxColor = "green";
            }
            {

            }
            Console.WriteLine($"Red eggs: {eggs["Red eggs"]}\nOrange eggs: {eggs["Orange eggs"]}\nBlue eggs: {eggs["Blue eggs"]}\nGreen eggs: {eggs["Green eggs"]}\nMax eggs: {x} -> {maxColor}");

            06.Easter Competition
           
            int total = int.Parse(Console.ReadLine());
            string name = "";
            decimal highScore = 0;
            string highName = "";
            for (int i = 0; i < total; i++)
            {
                name = Console.ReadLine();
                string score = (Console.ReadLine());
                decimal scoreInt = 0;
                while (score != "Stop")
                {
                     scoreInt += decimal.Parse(score);
                     

                    score = (Console.ReadLine());
                }
                Console.WriteLine($"{name} has {scoreInt} points.");
                if (highScore < scoreInt)
                {
                    Console.WriteLine($"{name} is the new number 1!");
                    highName = name;
                    highScore = scoreInt;
                }
            }
            Console.WriteLine($"{highName} won competition with {highScore} points!");
             */

        }
    }
}
