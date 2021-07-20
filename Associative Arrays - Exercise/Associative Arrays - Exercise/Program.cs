using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Associative_Arrays___Exercise
{
    class Program
    {
        static void Main()
        {
            /*https://judge.softuni.bg/Contests/Compete/Index/1213#3
              https://softuni.bg/trainings/resources/officedocument/60427/associative-arrays-exercise-csharp-fundamentals-may-2021/3365
            */
            /*_01_CountCharsInAString();*/
            /*_02_AMinerTask();*/
            /*_03_LegendaryFarming();*/
            /*_04_Orders();*/
            /*_05_SoftUniParking();*/
            /*_06_Courses();*/
            /*_07_StudentAcademy();*/
            _08_CompanyUsers();
        }

        private static void _08_CompanyUsers()
        {
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            string[] command = { "", "" };
            while ((command = Console.ReadLine().Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToArray())[0] != "End")
            {
                if (output.ContainsKey(command[0]))
                {
                    bool checker = false;
                    for (int i = 0; i < output[command[0]].Count; i++)
                    {
                        if (output[command[0]][i] == command[1])
                        {
                            checker = true;
                            break;
                        }
                    }
                    if (checker == true)
                    {
                        continue;
                    }
                    output[command[0]].Add(command[1]);
                }
                else
                {                   
                    output.Add(command[0], new List<string> { command[1] });
                }
            }
            output = output.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            for (int i = 0; i < output.Count; i++)
            {
                var virb = output.ElementAt(i).Key;
                output[virb] = output.ElementAt(i).Value.OrderBy(n => n).ToList();
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}\n-- {string.Join(Environment.NewLine + "-- ", item.Value)}");
            }
        }

        private static void _07_StudentAcademy()
        {
            Dictionary<string, List<decimal>> output = new Dictionary<string, List<decimal>>();
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                string student = Console.ReadLine();
                decimal score = decimal.Parse(Console.ReadLine());
                if (output.ContainsKey(student))
                {
                    output[student].Add(score);
                }
                else
                {
                    output.Add(student, new List<decimal> { score });
                }
            }
            for (int i = 0; i < output.Count; i++)
            {
                string key = output.ElementAt(i).Key;
                decimal average = output.ElementAt(i).Value.Average();
                if (average < 4.50m)
                {
                    output.Remove(key);
                    i--;
                }
                else
                {
                    output[key] = new List<decimal> { average };
                }
            }
            for (int i = 0; i < output.Count; i++)
            {
                string key = output.ElementAt(i).Key;
                decimal value = output.ElementAt(i).Value[0];
                result.Add(key, value);
            }
            result = result.OrderByDescending(n => n.Value).ToDictionary(n => n.Key, n => n.Value);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }

        private static void _06_Courses()
        {
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            string[] command = { "", "", "" };
            while ((command = Console.ReadLine().Split(new [] {':'},StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToArray())[0]!= "end")
            {
                if (output.ContainsKey(command[0]))
                {
                    output[command[0]].Add(command[1]);
                }
                else
                {
                    output.Add(command[0], new List<string>{command[1]});
                }
            }
            output = output.OrderByDescending(n => n.Value.Count).ToDictionary(n => n.Key, n => n.Value);
            for (int i = 0; i < output.Count; i++)
            {
                var virb = output.ElementAt(i).Key;
                output[virb] =output.ElementAt(i).Value.OrderBy(n => n).ToList();
            }
            foreach (var item in output)
            {               
                Console.WriteLine($"{item.Key}: {output[item.Key].Count}\n-- {string.Join(Environment.NewLine + "-- ", item.Value)}");
            }
        }

        private static void _05_SoftUniParking()
        {
            Dictionary<string, string> output = new Dictionary<string, string>();
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "register")
                {
                    if (output.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {output[command[1]]}");
                    }
                    else
                    {
                        output.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (output.ContainsKey(command[1]))
                    {
                        output.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }               
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static void _04_Orders()
        {
            Dictionary<string, List<decimal>> output = new Dictionary<string, List<decimal>>();
            string[] command = { "", "", "" };
            while ((command = Console.ReadLine().Split())[0] != "buy" )
            {
                if (output.ContainsKey(command[0]))
                {
                    if (output[command[0]][0] == decimal.Parse(command[1]))
                    {
                        output[command[0]][1] += decimal.Parse(command[2]);
                    }
                    else
                    {
                        output[command[0]][0] = decimal.Parse(command[1]);
                        output[command[0]][1] += decimal.Parse(command[2]);
                    }                  
                }
                else
                {
                    output.Add(command[0], new List<decimal>{ decimal.Parse(command[1]), decimal.Parse(command[2]) });
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]}");
            }
        }
        private static void _03_LegendaryFarming()
        {
            Dictionary<string, int> output = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"fragments", 0 },
                {"motes", 0 },
            };
            bool winnerReached = false;
            string winner = "";
            while (winnerReached != true)
            {
                string[] inputArray = Console.ReadLine().Split().Select(n => n.ToLower()).ToArray();
                for (int i = 0; i < inputArray.Length; i += 2)
                {
                    if (output.ContainsKey(inputArray[i + 1]))
                    {
                        output[inputArray[i + 1]] += int.Parse(inputArray[i]);
                    }
                    else
                    {
                        output.Add(inputArray[i + 1], int.Parse(inputArray[i]));
                    }
                    if (output["shards"] >= 250)
                    {
                        winner = "Shadowmourne";
                        output["shards"] -= 250;
                        winnerReached = true;
                        break;
                    }
                    else if (output["fragments"] >= 250)
                    {
                        winner = "Valanyr";
                        output["fragments"] -= 250;
                        winnerReached = true;
                        break;
                    }
                    else if (output["motes"] >= 250)
                    {
                        winner = "Dragonwrath";
                        output["motes"] -= 250;
                        winnerReached = true;
                        break;
                    }
                }

            }
            Console.WriteLine($"{winner} obtained!");
            Dictionary<string, int> mainComponents = new Dictionary<string, int>()
           {
               {"shards", output["shards"] },{"fragments", output["fragments"] },{"motes", output["motes"] } 
           };
            mainComponents=  mainComponents.OrderByDescending(n => n.Value).ThenBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            output.Remove("shards");
            output.Remove("fragments");
            output.Remove("motes");
            output = output.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            /* mainComponents =  mainComponents.Reverse().ToDictionary(n => n.Key, n => n.Value);*/
            foreach (var item in mainComponents)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }           
        }

        private static void _02_AMinerTask()
        {
            string inputArray = "";
            Dictionary<string, long> output = new Dictionary<string, long>();
            while ((inputArray = Console.ReadLine()) != "stop")
            {
                long quantaty = long.Parse(Console.ReadLine());

                if (output.ContainsKey(inputArray))
                {
                    output[inputArray] += quantaty;
                }
                else
                {
                    output.Add(inputArray, quantaty);
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void _01_CountCharsInAString()
        {
            string[] inputArray = Console.ReadLine().Split();
            Dictionary<char, int> output = new Dictionary<char, int>();
            foreach (var item in inputArray)
            {
                string value = item;
                for (int i = 0; i < value.Length; i++)
                {
                    if (output.ContainsKey(value[i]))
                    {
                        output[value[i]]++;
                    }
                    else
                    {
                        output.Add(value[i], 1);
                    }
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
