using System;
using System.Collections.Generic;
namespace Programming_Basics_Online_Exam___9_and_10_March_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.bg/Contests/Practice/Index/1538#0
            //01.Basketball Equipment
            /* 

            decimal input = decimal.Parse(Console.ReadLine());
            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());

            decimal rocketP = input1 * input;
            decimal marP = input * 1 / 6;
            decimal totalMar = marP * input2;
            decimal restP = (rocketP + totalMar) * 0.2m;
            decimal total = rocketP + totalMar + restP;


           
                Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(total * 1/8)}");
            
                Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(total * 7/8)}");
            
            02. Skeleton
           


            decimal input = decimal.Parse(Console.ReadLine());
            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());

            decimal controlS = input * 60 + input1;
            decimal timeD = (input2 / 120);
            decimal totalD = timeD * 2.5m;
            decimal timeM = ((input2 / 100) * input3) - totalD;
            if (controlS >= timeM)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!\nHis time is {timeM:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {timeM - controlS:F3} second slower.");
            }

            03.World Snooker Championship
           

            decimal[] standard = {55.50m, 75.88m, 110.10m };
            decimal[] prem = { 105.20m, 125.22m, 160.66m };
            decimal[] vip = { 118.90m, 300.40m, 400 };

            string input = Console.ReadLine();
            string input1 = Console.ReadLine();
            decimal input2 = decimal.Parse(Console.ReadLine());
            string input3 = Console.ReadLine();
            bool checker = true;
            decimal[] type = {0,0,0 };
            int index = 0;

            //pricing setup
            if (input1 == "Standard")
            {
                type = standard;
            }
            else if (input1 == "Premium")
            {
                type = prem;
            }
            else if (input1 == "VIP")
            {
                type = vip;
            }

            //index setup
            if (input == "Quarter final")
            {
                index = 0;
            }
            else if (input == "Semi final")
            {
                index = 1;
            }
            else if (input == "Final")
            {
                index = 2;
            }

            //total price
            decimal totalT = type[index] * input2;

            //check for discount
            if (totalT > 4000)
            {
                totalT = totalT - totalT * 25 / 100;
                checker = false;
            }
            else if (totalT > 2500)
            {
                totalT = totalT - totalT * 10 / 100;
            }

            //phone price check
            if (input3 == "Y" && checker == true)
            {
                totalT += 40 * input2;
            }
            Console.WriteLine($"{totalT:F2}");

            04.Darts
              

            string input = Console.ReadLine();


            string input1 = Console.ReadLine();
            int hits = 0;
            int miss = 0;
            decimal points = 301;
            if (input1 == "Retire")
            {
                
            }
            else
            {
           

            while (input1 != "Retire")
            {
                    decimal input2 = decimal.Parse(Console.ReadLine());
                    decimal realP = 0;

                    if (input1 == "Single")
                    {
                         realP = input2;
                    }
                    else if (input1 == "Double")
                    {
                        realP = input2 *2;
                    }
                    else if (input1 == "Triple")
                    {
                        realP = input2 * 3;
                    }
                   
                    if (points >= realP)
                    {
                        points -= realP;
                        hits++;
                        if (points == 0)
                        {
                            break;
                        }
                    }
                    else if (points < realP)
                    {
                        miss++;
                    }

                input1 = Console.ReadLine();
                
            }

            }

            if (input1 != "Retire")
            {
                Console.WriteLine($"{input} won the leg with {hits} shots."); 
            }
            else
            {
                Console.WriteLine($"{input} retired after {miss} unsuccessful shots."); 
            }


            05.Fitness Center
           

            
            decimal input = decimal.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int shake = 0;
            int bar = 0;
            for (int i = 0; i < input; i++)
            {
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    case "Back":
                        back++;
                        break;
                    case "Chest":
                        chest++;
                        break;
                    case "Legs":
                        legs++;
                        break;
                    case "Abs":
                        abs++;
                        break;
                    case "Protein shake":
                        shake++;
                        break;
                    case "Protein bar":
                        bar++;
                        break;
                    default:
                        break;
                }
            }

            decimal total = back + chest + legs + abs + shake + bar;
            decimal workout = back + chest + legs + abs;
            decimal merch = shake + bar;
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest"); 
            Console.WriteLine($"{legs} - legs"); 
            Console.WriteLine($"{abs} - abs"); 
            Console.WriteLine($"{shake} - protein shake"); 
            Console.WriteLine($"{bar} - protein bar"); 
            Console.WriteLine($"{workout / total * 100:f2}% - work out"); 
            Console.WriteLine($"{merch/total * 100:f2}% - protein");


            06.Basketball Tournament
             
            string input = Console.ReadLine();
            decimal total = 0;
            decimal win = 0;
            decimal loss = 0;
            while (input != "End of tournaments" )
            {

                decimal input1 = decimal.Parse(Console.ReadLine());
                for (int i = 1; i <= input1; i++)
                {
                    decimal input2 = decimal.Parse(Console.ReadLine());
                    decimal input3 = decimal.Parse(Console.ReadLine());
                    if (input2 > input3)
                    {
                        Console.WriteLine($"Game {i} of tournament {input}: win with {input2 - input3} points.");
                        win++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {input}: lost with {input3 - input2} points.");
                        loss++;
                    }

                    total++;
                }

                input = Console.ReadLine();
            }
            
                Console.WriteLine($"{win/total * 100:f2}% matches win");
                Console.WriteLine($"{loss / total * 100:f2}% matches lost");
            
            */
        }
    }
}
