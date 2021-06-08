using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lists___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.softuni.bg/Contests/Compete/Index/1211#0
             * https://softuni.bg/trainings/resources/officedocument/60419/lists-exercise-csharp-fundamentals-may-2021/3365
             * 01. Train
            

            List<int> input = Console.ReadLine()
                .Split(' ',StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int max = int.Parse(Console.ReadLine());
            string [] command = {"","" };

            while ((command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries))[0] != "end")
            {
                if (command[0] == "Add")
                {
                    input.Add(int.Parse(command[1]));
                    continue;
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (int.Parse(command[0]) + input[i] <= max)
                    {
                        input[i] = int.Parse(command[0]) + input[i];
                        break;
                    }
                }

            }
            Console.WriteLine(string.Join(' ', input));

            02.Change List

            List<int> input = Console.ReadLine()
               .Split(' ', StringSplitOptions
               .RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            string[] command = { "", "" , ""};
            while ((command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    input.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

              
            }
            Console.WriteLine(string.Join(' ', input));

            03.House Party
            
         

            List<string> guests = new List<string>();

            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string [] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                if (command[2] == "going!")
                {
                    if (!guests.Contains(command[0]) )
                    {
                        guests.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }

                }
                else if(command[2] == "not")
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));


            04.List Operations
               

            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string[] command = { "", "", "" };
            while ((command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0] != "End")
            {
                if (command[0] == "Add")
                {
                    input.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) > input.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) > input.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    input.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] + " " + command[1] == "Shift left")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }                  
                }
                else if (command[0] + " " + command[1] == "Shift right")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        input.Insert(0, input[input.Count-1]);
                        input.RemoveAt(input.Count-1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));

            05.Bomb Numbers

             

            List<int> input = Console.ReadLine()
               .Split(' ', StringSplitOptions
               .RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int [] special = Console.ReadLine()
               .Split(' ', StringSplitOptions
               .RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            for (int i = 0; i < input.Count; i++)
            {
                List<int> indexesToRemove = new List<int>();

                if (input[i] == special[0])
                {
                    int power = special[1] *2 + 1;
                    int start = 0;
                    
                    if (i - special[1]< 0)
                    {
                        start = 0;
                    }
                    else
                    {
                        start = i -  special[1];
                    }
                    if (start + power > input.Count)
                    {
                        power =   input.Count  - start;

                    }
                   
                    input.RemoveRange(start, power);
                }
            }
            Console.WriteLine(input.Sum());

            06.Cards Game
           
            List<int> input = Console.ReadLine()
              .Split(' ', StringSplitOptions
              .RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            List<int> input1 = Console.ReadLine()
              .Split(' ', StringSplitOptions
              .RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            while (true)
            {
                if (input[0] == input1[0])
                {
                    input.RemoveAt(0);
                    input1.RemoveAt(0);
                    if (input.Count == 0)
                    {
                        break;
                    }
                    if (input1.Count == 0)
                    {
                        break;
                    }
                }
                else if (input[0] > input1[0])
                {
                    input.Add(input[0]);
                    input.Add(input1[0]);
                    input.RemoveAt(0);
                    input1.RemoveAt(0);
                    if (input1.Count == 0)
                    {
                        break;
                    }
                }
                else if (input[0] < input1[0])
                {
                    input1.Add(input1[0]);
                    input1.Add(input[0]);
                    
                    input1.RemoveAt(0);
                    input.RemoveAt(0);
                    if (input.Count == 0)
                    {
                        break;
                    }
                }
            }
            if (input.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: { input1.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: { input.Sum()}");
            }

            07.Append Arrays
          

            List<string> input = Console.ReadLine()
              .Split(new char[] { '|' }, StringSplitOptions
              .RemoveEmptyEntries)
              
              .Reverse()
              
              .ToList();
            List<string> input1 = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string a = input[i];
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] != ' ')
                    {
                        input1.Add(a[j].ToString());
                    }
                }
                
            }
            

            
            Console.WriteLine(string.Join(" ", input1));
               */
        }
    }
}
