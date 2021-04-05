using System;
using System.Collections.Generic;
using System.Linq;
namespace Lists___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lists - Lab
                01. Sum Adjacent Equal Numbers

             * 
           

            List<double> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i = -1;
                   
                }
            }
            Console.WriteLine(string.Join(' ', input));

            02.Gauss' Trick
              
            List<double> input = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();

            for (int i = 0; i < input.Count- 1 ; i++)
            {
                
                    input[i] += input[input.Count - 1];
                    input.RemoveAt(input.Count - 1);
                    

                
            }

            Console.WriteLine(string.Join(' ', input));

            03.Merging Lists
           

            List<double> listOne = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToList();
            List<double> listTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            int count = 0;
            if (listOne.Count> listTwo.Count)
            {
                count = listOne.Count;
            }
            else
            {
                count = listTwo.Count;
            }

            List<double> endList = new List<double>();

            for (int i = 0; i < count; i++)
            {
                if (i < listOne.Count)
                {
                    endList.Add(listOne[i]);
                }
                if (i < listTwo.Count)
                {
                    endList.Add(listTwo[i]);
                }
            }

            Console.WriteLine(string.Join(' ', endList));

            04.List of Products

         


            listSort();

            void listSort()
            {
                int count = int.Parse(Console.ReadLine());
                List<string> sorted = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    string input = Console.ReadLine();
                    sorted.Add(input);

                }
                sorted.Sort();

                int index = 1;
                foreach (var item in sorted)
                {
                    Console.WriteLine($"{index}.{item}");
                    index++;
                }
            }


            05.Remove Negatives and Reverse
                

            List<double> listOne = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Where(n => n > 0)
                 .Reverse()
                 .ToList();
                 


            Console.WriteLine(string.Join(' ', listOne));

            06.List Manipulation Basics
            07
            
         

            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string [] commands ;
            bool changed = false;
            while ((commands = Console.ReadLine().Split().ToArray())[0] != "end")
            {

                switch (commands[0])
                {
                    case "Add":
                        input.Add(int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "Remove":
                        input.Remove(int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "Insert":
                        input.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "Contains":
                        bool check = input.Contains(int.Parse(commands[1]));
                        if (check == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        var mon = input.Where(n => n % 2 == 0);
                        Console.WriteLine(string.Join(' ', mon));
                        break;
                    case "PrintOdd":
                        var mon1 = input.Where(n => n % 2 == 1);
                        Console.WriteLine(string.Join(' ', mon1));
                        break;
                    case "GetSum":
                        var mon2 = input.Sum();
                        Console.WriteLine(mon2);
                        break;
                    case "Filter":
                        var mon3 = input;
                        if (commands[1] == "<")
                        {
                            mon3 = mon3.Where(n => n < int.Parse(commands[2])).ToList();
                            

                        }
                        else if (commands[1] == ">")
                        {
                            mon3=  mon3.Where(n => n > int.Parse(commands[2])).ToList();
                           
                        }
                        else if (commands[1] == ">=")
                        {
                            mon3 = mon3.Where(n => n >= int.Parse(commands[2])).ToList();
                            
                        }
                        else if (commands[1] == "<=")
                        {
                            mon3 = mon3.Where(n => n <= int.Parse(commands[2])).ToList();
                        }
                        Console.WriteLine(string.Join(' ', mon3));
                        break;
                    default:
                        break;
                }
            }
            if (changed == true)
            {
                Console.WriteLine(string.Join(' ', input));
            }
            

         */
        }
    }
}
