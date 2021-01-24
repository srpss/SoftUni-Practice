using System;

namespace Nested_Loops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             01. Clock
             
           
            

           
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
              
            }

            02.Multiplication Table


             
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

            }


            03.Combinations
            

            int input = int.Parse(Console.ReadLine());
            int counter =0;
            for (int i = 0; i <= input; i++)
            {
                for (int j = 0; j <= input; j++)
                {
                    for (int p = 0; p <= input; p++)
                    {
                        if (i + j + p == input)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);


            04.Sum of Two Numbers
            

            int input = int.Parse(Console.ReadLine());
            int inputEnd = int.Parse(Console.ReadLine());

            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            bool end = false;
            for (int i = input; i <= inputEnd; i++)
            {
                for (int j = input; j <= inputEnd; j++)
                {
                    counter++;
                    if (i + j == magic)
                    {
                        input = i;
                        inputEnd = j;

                        end = true;
                        break;
                    }
                    
                }
                if (end == true)
                {
                    break;
                }
            }
            if (end == true)
            {
                Console.WriteLine($"Combination N:{counter} ({input} + {inputEnd} = {magic})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }

            05.Travelling
           

            string destination = Console.ReadLine();
            bool term = false;
            decimal budget = 0;
            bool test = false;
            decimal money = 0;
            if (destination == "End")
            {
                term = true;
                
            }
            else
            {
                 budget = int.Parse(Console.ReadLine());
                
            }
            
            while (destination != "End")
            {
                if (term == true)
                {
                    break;
                }
                while (money < budget)
                {
                    string input123 = Console.ReadLine();
                    if (input123 == "End")
                    {
                        test = true;
                        break;
                    }
                    money += decimal.Parse(input123);


                }
                if (test == true)
                {
                    break;
                }
                Console.WriteLine($"Going to {destination}!");
                    destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                string budget123 = Console.ReadLine();
                if (budget123 == "End")
                {
                    break;
                }
                else
                {
                    budget = decimal.Parse(budget123);
                }
                    
                money = 0;
            }

            06.Building
            

            int input = int.Parse(Console.ReadLine());
            int inputEnd = int.Parse(Console.ReadLine());
            string[] building = new string [input];
            int app = 0;
            int off = 0;
            int lag = 0;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < inputEnd; j++)
                {
                    if (i % 2 == 1 && i != input)
                    {
                        building[i-1] += $"A{i}{app} ";
                        app++;
                    }
                    else if (i % 2 == 0 && i != input)
                    {
                        building[i-1] += $"O{i}{off} ";
                        off++;
                    }
                    else if (i == input)
                    {
                        building[i-1] += $"L{i}{lag} ";
                        lag++;
                    }
                }
                app = 0;
                off = 0;
                lag = 0;
            }
            for (int i = building.Length- 1; i >= 0; i--)
            {
                Console.WriteLine(building[i]);
            }

            07.Cinema Tickets
            

            string input = Console.ReadLine();
            decimal tickets = decimal.Parse(Console.ReadLine());

            decimal total = 0;
            decimal student = 0;
            decimal standard = 0;
            decimal kid = 0;
            while (input != "Finish")
            {
                

                for (int i = 0; i < tickets; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        Console.WriteLine($"{input} - {i/tickets* 100:F2}% full.");
                        break;
                    }
                    if (ticketType == "student")
                    {
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        standard++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                    }
                    
                    total++;
                   
                    
                    if (i == tickets- 1)
                    {
                        Console.WriteLine($"{input} - 100.00% full.");
                    }
                }
                input = Console.ReadLine();
                if (input == "Finish")
                {
                    break;
                }
                tickets = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total tickets: " + total);
            Console.WriteLine($"{student / total * 100:F2}% student tickets.");
            Console.WriteLine($"{standard/ total * 100:F2}% standard tickets.");
            Console.WriteLine($"{kid/ total * 100:F2}% kids tickets.");

             */
        }
    }
}
