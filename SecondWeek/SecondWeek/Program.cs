using System;

namespace SecondWeek
{
    class Program
    {
        static void Main()
        {
            /* 01.Excellent Result
             *
            decimal input = decimal.Parse(Console.ReadLine());
            if (input >= 5.5m)
            {
                Console.WriteLine("Excellent!");
            }

            02.Greater Number

             

            decimal input = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            if (input >= input2)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input2);
            }

            03.Even or Odd

            

            decimal input = decimal.Parse(Console.ReadLine());

            if (input % 2== 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        04. Number 100...200
            


            decimal input = decimal.Parse(Console.ReadLine());

            if (input < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (input >= 100 && input <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }

              
            

        05. Password Guess





            string input = Console.ReadLine();
            if (input == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

            06.Area of Figures

            

            string input = Console.ReadLine();

            decimal input2 = 0;
            decimal input3 = 0;
            double area = 0;
            switch (input)
            {
                case "square":
                    input2 = decimal.Parse(Console.ReadLine());
                    
                    area = Math.Pow((double)input2, 2);
                    Console.WriteLine($"{area:F3}");

                    break;
                case "rectangle":
                    input2 = decimal.Parse(Console.ReadLine());
                    input3 = decimal.Parse(Console.ReadLine());
                    area = (double)input2 * (double)input3;
                    Console.WriteLine($"{area:F3}");
                    break;
                case "circle":
                    input2 = decimal.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow((double)input2, 2);
                    Console.WriteLine($"{area:F3}");
                    break;
                case "triangle":
                    input2 = decimal.Parse(Console.ReadLine());
                    input3 = decimal.Parse(Console.ReadLine());
                    area = (double)input2 * (double)input3 / 2;
                    Console.WriteLine($"{area:F3}");
                    break;

                default:
                    break;
            }

            07.Toy Shop
            
            
            decimal vacation = decimal.Parse(Console.ReadLine());
            decimal puzzel = decimal.Parse(Console.ReadLine());
            decimal dolls = decimal.Parse(Console.ReadLine());
            decimal bears = decimal.Parse(Console.ReadLine());
            decimal minions = decimal.Parse(Console.ReadLine());
            decimal busses = decimal.Parse(Console.ReadLine());
            decimal moneyLeft = 0;
            decimal totalMoney = 0;
            decimal totalToys = puzzel + dolls + bears + minions + busses;
            totalMoney = puzzel * 2.60m + dolls * 3m + bears * 4.10m + minions * 8.20m + busses * 2m;

            if (totalToys >= 50)
            {
                totalMoney = totalMoney - (totalMoney * 25 / 100);
            }
            totalMoney = totalMoney - (totalMoney * 10 / 100);

            if (totalMoney >= vacation)
            {
                moneyLeft = totalMoney - vacation;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                moneyLeft = vacation - totalMoney;
                Console.WriteLine($"Not enough money! {moneyLeft:F2} lv needed.");
            }

            


            01.Sum Seconds
            
            int input1 = int.Parse(Console.ReadLine());
            
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            int totalTime = input3 + input1 + input2;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60 ;

            if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }



            02.Bonus Score
            


            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal bonusPoints = 0;
            if (input1 <= 100m)
            {
                
                bonusPoints += 5m;
            }
            else if (input1 > 100 && input1 <= 1000m)
            {
                
                bonusPoints += (input1 * 20m / 100m);
            }
            else
            {
                
                bonusPoints += (input1 * 10m / 100m);

            }



            if (input1 % 2 == 0)
            {
                
                bonusPoints += 1;
            }
            if (input1 % 10 == 5)
            {

                bonusPoints += 2;
            }
                input1 += bonusPoints;
            
            Console.WriteLine(bonusPoints);
            Console.WriteLine(input1);

            03.Speed Info
            


            decimal input1 = decimal.Parse(Console.ReadLine());

            if (input1 <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (input1 <= 50)
            {
                Console.WriteLine("average");
            }
            else if (input1 <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (input1 <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }

           
            04.Metric Converter

             
            decimal input1 = decimal.Parse(Console.ReadLine());
            string input2 =Console.ReadLine();
            string input3 = Console.ReadLine();
            decimal converter = 0;
            if (input2 == "cm" && input3 =="mm")
            {
                converter += input1 * 10;
                
            }
            else if (input2 == "m" && input3 == "mm")
            {
                converter += input1 * 1000;
                
            }
            else if (input2 == "mm" && input3 == "cm")
            {
                converter += input1 / 10;
                
            }
            else if (input2 == "m" && input3 == "cm")
            {
                converter += input1 * 100;
                
            }
            else if (input2 == "mm" && input3 == "m")
            {
                converter += input1 / 1000;
                
            }
            else if (input2 == "cm" && input3 == "m")
            {
                converter += input1 / 100;
                
            }
            Console.WriteLine($"{converter:F3}");

            05. Time + 15 Minutes
           


            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal hours = input1;
            decimal minutes = 0;
            if ((input2 + 15m) >= 60 )
            {
                hours += 1;
                minutes += (input2 + 15) % 60;
            }
            else
            {
                minutes += input2 + 15;
            }

            if (hours >= 24)
            {
                hours = hours % 24;
            }
            if (minutes >= 10)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }

            06.Godzilla vs.Kong
               

            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal money = input1;
            decimal moneyNeeded = 0;

            decimal decore = input1 * 10 / 100;
            if (input2 > 150)
            {
                input3 = input3 - (input3 * 10 / 100);
            }
            decimal clothPrice = input2 * input3;
            moneyNeeded = decore + clothPrice;
            if (money >= moneyNeeded)
            {

                money= money - moneyNeeded;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {money:F2} leva left.");
            }
            else
            {
                moneyNeeded = moneyNeeded - money;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }

            07.World Swimming Record

             

            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            
            decimal timeNeeded = 0;

             timeNeeded = input2 * input3;
            decimal bonusTime = Math.Floor((input2 / 15)) * 12.5m;
            timeNeeded += bonusTime;

            if (input1 > timeNeeded)
            {

              
                
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeNeeded:F2} seconds.");
            }
            else
            {
                timeNeeded = timeNeeded - input1;
                
                Console.WriteLine($"No, he failed! He was {timeNeeded:F2} seconds slower.");
            }


            08. Scholarship
            */

            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());

            decimal money1 = 0;
            decimal money2 = 0;
            bool check1 = false;
            bool check2 = false;
            if (input1 < input3 && input2 > 4.50m)
            {
                money1 = input3 * 35 / 100;
                check1 = true;
            }

            if (input2 >= 5.50m)
            {
                money2 = input2 * 25 / 100;
                check1 = true;
            }

            if (check1== false && check2 ==false)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (check1== true && check2== false || money1 > money2)
            {
                Console.WriteLine($"You get a Social scholarship {money1} BGN");
            }
            else if (check1 == false && check2 == true || money1 < money2)
            {
                Console.WriteLine($"You get a scholarship for excellent results {money2} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
           
        }

    }
    }
