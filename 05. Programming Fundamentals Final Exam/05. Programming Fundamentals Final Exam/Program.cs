using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _05._Programming_Fundamentals_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
        /*https://judge.softuni.bg/Contests/Practice/Index/2302#1*/
            /*_01_ActivationKeys();*/
            /*_02_EmojiDetector();*/
            _03_Pirates();
        }
        class City
        {
            public string town { get; set; }
            public int gold { get; set; }
            public int people { get; set; }
        }
        private static void _03_Pirates()
        {           
            string [] city = {"","","" };
            List<City> cities = new List<City>();
            while ((city = Console.ReadLine().Split("||"))[0] != "Sail")
            {              
                City currentCity = new City();
                currentCity.town = city[0];
                currentCity.gold = int.Parse(city[2]);
                currentCity.people = int.Parse(city[1]);
                int index = 0;
                bool exists = false;
                for (int i = 0; i < cities.Count; i++)
                {
                    if (cities[i].town == city[0])
                    {
                        index = i;
                        exists = true;
                        break;
                    }
                }
                if (exists == true)
                {
                    cities[index].gold += currentCity.gold;
                    cities[index].people += currentCity.people;
                }
                else
                {
                    cities.Add(currentCity);
                }                              
            }
            string [] command = { "", "", "", "" };
            while ((command = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries))[0] != "End")
            {
                int index = 0;
                for (int i = 0; i < cities.Count; i++)
                {
                    if (cities[i].town == command[1])
                    {
                        index = i;
                        break;
                    }
                }
                City current = cities[index];
                if (command[0] == "Plunder")
                {
                    Console.WriteLine($"{command[1]} plundered! {command[3]} gold stolen, {command[2]} citizens killed.");                                                          
                    current.people -= int.Parse(command[2]);
                    current.gold -= int.Parse(command[3]);
                    if (current.gold <= 0 || current.people <= 0)
                    {
                        Console.WriteLine($"{current.town} has been wiped off the map!");
                        current = new City();
                        cities.RemoveAt(index);
                    }
                }
                else if (command[0] == "Prosper")
                {
                    if (int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        current.gold += int.Parse(command[2]);
                        Console.WriteLine($"{command[2]} gold added to the city treasury. {current.town} now has {current.gold} gold.");
                    }
                }
            }
            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities.OrderByDescending(n => n.gold).ThenBy(n => n.town))
                {
                    Console.WriteLine($"{item.town} -> Population: {item.people} citizens, Gold: {item.gold} kg");
                }
            }            
        }

        private static void _02_EmojiDetector()
        {
            string pattern = @"([\*?:]{2})([A-Z]{1}[a-z+]{2,})\1";
            string integers = @"[0-9]";
            string input = Console.ReadLine();
            MatchCollection numbers = Regex.Matches(input, integers);
            MatchCollection emoji = Regex.Matches(input, pattern);
            BigInteger threshold = 1;
            foreach (var item in numbers)
            {
                threshold *= BigInteger.Parse(item.ToString());
            }
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.Write($"{emoji.Count} emojis found in the text. ");
            Console.WriteLine("The cool ones are:");
            for (int i = 0; i < emoji.Count; i++)
            {
                BigInteger stringCoolness = 0;
                for (int j = 0; j < emoji[i].Groups[2].Length; j++)
                {
                    char test = emoji[i].Groups[2].ToString()[j];
                    stringCoolness += test;                                   
                }
                if (stringCoolness >  threshold)
                {
                    Console.WriteLine(emoji[i]);
                }
            }
        }

        private static void _01_ActivationKeys()
        {
            string input = Console.ReadLine();
            string[] command = {"","","","" };
            while ((command = Console.ReadLine().Split(">>>",StringSplitOptions.RemoveEmptyEntries))[0]!="Generate")
            {
                if (command[0] == "Slice")
                {
                    int endIndex = int.Parse(command[2]) - int.Parse(command[1]);
                    input = input.Remove(int.Parse(command[1]), endIndex);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Flip")
                {
                    int endIndex = int.Parse(command[3]) - int.Parse(command[2]);
                    string subStringer = input.Substring(int.Parse(command[2]), endIndex);
                    input = input.Remove(int.Parse(command[2]), endIndex);
                    if (command[1] == "Upper")
                    {
                        subStringer = subStringer.ToUpper();
                    }
                    else if (command[1] == "Lower")
                    {
                        subStringer = subStringer.ToLower();
                    }
                    input = input.Insert(int.Parse(command[2]), subStringer);
                    Console.WriteLine(input);
                }
                else if(command[0] == "Contains")
                {
                    if (input.Contains(command[1]))
                    {
                        Console.WriteLine($"{input} contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
