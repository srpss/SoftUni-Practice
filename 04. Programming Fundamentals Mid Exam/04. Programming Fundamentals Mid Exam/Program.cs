using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Programming_Fundamentals_Mid_Exam
{
    class Program
    {
        static void Main()
        {
            //https://judge.softuni.bg/Contests/Practice/Index/2031#0
            //01. National Court
            /* 
            theProgram();


            void theProgram()
            {
                int input = int.Parse(Console.ReadLine());
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                int efficient = int.Parse(Console.ReadLine());

                int answered = 0;
                int answerPerHour = input + input1 + input2;
                int hour = 0;
                int timeOff= 0;

                while (answered < efficient)    
                { 
                    hour++;
                    timeOff++;
                    if (timeOff == 4)
                    {

                        timeOff = 0;
                        
                    }
                    else
                    {
                        answered += answerPerHour;
                    }
                   
                }
                Console.WriteLine($"Time needed: {hour}h.");
            }
            

            02.Shopping List
             
            List<string> splitter( string command)
            {
                List<string> commands = command
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .ToList();
                return commands;
            }

            List<string> input = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {

                List<string> commands = splitter(command);
                
                switch (commands[0])
                {

                    
                    case "Urgent":
                        if (input.Contains(commands[1]))
                        {
                            break; 
                        }
                        else
                        {
                            input.Insert(0, commands[1]);
                        }
                        break;
                    case "Unnecessary":
                        if (input.Contains(commands[1]))
                        {
                            input.Remove(commands[1]);
                        }
                        
                        break;
                    case "Correct":
                        if (input.Contains(commands[1]))
                        {
                            for (int i = 0; i < input.Count; i++)
                            {
                                if (input[i] == commands[1])
                                {
                                    input[i] = commands[2];
                                }
                            }
                        }
                        break;
                    case "Rearrange":
                        if (input.Contains(commands[1]))
                        {
                            input.Remove(commands[1]);
                            input.Add(commands[1]);
                        }
                        break;
                    default:
                        break;
                }
                

              
            }
            Console.WriteLine(string.Join(", ",input));
        
      
        03. Heart Delivery
            */
            List<string> splitter(string command)
            {
                List<string> commands = command
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .ToList();
                return commands;
            }

            List<int> input = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();
            
            string command;
            
            int currentPos = 0;
            
            int[] checker = new int [input.Count];
            for (int i = 0; i < checker.Length; i++)
            {
                checker[i] = 0;

            }
            
            while ((command = Console.ReadLine()) != "Love!")
            {
                List<string> commands = splitter(command);
                currentPos += int.Parse(commands[1]);
                if (currentPos >= input.Count)
                {
                    currentPos = 0;
                }
                
                input[currentPos] -= 2;
                if (input[currentPos] <= 0)
                {
                    if (checker[currentPos] == 0)
                    {
                        Console.WriteLine($"Place {currentPos} has Valentine's day.");
                        checker[currentPos] = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Place {currentPos} already had Valentine's day.");
                    }
                    
                }
            }
            Console.WriteLine($"Cupid's last position was {currentPos}.");
            
            int [] fail = checker.Where(n => n == 0).ToArray();
            if (fail.Contains(0))
            {
                 
                Console.WriteLine($"Cupid has failed {fail.Length} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
    }

    

