using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Fundamentals_Mid_Exam___10_July_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*https://judge.softuni.bg/Contests/Compete/Index/2996#1*/
            /*Problem1();*/
            /*Problem2();*/
            /*Problem3();*/         
        }
        private static void Problem2()
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> command = new List<string>();
            int blacklistCount = 0;
            int errorCount = 0;
            while ((command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList())[0] != "Report")
            {
                if (command[0] == "Blacklist")
                {
                    if (input.Contains(command[1]))
                    {
                        int index = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == command[1])
                            {
                                index = i;
                                break;
                            }
                        }
                        Console.WriteLine($"{command[1]} was blacklisted.");
                        input[index] = "Blacklisted";
                        blacklistCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    if (int.Parse(command[1]) > 0 && int.Parse(command[1]) < input.Count)
                    {
                        if (input[int.Parse(command[1])] != "Blacklisted" && input[int.Parse(command[1])] != "Lost")
                        {
                            Console.WriteLine($"{input[int.Parse(command[1])]} was lost due to an error.");
                            input[int.Parse(command[1])] = "Lost";
                            errorCount++;
                        }
                    }
                }
                else if (command[0] == "Change")
                {
                    if (int.Parse(command[1]) > -1 && int.Parse(command[1]) < input.Count)
                    {
                        Console.WriteLine($"{input[int.Parse(command[1])]} changed his username to {command[2]}.");
                        input[int.Parse(command[1])] = command[2];
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistCount}");
            Console.WriteLine($"Lost names: {errorCount}");
            Console.WriteLine(string.Join(' ', input));
        }
        private static void Problem1()
        {
            decimal amountProducedBiscuits = decimal.Parse(Console.ReadLine());
            decimal countOfWorkers = decimal.Parse(Console.ReadLine());
            decimal competingFactoryAoB = decimal.Parse(Console.ReadLine());
            decimal totalProduced = 0;
            totalProduced += countOfWorkers * amountProducedBiscuits * 20;
            for (int i = 0; i < 10; i++)
            {
                totalProduced += Math.Floor(countOfWorkers * (amountProducedBiscuits * 0.75m));
            }

            Console.WriteLine($"You have produced {totalProduced} biscuits for the past month.");
            if (totalProduced > competingFactoryAoB)
            {
                decimal difference = (totalProduced - competingFactoryAoB) / competingFactoryAoB * 100;
                Console.WriteLine($"You produce {difference:F2} percent more biscuits.");
            }
            else
            {
                decimal difference = (competingFactoryAoB - totalProduced);
                difference = difference / competingFactoryAoB * 100;
                Console.WriteLine($"You produce {difference:F2} percent less biscuits.");
            }
        }
        private static void Problem3()
        {
            List<string> input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> command = new List<string>();
            List<string> newDeck = new List<string>();
            while ((command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList())[0] != "Ready")
            {
                if (command[0] == "Add")
                {
                    if (input.Contains(command[1]))
                    {
                        newDeck.Add(command[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command[0] == "Insert")
                {
                    if (input.Contains(command[1]))
                    {
                        if (int.Parse(command[2]) > -1 && int.Parse(command[2]) < newDeck.Count)
                        {
                            newDeck.Insert(int.Parse(command[2]), command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (newDeck.Contains(command[1]))
                    {
                        newDeck.Remove(command[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command[0] == "Swap")
                {
                    string one = command[1];
                    string two = command[2];
                    for (int i = 0; i < newDeck.Count; i++)
                    {
                        if (newDeck[i] == one)
                        {
                            newDeck[i] = two;
                        }
                        else if (newDeck[i] == two)
                        {
                            newDeck[i] = one;
                        }
                    }
                }
                else if (command[0] == "Shuffle")
                {
                    newDeck.Reverse();
                }
            }
            Console.WriteLine(string.Join(' ', newDeck));
        }
    }
}
