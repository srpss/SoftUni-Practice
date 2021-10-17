using System;
using System.Collections.Generic;
using System.Linq;

namespace SkiRental
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.org/Contests/Practice/Index/3088#0
            //https://judge.softuni.org/Contests/Practice/Index/3020#1
            //_01_BirthdayCelebration();
            //_02_Survivor();
            _03_SkiRental();
        }

        private static void _03_SkiRental()
        {
            // Initialize the repository
            SkiRental skiRental = new SkiRental("New Alpine ski rental", 5);

            // Initialize entity
            Ski firstSkiSet = new Ski("Rossignol", "XC70", 2017);

            // Print Ski
            Console.WriteLine(firstSkiSet); // Rossignol - XC70 - 2017

            // Add Ski
            skiRental.Add(firstSkiSet);

            // Remove Ski
            Console.WriteLine(skiRental.Remove("Rossignol", "XC90")); // False
            Console.WriteLine(skiRental.Remove("Rossignol", "XC70")); // True

            Ski secondSkiSet = new Ski("Fischer", "SpeedMax", 2018);
            Ski thirdSkiSet = new Ski("Salomon", "TopLine", 2020);

            skiRental.Add(secondSkiSet);
            skiRental.Add(thirdSkiSet);

            // Get Newest Ski
            Ski newestSki = skiRental.GetNewestSki();
            Console.WriteLine(newestSki); // Salomon - TopLine - 2020

            // Get Ski
            Ski salomonTopLine = skiRental.GetSki("Salomon", "TopLine");
            Console.WriteLine(salomonTopLine); // Salomon - TopLine - 2020

            // Count
            Console.WriteLine(skiRental.Count); // 2

            // Get Statistics
            Console.WriteLine(skiRental.GetStatistics());
            // The skis stored in New Alpine ski rental:
            // Fischer - SpeedMax – 2018
            // Salomon - TopLine - 2020

        }

        private static void _02_Survivor()
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] beach = new char[rows][];
            int collected = 0;
            int oponentCollectionn = 0;
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                beach[i] = input.SelectMany(s => s).ToArray();
            }
            string[] command = { "", "", "", "" };
            while ((command = Console.ReadLine().Split())[0] != "Gong")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                if (row >= 0 && row < beach.Length && col >= 0 && col < beach[row].Length)
                {
                    if (command[0] == "Find")
                    {
                        if (beach[row][col] == 'T')
                        {
                            collected++;
                            beach[row][col] = '-';
                        }
                    }
                    else if (command[0] == "Opponent")
                    {
                        if (beach[row][col] == 'T')
                        {
                            oponentCollectionn++;
                            beach[row][col] = '-';
                        }
                        if (command[3] == "up")
                        {
                            int count = 0;
                            while (row - count >= 0 && count < 4)
                            {                                
                                if (beach[row - count][col] == 'T')
                                {
                                    oponentCollectionn++;
                                    beach[row - count][col] = '-';
                                }
                                count++;
                            }
                        }
                        else if (command[3] == "down")
                        {
                            int count = 0;
                            while (row + count < beach.Length  && count < 4)
                            {
                                
                                if (beach[row + count][col] == 'T')
                                {
                                    oponentCollectionn++;
                                    beach[row + count][col] = '-';
                                }
                                count++;
                            }
                        }
                        else if (command[3] == "left")
                        {
                            int count = 0;
                            while (col - count >= 0 && count < 4)
                            {
                                
                                if (beach[row ][col - count] == 'T')
                                {
                                    oponentCollectionn++;
                                    beach[row ][col - count] = '-';
                                }
                                count++;
                            }
                        }
                        else if (command[3] == "right")
                        {
                            int count = 0;
                            while (col + count < beach[row].Length && count < 4)
                            {
                                
                                if (beach[row][col + count] == 'T')
                                {
                                    oponentCollectionn++;
                                    beach[row][col + count] = '-';
                                }
                                count++;
                            }
                        }
                    }
                }
            }
            foreach (var item in beach)
            {
                Console.WriteLine(string.Join(" ", item));
            }
            Console.WriteLine($"Collected tokens: {collected}");
            Console.WriteLine($"Opponent's tokens: {oponentCollectionn}");
        }

        private static void _01_BirthdayCelebration()
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> food = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int wastedFood = 0;
            while (food.Count > 0 && guests.Count() > 0)
            {
                if (guests.Peek() < food.Peek())
                {
                    wastedFood += food.Pop() - guests.Dequeue();
                }
                else
                {
                    int fillGuest = guests.Dequeue();
                    while (fillGuest > 0 && food.Count() > 0)
                    {
                        if (fillGuest < food.Peek())
                        {
                            wastedFood += food.Pop() - fillGuest;
                            break;
                        }
                        else
                        {
                            fillGuest -= food.Pop();
                        }
                    }
                }
            }
            if (guests.Count > 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            }
            else
            {
                Console.WriteLine($"Plates: {string.Join(" ", food)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
