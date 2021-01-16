using System;
using System.Collections.Generic;
namespace Conditional_Statements_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://softuni.bg/trainings/resources/officedocument/56721/conditional-statements-advanced-exercise-programming-basics-with-csharp-january-2021/3199
             * https://judge.softuni.bg/Contests/Compete/Index/2379#0
             * 

            01.Cinema



            string input1 = Console.ReadLine();
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());

            decimal arg = input2 * input3;
            switch (input1)
            {
                case "Premiere":
                    arg *= 12.00m;
                    break;
                case "Normal":
                    arg *= 7.50m;
                    break;
                case "Discount":
                    arg *= 5.00m;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{arg:F2} leva");


            02.Summer Outfit
           


            decimal input2 = decimal.Parse(Console.ReadLine());
            string input1 = Console.ReadLine();

            var low = new Dictionary<decimal, string>()
            {
                {18, "Sweatshirt,Sneakers,Shirt,Moccasins,Shirt,Moccasins" },
                {24, "Shirt,Moccasins,T-Shirt,Sandals,Shirt,Moccasins" },
                {25, "T-Shirt,Sandals,Swim Suit,Barefoot,Shirt,Moccasins" }
            };
            string[] splitter = { };
            if (input2 <= 18)
            {
                splitter = low[18].Split(',');
            }
            else if (input2 <= 24)
            {
                splitter = low[24].Split(',');
            }
            else
            {
                splitter = low[25].Split(',');
            }

            switch (input1)
            {
                case "Morning":
                    Console.WriteLine($"It's {input2} degrees, get your {splitter[0]} and {splitter[1]}.");
                    break;
                case "Afternoon":
                    Console.WriteLine($"It's {input2} degrees, get your {splitter[2]} and {splitter[3]}.");
                    break;
                case "Evening":
                    Console.WriteLine($"It's {input2} degrees, get your {splitter[4]} and {splitter[5]}.");
                    break;
                default:
                    break;
            }

            03.New House
           

            string input1 = Console.ReadLine();
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());

            decimal[] prices = { 5, 3.80m, 2.80m, 3, 2.50m };
            decimal checker = 0;
            if (input1 == "Roses")
            {
                if (input2 > 80)
                {
                    checker =  input2 * (prices[0] - prices[0] * 10 / 100);
                }
                else
                {
                    checker =  input2 * (prices[0]);
                }
            }
            else if (input1 == "Dahlias")
            {
                if (input2 > 90)
                {
                    checker = input2 * (prices[1] - prices[1] * 15 / 100);
                }
                else
                {
                    checker = input2 * (prices[1]);
                }
            }
            else if (input1 == "Tulips")
            {
                if (input2 > 80)
                {
                    checker = input2 * (prices[2] - prices[2] * 15 / 100);
                }
                else
                {
                    checker = input2 * (prices[2]);
                }
            }

            else if (input1 == "Narcissus")
            {
                if (input2 < 120)
                {
                    checker = input2 * (prices[3] + prices[3] * 15 / 100);
                }
                else
                {
                    checker = input2 * (prices[3]);
                }
            }

            else if (input1 == "Gladiolus")
            {
                if (input2 < 80)
                {
                    checker = input2 * (prices[4] + prices[4] * 20 / 100);
                }
                else
                {
                    checker = input2 * (prices[4]);
                }
            }
            if (input3 >= checker)
            {
                input3 -= checker;
                Console.WriteLine($"Hey, you have a great garden with {input2} {input1} and {input3:F2} leva left.");
            }
            else
            {
                checker -= input3;
                Console.WriteLine($"Not enough money, you need {checker:F2} leva more.");
            }


            04.Fishing Boat
              

            
            decimal input2 = decimal.Parse(Console.ReadLine());
            string input1 = Console.ReadLine();
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal money = input2;
            decimal price = 0;

            switch (input1)
            {

                case "Spring":
                    price = 3000;
                    break;
                case "Summer":            
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
                default:
                    break;
            }

            if (input3 <= 6)
            {
                price -= price * 10 / 100;
            }
            else if (input3<= 11)
            {
                price -= price * 15 / 100;
            }
            else
            {
                price -= price * 25 / 100;
            }

            if (input3 % 2 == 0 && input1 !="Autumn")
            {
                price -= price * 5 / 100;
            }
            if (money >= price)
            {
                money -= price;
                Console.WriteLine($"Yes! You have {money:F2} leva left.");
            }
            else
            {
                price -= money;
                Console.WriteLine($"Not enough money! You need {price:F2} leva.");
            }

            05.Journey

            

            decimal input2 = decimal.Parse(Console.ReadLine());
            string input1 = Console.ReadLine();
            decimal spend = 0;

            if (input2 <= 100)
            {
                if (input1 == "summer")
                {
                    spend= input2 * 30 / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {spend:F2}");               
                }
                else
                {
                    spend = input2 * 70 / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {spend:F2}");
                }
            }
            else if (input2 <=1000)
            {
                if (input1=="summer")
                {
                    spend = input2 * 40 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {spend:F2}");
                }
                else
                {
                    spend = input2 * 80 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {spend:F2}");
                }
            }
            else
            {
                spend = input2 * 90 / 100;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {spend:F2}");
            }


            06.Operations Between Numbers

            
            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            string input3 = Console.ReadLine();
            decimal results = 0;
            string checker = "";
            if (input3 == "+")
            {
                results = input1 + input2;
                if (results % 2 == 0)
                {
                    checker = "even";
                }
                else
                {
                    checker = "odd";
                }
                Console.WriteLine($"{input1} + {input2} = {results} - {checker}");
            }
            else if (input3 == "-")
            {
                results = input1 - input2;
                if (results % 2 == 0)
                {
                    checker = "even";
                }
                else
                {
                    checker = "odd";
                }
                Console.WriteLine($"{input1} - {input2} = {results} - {checker}");
            }
            else if (input3 == "*")
            {
                results = input1 * input2;
                if (results % 2 == 0)
                {
                    checker = "even";
                }
                else
                {
                    checker = "odd";
                }
                Console.WriteLine($"{input1} * {input2} = {results} - {checker}");
            }
            else if (input3 == "/")
            {
                if (input1 == 0)
                {
                    Console.WriteLine($"Cannot divide {input2} by zero");
                }
                else if (input2 == 0)
                {
                    Console.WriteLine($"Cannot divide {input1} by zero");
                }
                else
                {

               
                results = input1 / input2;
                
                Console.WriteLine($"{input1} / {input2} = {results:F2}");
                }
            }
            else if (input3 == "%")
            {
                if (input1 == 0)
                {
                    Console.WriteLine($"Cannot divide {input2} by zero");
                }
                else if (input2 == 0)
                {
                    Console.WriteLine($"Cannot divide {input1} by zero");
                }
                else
                {

                
                results = input1 % input2;
                
                Console.WriteLine($"{input1} % {input2} = {results}");
                }
            }

            07.Hotel Room
            
            string input1 = Console.ReadLine();
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal priceApp = 0;
            decimal priceStu = 0;

            var pricesStudio = new Dictionary<string, decimal>()
            {
                {"oct",50 },
                {"sep", 75.20m },
                {"aug", 76 }
            };
            var pricesApp = new Dictionary<string, decimal>()
            {
                {"oct",65 },
                {"sep", 68.70m },
                {"aug", 77 }
            };

            if (input1 == "May" || input1 == "October")
            {
                priceApp = pricesApp["oct"] * input2;
                priceStu = pricesStudio["oct"] * input2;
                if (input2 > 7 && input2 <= 14)
                {
                    priceStu = (pricesStudio["oct"] - pricesStudio["oct"] * 5 / 100) * input2;
                }
                else if (input2 > 14)
                {
                    priceStu = (pricesStudio["oct"] - pricesStudio["oct"] * 30 / 100) * input2 ;
                    priceApp = (pricesApp["oct"] - pricesApp["oct"] * 10 / 100) * input2 ;
                }
                
                
                Console.WriteLine($"Apartment: {priceApp:F2} lv.");
                Console.WriteLine($"Studio: {priceStu:F2} lv.");
            }
            else if (input1 == "June" || input1 == "September")
            {
                
                if (input2 > 14)
                {
                    priceStu = (pricesStudio["sep"] - pricesStudio["sep"] * 20 / 100) * input2;
                    priceApp = (pricesApp["sep"] - pricesApp["sep"] * 10 / 100) * input2;
                }
                else
                {
                    priceApp = pricesApp["sep"] * input2;
                    priceStu = pricesStudio["sep"] * input2;
                }
                Console.WriteLine($"Apartment: {priceApp:F2} lv.");
                Console.WriteLine($"Studio: {priceStu:F2} lv.");
            }
            else
            {

                if (input2 > 14)
                {
                    priceStu = pricesStudio["aug"] * input2;
                    priceApp = (pricesApp["aug"] - pricesApp["aug"] * 10 / 100) * input2;
                }
                else
                {
                    priceApp = pricesApp["aug"] * input2;
                    priceStu = pricesStudio["aug"] * input2;
                }
                Console.WriteLine($"Apartment: {priceApp:F2} lv.");
                Console.WriteLine($"Studio: {priceStu:F2} lv.");
            }
        

           
            
            08. On Time for the Exam

           



            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal input4 = decimal.Parse(Console.ReadLine());


            decimal totalTime1 = input1 * 60 + input2;
            decimal totalTime2 = input3 * 60 + input4;

            if (totalTime1 == totalTime2)
            {
                Console.WriteLine("On time");
            }
            else if (totalTime1 > totalTime2)
            {
                totalTime1 -= totalTime2;

                if (totalTime1 <= 30)
                {
                    
                        Console.WriteLine("On time");
                        Console.WriteLine($"{totalTime1} minutes before the start");
                    
                }
                else if (totalTime1 < 60)
                {
                   
                        Console.WriteLine("Early");
                        Console.WriteLine($"{totalTime1} minutes before the start");
                    
                }
                else
                {
                    int hours = (int)totalTime1 / 60;
                    int minutes = (int)totalTime1 % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
                
            }

            else if (totalTime1 < totalTime2)
            {

                totalTime2 -= totalTime1;

                if (totalTime2 <= 30)
                {

                    Console.WriteLine("Late");
                    Console.WriteLine($"{totalTime2} minutes after the start");

                }
                else if (totalTime2 < 60)
                {

                    Console.WriteLine("Late");
                    Console.WriteLine($"{totalTime2} minutes after the start");

                }
                else
                {
                    int hours = (int)totalTime2 / 60;
                    int minutes = (int)totalTime2 % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }


            }

            9.Volleyball

             */

            string input1 = Console.ReadLine();
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal output = 0;






            Console.WriteLine(output);


        }
    }
}
