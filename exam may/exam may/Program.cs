using System;

namespace exam_may
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             01. Food Delivery
             https://judge.softuni.bg/Contests/Practice/Index/1654#0
             Programming Basics Online Retake Exam - 2 and 3 May 2019
             
            decimal totalChi = decimal.Parse(Console.ReadLine());
            decimal totalFish = decimal.Parse(Console.ReadLine());
            decimal vegi = decimal.Parse(Console.ReadLine());


            decimal priceChi = totalChi * 10.35m;
            decimal priceFish = totalFish * 12.40m;
            decimal priceVegi = vegi * 8.15m;
            decimal totalPrice = priceChi + priceFish + priceVegi;
            decimal priceDesert = totalPrice * 20 / 100;
            decimal totaltotalPrice = 2.5m + totalPrice + priceDesert;

            Console.WriteLine($"Total: {totaltotalPrice:F2}");


            02.Safari
            
             

            decimal budget = decimal.Parse(Console.ReadLine());
            decimal fuel = decimal.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            decimal fuelPrice = fuel * 2.10m;
            decimal total = fuelPrice + 100;



            if (dayOfWeek == "Saturday")
            {
                total -= total * 10 / 100;
            }
            else if (dayOfWeek =="Sunday")
            {
                total -= total * 20 / 100;
            }
            else
            {
                
            }
            if (total <= budget)
            {
                Console.WriteLine($"Safari time! Money left: {budget- total} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {total - budget} lv.");
            }

            03.Mobile operator
            

            decimal[] oneYear = {9.98m, 16.99m, 25.98m, 35.99m };
            decimal[] twoYear = { 8.58m, 17.09m, 23.59m, 31.79m };

            string years = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            decimal months = decimal.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            decimal[] prices = { 0,0,0,0};
            int index = 0;
            decimal inetTax = 0;
           
            switch (years)
            {
                case "one":
                    prices = oneYear;
                    break;
                case "two":
                    prices = twoYear;
                    break;
                default:
                    break;
            }
            switch (type)
            {
                case "Small":
                    index = 0;
                    break;
                case "Middle":
                    index = 1;
                    break;
               
                case "Large":
                    index = 2;
                    break;
                case "ExtraLarge":
                    index = 3;
                    break;
                
                default:
                    break;
            }

            if (internet == "yes")
            {
                if (prices[index] <= 10)
                {
                    inetTax = 5.50m;
                }
                else if (prices[index] <= 30)
                {
                    inetTax = 4.35m;
                }
                else if (prices[index] > 30)
                {
                    inetTax = 3.85m;
                }
            }
            
            totalPrice = (inetTax + prices[index]) * months;
            if (years == "two")
            {
                totalPrice -= totalPrice * 3.75m / 100;
            }
            Console.WriteLine($"{totalPrice:F2} lv.");

            04.Tourist Shop



          

            decimal budget = decimal.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            string name = Console.ReadLine();

            if (name == "Stop")
            {
                Console.WriteLine($"You bought 0 products for {0:F2} leva.");
            }
            else
            {

            
            decimal price= decimal.Parse(Console.ReadLine());
            totalPrice += price;
            bool exceed = false;
            int counter = 1;
            while (name != "Stop" && totalPrice < budget)
            {
                
                name = Console.ReadLine();
               
                if (name == "Stop")
                {
                    break;
                }
                counter++;
                price = decimal.Parse(Console.ReadLine());
                if (counter % 3 == 0)
                {
                    price = price / 2;
                }
                totalPrice += price;
                if (totalPrice > budget)
                {
                    exceed = true;
                    break;
                }
                
               

            }

            if (exceed == false)
            {
                Console.WriteLine($"You bought {counter} products for {totalPrice:F2} leva.");
            }
            else if (exceed == true)
            {
                Console.WriteLine($"You don't have enough money!\nYou need {totalPrice- budget:F2} leva!");
            }
            }
             


            decimal input = decimal.Parse(Console.ReadLine());
            decimal counter2 = 0;
            decimal counter3 = 0;
            decimal counter4 = 0;

            for (int i = 0; i < input; i++)
            {
                decimal input1 = decimal.Parse(Console.ReadLine());

                if (input1 % 2 == 0)
                {
                     counter2  ++;
                }
                if (input1 % 3 == 0)
                {
                     counter3  ++;
                }
                if (input1 % 4 == 0)
                {
                     counter4  ++;
                }
            }

            Console.WriteLine($"{(counter2 / input) *100:F2}%");
            Console.WriteLine($"{(counter3 / input) * 100:F2}%");
            Console.WriteLine($"{(counter4 / input) * 100:F2}%");

            06.Vet Parking
             

            decimal input = decimal.Parse(Console.ReadLine());
            decimal hours = decimal.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 1; i <= input; i++)
            {
                decimal price = 0;
                
                for (int f = 1; f <= hours; f++)
                {
                    if (i % 2== 0)
                    {
                        if (f % 2 == 1)
                        {
                            price += 2.5m;
                        }
                        else
                        {
                            price += 1;
                        }
                    }
                    else
                    {
                        if (f % 2 == 0)
                        {
                            price += 1.25m;
                        }
                        else
                        {
                            price += 1;
                        }
                    }
                }
                Console.WriteLine($"Day: {i} - {price:F2} leva");
                total += price;
            }
            Console.WriteLine($"Total: {total:F2} leva");
            */
        }
    }
}
