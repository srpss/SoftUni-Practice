using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _02._Programming_Fundamentals_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://judge.softuni.bg/Contests/Practice/Index/2518#0*/
            /*_01_WorldTour();*/
            /*_02_DestinationMapper();*/
            _03_PlantDiscovery();
        }
        class Plant
        {
            public string plant_name { get; set; }
            public decimal rarity { get; set; }
            public decimal average_rating { get; set; }
            public int countRating { get; set; }
        }

        private static void _03_PlantDiscovery()
        {
            int cycleCount = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();
            for (int i = 0; i < cycleCount; i++)
            {
                string [] input = Console.ReadLine().Split("<->",StringSplitOptions.RemoveEmptyEntries);
                Plant current = new Plant();
                current.plant_name = input[0];
                current.rarity = decimal.Parse(input[1]);
                bool checker = false;
                int index = 0;
                for (int j = 0; j < plants.Count; j++)
                {
                    if (plants[j].plant_name == current.plant_name)
                    {
                        checker = true;
                        index = j;
                        break;
                    }
                }
                if (checker == true)
                {
                    plants[index].rarity = current.rarity;
                }
                else
                {
                    plants.Add(current);
                }
                
            }
            string[] command = { "", "", "", ""  };
            while ((command = Console.ReadLine().Split(new char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToArray())[0] != "Exhibition")
            {
                if (command[0] != "Rate" && command[0] != "Update" && command[0] != "Reset")
                {
                    Console.WriteLine("error");
                    continue;
                }
                int index = 0;
                bool checker = true;
                for (int i = 0; i < plants.Count; i++)
                {
                    if (plants[i].plant_name == command[1])
                    {
                        index = i;
                        checker = false;
                        break;
                    }
                }
                if (checker == true)
                {
                    Console.WriteLine("error");
                    continue;
                }
                Plant currentPlant = plants[index];
                if (command[0] == "Rate")
                {
                    currentPlant.countRating++;
                    currentPlant.average_rating += decimal.Parse(command[2]);
                }
                else if (command[0] == "Update")
                {
                    currentPlant.rarity = decimal.Parse(command[2]);
                }
                else if (command[0] == "Reset")
                {
                    currentPlant.average_rating = 0;
                    currentPlant.countRating = 0;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                if (item.average_rating != 0)
                {
                    item.average_rating = item.average_rating / item.countRating;
                }             
            }
            foreach (var item in plants.OrderByDescending(n => n.rarity).ThenByDescending(n => n.average_rating))
            {
                    Console.WriteLine($"- {item.plant_name}; Rarity: {item.rarity}; Rating: {item.average_rating:F2}"); 
            }
        }

        private static void _02_DestinationMapper()
        {
            string input = Console.ReadLine();
            string pattern = @"([=?\/])([A-Z][A-Za-z]{2,})\1";
            MatchCollection match = Regex.Matches(input, pattern);
            int points = 0;
            List<string> justNames = new List<string>();
            for (int i = 0; i < match.Count; i++)
            {
                points += match[i].Groups[2].Length;
                justNames.Add(match[i].Groups[2].ToString());
            }
            Console.WriteLine($"Destinations: {string.Join(", ", justNames)}");
            Console.WriteLine($"Travel Points: {points}");
        }

        private static void _01_WorldTour()
        {
            string input = Console.ReadLine();
            string[] command = { "", "", "", "" };
            while ((command = Console.ReadLine().Split(new char[] { ':' },StringSplitOptions.RemoveEmptyEntries))[0] != "Travel")
            {
                if (command[0] == "Add Stop")
                {
                    if (!(int.Parse(command[1]) > input.Length) || !(int.Parse(command[1]) < 0))
                    {
                        input = input.Insert(int.Parse(command[1]), command[2]);
                    }
                    Console.WriteLine(input);
                }
                else if (command[0] == "Remove Stop")
                {
                    if (!(int.Parse(command[1]) > input.Length) || !(int.Parse(command[1]) < 0))
                    {
                        int index = int.Parse(command[2]) - int.Parse(command[1]);
                        if (index + int.Parse(command[2]) > input.Length)
                        {
                            index = input.Length - int.Parse(command[1]);
                            input = input.Remove(int.Parse(command[1]), index + 1);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            input = input.Remove(int.Parse(command[1]), index + 1);
                            Console.WriteLine(input);
                        }                       
                    }
                }
                else if (command[0] == "Switch")
                {
                    if (input.Contains(command[1]))
                    {
                        input = input.Replace(command[1], command[2]);
                        Console.WriteLine(input);
                    }
                }            
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
