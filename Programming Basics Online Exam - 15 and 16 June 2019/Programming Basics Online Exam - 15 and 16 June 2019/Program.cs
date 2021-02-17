using System;

namespace Programming_Basics_Online_Exam___15_and_16_June_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*https://judge.softuni.bg/Contests/Practice/Index/1699#1
             * 
             
             01. Movie Profit
             

            string input = Console.ReadLine();
            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal input4 = decimal.Parse(Console.ReadLine());
            decimal revenu = 0;

            decimal priceD = input2 * input3;
            decimal revP = priceD * input1;
            decimal perc = revP * input4 / 100;
            revenu = revP - perc;
            Console.WriteLine($"The profit from the movie {input} is {revenu:F2} lv.");

            02.Movie Day


           
            decimal input = decimal.Parse(Console.ReadLine());
            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());

            decimal prep = input * 15 / 100;
            decimal timeShoot = input1 * input2;
            decimal totalTimeReq = timeShoot + prep;

            if (totalTimeReq <= input)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(input - totalTimeReq)  } minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(totalTimeReq - input)  } minutes.");
            }

            03.Movie Destination
            
            decimal input = decimal.Parse(Console.ReadLine());
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            decimal input3 = decimal.Parse(Console.ReadLine());

            decimal[] winter = { 45000, 17000, 24000 };
            decimal[] summer = { 40000, 12500, 20250 };


            decimal[] pick = { 0, 0, 0 };
            int index = 0;
            bool sofia = false;
            bool dubai = false;
            //pick value
            if (input2 == "Winter")
            {
                pick = winter;
            }
            else if (input2 == "Summer")
            {
                pick = summer;
            }

            //index value
            if (input1 == "Dubai")
            {
                dubai = true;
                index = 0;
            }
            else if (input1 == "Sofia")
            {
                sofia = true;
                index = 1;
            }
            else if (input1 == "London")
            {
                index = 2;
            }

            //rest of logic
            decimal price = pick[index] * input3;
            decimal finalPrice = 0;
            decimal discount = 0;
            if (sofia == true)
            {
                discount = price * 25 / 100;
                finalPrice = price + discount;
            }
            else if (dubai == true)
            {
                discount = price * 30 / 100;
                finalPrice = price - discount;
            }
            else
            {
                finalPrice = price;
            }
            

            if (input >= finalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {input - finalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {finalPrice - input:F2} leva more!");
            }

            04. Movie Stars
             

            decimal input = decimal.Parse(Console.ReadLine());

            string input1 = Console.ReadLine();
            decimal input2 = 0;
            while (input1 != "ACTION")
            {
                if (input1.Length >15)
                {
                    input = input - (input * 20 / 100);
                }
                else
                {
                    input2 = decimal.Parse(Console.ReadLine());
                    if (input2 >= input)
                    {
                        break;
                    }
                    else
                    {
                        input -= input2;
                    }
                }
                

                input1 = Console.ReadLine();
            }
            if (input1 == "ACTION")
            {
                Console.WriteLine($"We are left with {input:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {input2 - input:f2} leva for our actors."); 
            }


            05.Oscars
           
            string input = Console.ReadLine();
            decimal input1 = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            decimal input5 = 0;
            bool win = false;
            for (int i = 0; i < input2; i++)
            {
                string input4 = Console.ReadLine();
                input5 = decimal.Parse(Console.ReadLine());
                decimal pointGiven = input4.Length * input5 / 2;
                input1 += pointGiven;
                if (input1 > 1250.5m)
                {
                    win = true;
                    break;
                }

            }
            if (win == false)
            {
                Console.WriteLine($"Sorry, {input} you need {Math.Round(1250.5m - input1, 1):F1} more!");
            }
            else
            {
                Console.WriteLine($"Congratulations, {input} got a nominee for leading role with {Math.Round(input1, 1):F1}!");
            }


            06.Movie Tickets


            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

         
            for (int i = input1; i <= input2-1; i++)
            {
                if (i%2==1)
                {
                    for (int j = 1; j <= input3 -1; j++)
                    {
                        for (int y = 1; y <= input3/2-1; y++)
                        {
                            int total = j + y + i;
                           
                            
                            if (total % 2 == 1)
                            {
                                Console.WriteLine($"{Convert.ToChar(i)}-{j}{y}{i}");
                            }
                           
                        }
                    }
                }
            }
            
             */

        }
    }
}
