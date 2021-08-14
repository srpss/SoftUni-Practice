using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace Programming_Fundamentals_Final_Exam___14_August_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            _01_Problem();
            /*_02_Problem();*/
            /*_03_Problem();*/
        }

        private static void _03_Problem()
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            List<string> input = new List<string>();
            input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                List<string> a = input[i].Split(":", StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToList();
                List<string> b = new List<string> { a[1] };
                if (words.ContainsKey(a[0]))
                {
                    for (int j = 0; j < b.Count; j++)
                    {
                        words[a[0]].Add(b[j]);
                    }                    
                }
                else
                {
                    words.Add(a[0], b);
                }
            }
            List<string> teacherWords = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToList();
            string finalCommand = Console.ReadLine();
            if (finalCommand == "Test")
            {
                foreach (var item in words.OrderBy(n => n.Key).ToDictionary(n=> n.Key, n => n.Value))
                {
                    for (int i = 0; i < teacherWords.Count; i++)
                    {
                        if (item.Key == teacherWords[i])
                        {
                            Console.WriteLine($"{item.Key}:");
                            foreach (var item2 in item.Value.OrderByDescending(n => n.Length))
                            {
                                Console.WriteLine($"-{item2}");
                            }
                        }
                    }
                }
            }
            else if (finalCommand == "Hand Over")
            {
                words = words.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
                foreach (var item in words)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }

        private static void _02_Problem()
        {
            string pattern = @"!([A-Z][a-z]{2,})!:\[([A-Za-z]{8,})\]";
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, pattern);
                if (matches.Count == 0)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    List<int> encrypted = new List<int>();
                    for (int j = 0; j < matches[0].Groups[2].Length; j++)
                    {
                        encrypted.Add(matches[0].Groups[2].Value[j]);
                    }
                    Console.WriteLine($"{matches[0].Groups[1].Value}: {string.Join(' ', encrypted)}");
                }
            }
        }

        private static void _01_Problem()
        {
            string input = Console.ReadLine();
            string[] command = { "", "", "", "" };
            while ((command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0] != "Finish")
            {
                if (command[0] == "Replace")
                {
                    input = input.Replace(command[1], command[2]);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Cut")
                {
                    int power = int.Parse(command[2]) - int.Parse(command[1]);
                    if (int.Parse(command[1]) + power + 1 > input.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        input = input.Remove(int.Parse(command[1]), power + 1);
                        Console.WriteLine(input);
                    }
                }
                else if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    else
                    {
                        input = input.ToLower();
                    }
                    Console.WriteLine(input);
                }
                else if (command[0] == "Check")
                {
                    if (input.Contains(command[1]))
                    {
                        Console.WriteLine($"Message contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {command[1]}");
                    }
                }
                else if (command[0] == "Sum")
                {
                    int power = int.Parse(command[2]) - int.Parse(command[1]);
                    if (int.Parse(command[1])+ power+1 > input.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        string message = input.Substring(int.Parse(command[1]), power+1 );
                        int totalPoints = 0;
                        for (int i = 0; i < message.Length; i++)
                        {
                            totalPoints += message[i];
                        }
                        Console.WriteLine(totalPoints);
                    }
                }
            }
        }
    }
}
