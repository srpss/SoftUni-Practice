using System;
using System.Collections.Generic;
namespace thirdWeek__Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            01.Day of Week

           
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                
                default:

                    Console.WriteLine("Error");
                    break;
            }

            02.Weekend or Working Day
             
            string input = Console.ReadLine();
            switch (input)
            {
                case "Monday":             
                case "Tuesday":               
                case "Wednesday":                   
                case "Thursday":                 
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":                
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;

                default:

                    Console.WriteLine("Error");
                    break;
            }

            03.Animal Type

            
            string input = Console.ReadLine();
            switch (input)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":               
                case "tortoise":                   
                case "snake":
                    Console.WriteLine("reptile");
                    break;
               

                default:

                    Console.WriteLine("unknown");
                    break;
            }


            04.Personal Titles
            

            
            decimal age = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            switch (input)
            {
                case "m":

                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else
                    {
                        Console.WriteLine("Master");
                    }
                    
                    break;
                case "f":

                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }

                    break;
            }

            05.Small Shop
            

           
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            decimal quantaty = decimal.Parse(Console.ReadLine());

            decimal[] priceSofia = { 0.50m, 0.80m, 1.20m, 1.45m, 1.60m };
            decimal[] pricePlovdiv = { 0.40m, 0.70m, 1.15m, 1.30m, 1.50m };
            decimal[] priceVarna = { 0.45m, 0.70m, 1.10m, 1.35m, 1.55m };

            decimal[] location = { 0, 0, 0, 0, 0 };
            switch (input2)
            {
                case "Sofia":
                    location = priceSofia;
                    break;
                case "Plovdiv":
                    location = pricePlovdiv;
                    break;
                case "Varna":
                    location = priceVarna;
                    break;
                default:
                    break;
            }

            decimal commodity = 0;

            switch (input)
            {
                case "coffee" :
                    commodity = location[0];
                    break;
                case "water":
                    commodity = location[1];
                    break;
                case "beer":
                    commodity = location[2];
                    break;
                case "sweets":
                    commodity = location[3];
                    break;

                case "peanuts":
                    commodity = location[4];
                    break;
                default:
                    break;
            }

            decimal alg = quantaty * commodity;
            Console.WriteLine(alg);

            06.Number in Range
           

            decimal input = decimal.Parse(Console.ReadLine());


            if (input > 0 && input <= 100|| input < 0 && input >= -100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            07.Working Hours
             

            decimal input1 = decimal.Parse(Console.ReadLine());
            string input2 = Console.ReadLine();

            if (input1 < 10 || input1 >= 18)
            {
                Console.WriteLine("closed");
            }
            else
            {
                switch (input2)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;

                    default:
                        break;
                }
            }

            
            08.Cinema Ticket
            


            var daysPrice = new Dictionary<string, string>()
            {
    {"Monday", "12"},
    {"Tuesday", "12"},
    {"Wednesday", "14"},
    {"Thursday", "14"},
    {"Friday", "12"},
    {"Saturday", "16"},
    {"Sunday", "16"}
    
            };
            string input = Console.ReadLine();
            string output = daysPrice[input];
            Console.WriteLine($"{output}");
            
             
             09. Fruit or Vegetable
             

            string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegy = { "tomato", "cucumber", "pepper", "carrot"};

            string input = Console.ReadLine();
            bool check = false;
            
            while (check == false)
            {

            
            for (int i = 0; i < fruits.Length; i++)
            {
                if (input == fruits[i])
                {
                    Console.WriteLine("fruit");
                        check = true;
                    break;
                }
            }
            for (int i = 0; i < vegy.Length; i++)
            {
                if (input == vegy[i])
                {
                    Console.WriteLine("vegetable");
                        check = true;
                        break;
                }
            }
                if (check == false)
                {
                    Console.WriteLine("unknown");
                    check = true;
                }
                
            }

            10.Invalid Number
            


            decimal input1 = decimal.Parse(Console.ReadLine());

            if (input1 >= 100 && input1 <=200 || input1 == 0)
            {
                
            }
            else
            {
                Console.WriteLine("invalid");
            }


            11.Fruit Shop
            

            var daysWork = new Dictionary<string, decimal>()
            {

                {"banana", 2.50m },
                {"apple", 1.20m },
                {"orange", 0.85m },
                {"grapefruit", 1.45m },
                {"kiwi", 2.70m },
                {"pineapple", 5.50m },
                {"grapes", 3.85m }
            };
            var daysWeekend = new Dictionary<string, decimal>()
            {

                {"banana", 2.70m },
                {"apple", 1.25m },
                {"orange", 0.90m },
                {"grapefruit", 1.60m },
                {"kiwi", 3.00m },
                {"pineapple", 5.60m },
                {"grapes", 4.20m }
            };


            var weekDays = new Dictionary<string, string>
            {
                {"Monday","Monday" },
                {"Tuesday","Tusday" },
                {"Wednesday","Wednesday" },
                {"Thursday","Thursday" },
                {"Friday","Friday" },
                {"Saturday","Saturday" },
                {"Sunday","Sunday" }
            };
            bool checker = false;

            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (daysWork.ContainsKey(input) == false  || weekDays.ContainsKey(input2)== false)
            {
                Console.WriteLine("error");
                
            }
            else
            {

            
            
            decimal quantaty = decimal.Parse(Console.ReadLine());
            if (input2 == "Saturday" || input2 =="Sunday")
            {
                checker = true;
            }
            decimal arg = 0;
            if (checker == true)
            {
                decimal price = daysWeekend[input];
                arg = quantaty * price;
            }
            else
            {
                decimal price = daysWork[input];
                arg = quantaty * price;
            }
            Console.WriteLine($"{arg:F2}");
            }

            12.Trade Commissions
            

            string input = Console.ReadLine();
            decimal input2 = decimal.Parse(Console.ReadLine());

            decimal [] sofia = { 5 , 7, 8, 12 };
            decimal[] varna = { 4.5m, 7.5m , 10, 13  };
            decimal[] plovdiv = { 5.5m, 8 , 12, 14.5m };
            bool negative = false;
            int sum = 0;
            if (input2 < 0)
            {
                negative = true;
                Console.WriteLine("error");
                
            }
             else if (input2 <= 500)
            {
                sum = 0;
            }
            else if (input2 > 500 && input2 <= 1000)
            {
                sum = 1;
            }
            else if (input2 > 1000 && input2 <= 10000)
            {
                sum = 2;
            }
            else
            {
                sum = 3;
            }
            
            
            if (negative != true)
            {

            
            decimal arg = 0;
            bool checker = false;
            switch (input)
            {
                case "Sofia":
                    arg = input2 * sofia[sum]/100; 
                    break;
                case "Varna":
                    arg = input2 * varna[sum] / 100;
                    break;
                case "Plovdiv":
                    arg = input2 * plovdiv[sum] / 100;
                    break;
                default:
                    checker = true;
                    Console.WriteLine("error");
                    break;
            }
            if (checker == false)
            {
                Console.WriteLine($"{arg:F2}");
            }
            }
            

            13.Ski Trip
           
            decimal input = decimal.Parse(Console.ReadLine())- 1;
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            decimal[] apartment = { 30, 35, 50 };
            decimal[] presApartment = { 10, 15, 20 };
            int days = 0;
            if (input < 10)
            {
                days = 0;
            }
            else if (input < 15)
            {
                days = 1;
            }
            else
            {
                days = 2;
            }
            decimal arg = 0;
            switch (input2)
            {
                case "apartment":
                    arg = input * 25.00m;
                    arg = arg - arg * apartment[days] / 100;
                    break;
                case "president apartment":
                    arg = input * 35.00m;
                    arg = arg - arg * presApartment[days] / 100;
                    break;
                default:
                    arg = input * 18.00m;
                    break;
            }
            if (input3 == "positive")
            {
                arg = arg + arg * 25 / 100;
            }
            else
            {
                arg = arg - arg * 10 / 100;
            }

            Console.WriteLine($"{arg:F2}");
             */
        }
    }
}
